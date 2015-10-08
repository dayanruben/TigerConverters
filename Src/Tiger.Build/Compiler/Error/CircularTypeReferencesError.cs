using System.Collections.Generic;
using System.Linq;
using Tiger.Build.Compiler.Ast;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    public class CircularTypeReferencesError : ErrorBase
    {
        // bug the circular type references aren't determined pretty well

        private readonly IEnumerable<TypeDeclarationNode> _types;
        private bool _isActive;

        public CircularTypeReferencesError(IEnumerable<TypeDeclarationNode> types, SourceLocation location)
            : base(location)
        {
            _types = types;

            OrderedTypes = CheckForCircularTypeReferences(_types).ToList();
        }

        /// <summary>
        /// returns the types that can be generated ordered just how they should
        /// be added to the scope
        /// </summary>
        public IEnumerable<TypeDeclarationNode> OrderedTypes { get; private set; }

        public override bool IsActive
        {
            get { return _types.Count() != OrderedTypes.Count(); }
        }

        private static IEnumerable<TypeDeclarationNode> CheckForCircularTypeReferences(
            IEnumerable<TypeDeclarationNode> references)
        {
            List<TypeDeclarationNode> referenceList = references.ToList();
            var graph = (from type in referenceList
                         // this type depends on any other??
                         let usesSomeone = type is IReferenceType && (from t in referenceList
                                                                      let reference = (IReferenceType) type
                                                                      where
                                                                          reference.ExistingType.TypeName == t.Name.Name
                                                                      select t).Count() != 0
                         select new {type, usesSomeone}).ToList();

            IEnumerable<TypeDeclarationNode> parentTypes = from type in graph where !type.usesSomeone select type.type;
            IEnumerable<TypeDeclarationNode> otherTypes = from type in graph where type.usesSomeone select type.type;

            bool continueWithOtherNodes = false;
            foreach (TypeDeclarationNode typeDeclarationNode in parentTypes)
            {
                yield return typeDeclarationNode;
                continueWithOtherNodes = true;
            }

            if (!continueWithOtherNodes)
                yield break;

            foreach (TypeDeclarationNode checkForCircularTypeReference in CheckForCircularTypeReferences(otherTypes))
                yield return checkForCircularTypeReference;
        }

        protected override string GetMessage()
        {
            return "Circular type references in let-in expression, some types can't be generated";
        }
    }
}