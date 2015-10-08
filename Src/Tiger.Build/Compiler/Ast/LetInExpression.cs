using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class LetInExpression : Expression
    {
        #region Ast members

        public List<TypeDeclarationNode> TypeDeclarations { get; set; }

        public List<VariableDeclarationBase> VariableDeclarations { get; set; }

        public List<FunctionDefinitionExpression> FunctionDefinitions { get; set; }

        public ListSemiExpression Body { get; set; }

        public void AddType(TypeDeclarationNode type)
        {
            TypeDeclarations.Add(type);
        }

        public void AddVar(VariableDeclarationBase variable)
        {
            VariableDeclarations.Add(variable);
        }

        public void AddFunc(FunctionDefinitionExpression func)
        {
            FunctionDefinitions.Add(func);
        }

        #endregion

        /// <summary>
        ///   After the node is prepared this list should hold a collection
        ///   with all the variables and functions that are accesed from this expression
        ///   and child ones. For now we add here all variables available at this point
        ///   and let the DLR do the work.
        /// </summary>
        private IEnumerable<ParameterExpression> _closure;

        public LetInExpression()
        {
            VariableDeclarations = new List<VariableDeclarationBase>();
            TypeDeclarations = new List<TypeDeclarationNode>();
            FunctionDefinitions = new List<FunctionDefinitionExpression>();
        }

        public override Type Type
        {
            get
            {
                // the let in expression returns the type of the last expression
                return Body.Type;
            }
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            AstHelper helper = astHelper.CreateChild(function: true, variables: true, types: true);

            // add all type builders to the scope in case of recursive type calls
            foreach (IAddToScope typeDeclarationNode in TypeDeclarations.OfType<IAddToScope>())
                typeDeclarationNode.AddToScope(helper);

            var error = new CircularTypeReferencesError(TypeDeclarations, Start);
            astHelper.Errors.Check(error);
            // define other types
            foreach (TypeDeclarationNode typeDeclarationNode in error.OrderedTypes)
                typeDeclarationNode.CheckSemantics(helper);

            // add all functions to the scope in case of recursive calls
            foreach (FunctionDefinitionExpression functionDefinitionExpression in FunctionDefinitions)
                functionDefinitionExpression.AddToScope(helper);

            foreach (VariableDeclarationBase variableDeclarationExpression in VariableDeclarations)
                variableDeclarationExpression.CheckSemantics(helper);

            foreach (FunctionDefinitionExpression functionDefinitionExpression in FunctionDefinitions)
                functionDefinitionExpression.CheckSemantics(helper);

            Body.CheckSemantics(helper);

            IEnumerable<ParameterExpression> variables = from variable in VariableDeclarations select variable.Pointer;
            IEnumerable<ParameterExpression> functions = from function in FunctionDefinitions select function.Pointer;
            // calculate the closure that will be used when we're generating the expression
            _closure = variables.Union(functions);
        }

        protected internal override MAst Transform()
        {
            IEnumerable<MAst> variableAssignments = from variableDeclarationExpression in VariableDeclarations
                                                    let variableAssign = variableDeclarationExpression.Transform()
                                                    select variableAssign;

            IEnumerable<MAst> functionAssignments = from functionDefinitionExpression in FunctionDefinitions
                                                    let functionAssign = functionDefinitionExpression.Transform()
                                                    select functionAssign;

            IEnumerable<MAst> letBody = functionAssignments.Union(variableAssignments).Union(new[] {Body.Transform()});

            return MAst.Block(_closure, letBody);
        }
    }
}