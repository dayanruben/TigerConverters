using System.Collections.Generic;
using System.Linq;
using Tiger.Build.Compiler.Ast;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    public class SomeParametersWithTheSameNameError : ErrorBase
    {
        public SomeParametersWithTheSameNameError(IEnumerable<FunctionParameterExpression> parameters,
                                                  SourceLocation location) : base(location)
        {
            Parameters = parameters;
        }

        public IEnumerable<FunctionParameterExpression> Parameters { get; private set; }

        public override bool IsActive
        {
            get
            {
                IEnumerable<string> functions = Parameters.Select(p => p.Name.Name).Distinct();
                return Parameters.Count() != functions.Count();
            }
        }

        protected override string GetMessage()
        {
            return "All parameters must have a different name";
        }
    }
}