using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using Antlr.Runtime;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Parsing;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    /// <summary>
    ///   Represent the root of every tiger program
    /// </summary>
    public class ProgramExpression : Expression
    {
        private static readonly IEnumerable<string> _keyWords = new[]
            {
                "int", "string", "bool",
                "if", "then",
                "while", "for", "to", "do",
                "let", "in", "end",
                "type", "var", "array", "of", "function",
                "not",
                "true", "false",
                "break", "continue", "nil"
            };

        public static IEnumerable<string> KeyWords
        {
            get { return _keyWords; }
        }

        public override Type Type
        {
            get { return Program.Type; }
        }

        #region Ast members

        public Expression Program { get; set; }

        #endregion

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            Program.CheckSemantics(astHelper);
        }

        /// <summary>
        ///   returns the expression that this program represents.
        /// </summary>
        /// <returns></returns>
        public MAst Compile()
        {
            var assemblyName = new AssemblyName(Guid.NewGuid().ToString()) {Version = new Version(1, 0)};
            AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName,
                                                                                            AssemblyBuilderAccess.Run);
            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("Program");

            var ast = new AstHelper(moduleBuilder);
            ast.Types.Add("int", typeof (int));
            ast.Types.Add("string", typeof (string));
            ast.Types.Add("bool", typeof (bool));

            Program.CheckSemantics(ast);

            return Transform();
        }

        public static MAst CompileFile(AstHelper runtime, string fileName)
        {
            var stream = new ANTLRFileStream(fileName);
            return Compile(runtime, stream);
        }

        public static MAst Compile(AstHelper runtime, string program)
        {
            var stream = new ANTLRStringStream(program);
            return Compile(runtime, stream);
        }

        public static MAst Compile(AstHelper runtime, ICharStream stream)
        {
            var lexer = new TigerLexer(stream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new TigerParser(tokens);
            ProgramExpression programExpression = parser.parse();

            if (parser.NumberOfSyntaxErrors > 0)
            {
                IEnumerable<string> errors = from e in parser.Errors
                                             select e.ToString();

                throw new SyntaxException(errors);
            }

            AstHelper helper = runtime.CreateChild(function: true, variables: true, types: true);
            programExpression.CheckSemantics(helper);

            if (helper.Errors.HasErrors)
            {
                throw new SemanticException(helper.Errors);
            }

            return programExpression.Transform();
        }

        protected internal override MAst Transform()
        {
            return Program.Transform();
        }

        public MAst Compile(AstHelper runtime)
        {
            Program.CheckSemantics(runtime);

            return Transform();
        }
    }
}