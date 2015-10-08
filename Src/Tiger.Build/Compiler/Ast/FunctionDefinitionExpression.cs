using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Error;
using MAst = System.Linq.Expressions.Expression;

namespace Tiger.Build.Compiler.Ast
{
    public class FunctionDefinitionExpression : Expression, IAddToScope
    {
        #region Ast members

        public IdentifierNode Name { get; set; }

        public TypeReferenceNode ReturnTypeName { get; set; }

        public Expression Body { get; set; }

        public IEnumerable<FunctionParameterExpression> Parameters { get; set; }

        #endregion

        private LabelTarget _returnLabel;

        public FunctionDefinitionExpression()
        {
            Parameters = Enumerable.Empty<FunctionParameterExpression>();

            // this property is optional
            ReturnTypeName = new TypeReferenceNode();
        }

        public override Type Type
        {
            get { return ReturnTypeName.HasType ? ReturnTypeName.ReferencedType : typeof (void); }
        }

        /// <summary>
        /// after the function has been added to the scope, this variable
        /// will represent a pointer to the function
        /// </summary>
        public ParameterExpression Pointer { get; private set; }

        #region IAddToScope Members

        /// <summary>
        ///   Add the current function to the scope
        /// </summary>
        /// <param name = "astHelper"></param>
        public void AddToScope(AstHelper astHelper)
        {
            Name.CheckSemantics(astHelper);
            ReturnTypeName.CheckSemantics(astHelper);

            astHelper.Errors.Check(new SomeParametersWithTheSameNameError(Parameters, Start));

            foreach (FunctionParameterExpression functionParameterExpression in Parameters)
                functionParameterExpression.CheckSemantics(astHelper);

            Type[] argTypes = Parameters.Select(param => param.Type).ToArray();
            Type delegateType = ReturnTypeName.HasType
                                    ? MAst.GetFuncType(new List<Type>(argTypes) {Type}.ToArray())
                                    : MAst.GetActionType(argTypes);

            Pointer = MAst.Parameter(delegateType);

            bool error = false;

            error |= astHelper.Errors.Check(new MemberWithSameSignatureAlreadyDefinedError(
                                                Name.Name, argTypes, astHelper, Name.Start));
            error |= astHelper.Errors.Check(new VariableAlreadyDefinedError(Name.Name, astHelper, Start));

            if (!error)
                astHelper.Functions.Add(Name.Name, new FunctionReference(Pointer, Type, argTypes));
        }

        #endregion

        protected internal override MAst Transform()
        {
            // for more info on LambdaExpressions returning values see pag. 28 of 'expr-tree-spec.doc'
            // 2.8.1 Ensuring Returns are Lexical Exits with Matching Types
            LabelExpression labelBody = MAst.Label(_returnLabel, Body.Transform());

            // reduces as a LambdaExpression
            LambdaExpression function = MAst.Lambda(labelBody, Parameters.Select(parameter =>
                                                                                 (ParameterExpression)
                                                                                 parameter.Transform()));

            return MAst.Assign(Pointer, function);
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            _returnLabel = MAst.Label(Type);
            AstHelper helper = astHelper.CreateChild(variables: true, returning: true, returnLabel: _returnLabel);

            // add the variables to the child scope
            foreach (FunctionParameterExpression functionParameterExpression in Parameters)
                functionParameterExpression.AddToScope(helper);

            Body.CheckSemantics(helper);

            astHelper.Errors.Check(new TypeMismatchedError(Type, Body.Type, Start));
        }
    }
}