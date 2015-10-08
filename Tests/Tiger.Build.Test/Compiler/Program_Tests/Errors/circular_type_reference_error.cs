// ReSharper disable InconsistentNaming

using System.Linq;
using NUnit.Framework;
using Tiger.Build.Compiler.Ast;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Test.Compiler.Errors
{
    [TestFixture]
    [Category("Program_Errors")]
    public class circular_type_reference_error
    {
        [Test]
        public void circular_type_references()
        {
            try
            {
                const string program =
                    @"let
    type a = b 
    type b = c
    type c = d
    type d = b
in 
end";

                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as CircularTypeReferencesError;
                Assert.IsNotNull(error);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void detect_cicle_with_three_types()
        {
            var typeA = new AliasTypeDeclarationNode
                {
                    ExistingType = new TypeReferenceNode
                        {
                            TypeName = "b"
                        },
                    Name = new TypeIdentifierNode
                        {
                            Name = "a"
                        }
                };
            var typeB = new AliasTypeDeclarationNode
                {
                    ExistingType = new TypeReferenceNode
                        {
                            TypeName = "c"
                        },
                    Name = new TypeIdentifierNode
                        {
                            Name = "b"
                        }
                };
            var typeC = new AliasTypeDeclarationNode
                {
                    ExistingType = new TypeReferenceNode
                        {
                            TypeName = "a"
                        },
                    Name = new TypeIdentifierNode
                        {
                            Name = "c"
                        }
                };
            var types = new[] {typeA, typeB, typeC};

            var target = new CircularTypeReferencesError(types, SourceLocation.Invalid);

            Assert.IsTrue(target.IsActive);
        }

        [Test]
        public void invalid_mutually_recursive_function_declaration_4_depth()
        {
            try
            {
                const string program =
                    @"let
    function f(b : B) : int = g(b.field)
    type B = {field : int}
    function g(i : int) : int = h(B{field = i+2})
    type C = B
    var a:= 1
    function h(c : C) : int = i(b.field + c.field)
    var b:= C{field = 1}
    function i(i : int) : int = f(i)
in
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as CircularTypeReferencesError;

                Assert.IsNotNull(error);
                Assert.AreEqual(9, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void invalid_mutually_recursive_record_declaration()
        {
            try
            {
                const string program =
                    @"/* The woman test. */
let
    type Woman = {beauty : int}
in
    let
        type Men = {wife : Woman} 
        var a:= 1
        type Woman = {husband : Men}
    in
        
    end
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as CircularTypeReferencesError;

                Assert.IsNotNull(error);
                Assert.AreEqual(8, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void invalid_mutually_recursive_record_declaration_4_depth()
        {
            // bug found recursive types not determined
            try
            {
                const string program =
                    @"let
        type B = {field : A}
        type A = {field : C}
        type C = G
        type G = {field : H}
        type H = B
in

end";

                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as CircularTypeReferencesError;

                Assert.IsNotNull(error);
                Assert.AreEqual(10, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void multiple_alias_errors()
        {
            try
            {
                const string program =
                    @"let
    type a = b
    type b = c
    type c = d
    type d = b
in 
    let
        type g = h
        type h = non_defined
    in
        2
    end
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(4, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void returns_types_not_involved_in_cicle()
        {
            var typeA = new AliasTypeDeclarationNode
                {
                    ExistingType = new TypeReferenceNode
                        {
                            TypeName = "b"
                        },
                    Name = new TypeIdentifierNode
                        {
                            Name = "a"
                        }
                };
            var typeB = new AliasTypeDeclarationNode
                {
                    ExistingType = new TypeReferenceNode
                        {
                            TypeName = "a"
                        },
                    Name = new TypeIdentifierNode
                        {
                            Name = "b"
                        }
                };
            var typeC = new AliasTypeDeclarationNode
                {
                    ExistingType = new TypeReferenceNode
                        {
                            TypeName = "int"
                        },
                    Name = new TypeIdentifierNode
                        {
                            Name = "c"
                        }
                };
            var types = new[] {typeA, typeB, typeC};

            var target = new CircularTypeReferencesError(types, SourceLocation.Invalid);

            CollectionAssert.AreEqual(new[] {typeC}, target.OrderedTypes);
            Assert.IsTrue(target.IsActive);
        }

        [Test]
        public void use_type_defined_below()
        {
            var typeA = new AliasTypeDeclarationNode
                {
                    ExistingType = new TypeReferenceNode
                        {
                            TypeName = "b"
                        },
                    Name = new TypeIdentifierNode
                        {
                            Name = "a"
                        }
                };
            var typeB = new AliasTypeDeclarationNode
                {
                    ExistingType = new TypeReferenceNode
                        {
                            TypeName = "int"
                        },
                    Name = new TypeIdentifierNode
                        {
                            Name = "b"
                        }
                };
            var types = new[] {typeA, typeB};

            var target = new CircularTypeReferencesError(types, SourceLocation.Invalid);

            CollectionAssert.AreEqual(new[] {typeB, typeA}, target.OrderedTypes);
            Assert.IsFalse(target.IsActive);
        }
    }
}