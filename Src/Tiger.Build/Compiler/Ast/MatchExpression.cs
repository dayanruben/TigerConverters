using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class MatchExpression : Expression, IEnumerable<GuardNode>
    {
        private readonly List<GuardNode> _guards = new List<GuardNode>();
        private Expression _implementation;
        public IEnumerable<Expression> Match { get; set; }

        public IEnumerable<GuardNode> Guards
        {
            get { return _guards; }
        }

        public override Type Type
        {
            get { return _implementation.Type; }
        }

        #region IEnumerable<GuardNode> Members

        public IEnumerator<GuardNode> GetEnumerator()
        {
            return _guards.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        public void Add(GuardNode node)
        {
            _guards.Add(node);
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            // todo use a block expression to code this expression, it's better than defining it inside a function
            
            string functionName = "#Eval";
            _implementation = new LetInExpression
                {
                    FunctionDefinitions = new List<FunctionDefinitionExpression>
                        {
                            new FunctionDefinitionExpression
                                {
                                    Name = new IdentifierNode {Name = functionName},
                                    ReturnTypeName = new TypeReferenceNode(Guards.First().Result.Type), //bug in the guards
                                    Body = new ListSemiExpression(from guard in Guards
                                                                  select new IfThenExpression
                                                                      {
                                                                          Test = MatchExpressions(Match, guard.Test),
                                                                          Then = new ReturnExpression
                                                                              {
                                                                                  Value = guard.Result
                                                                              }
                                                                      })
                                        {
                                            new ThrowExpression
                                                {
                                                    Expression = new NewExpression(typeof (ArgumentOutOfRangeException))
                                                },
                                            new DefaultValueExpression(Guards.First().Result.Type)
                                        }
                                }
                        },
                    Body = new ListSemiExpression
                        {
                            new FunctionInvokeExpression {FunctionName = new IdentifierNode {Name = functionName}}
                        }
                };

            _implementation.CheckSemantics(astHelper);
        }

        private Expression MatchExpressions(IEnumerable<Expression> match, IEnumerable<Expression> test)
        {
            if (match.Count() != test.Count()) return new BoolLiteral(false);

            IEnumerable<LogicalBinaryOperationExpression> comparisons = match.Zip(test, (m, t) => new LogicalBinaryOperationExpression
                {
                    Left = m,
                    Right = t,
                    Operator = TigerOperator.Equal
                });

            var result = new LogicalBinaryOperationExpression
                {
                    Left = new BoolLiteral(true),
                    Right = new BoolLiteral(true),
                    Operator = TigerOperator.AndAlso
                };

            LogicalBinaryOperationExpression temp = result;
            foreach (LogicalBinaryOperationExpression operation in comparisons)
            {
                temp.Left = operation;
                var next = new LogicalBinaryOperationExpression
                    {
                        Left = new BoolLiteral(true),
                        Right = new BoolLiteral(true),
                        Operator = TigerOperator.AndAlso
                    };
                temp.Right = next;
                temp = next;
            }

            return result;
        }

        protected internal override MAst Transform()
        {
            return _implementation.Transform();
        }
    }

    public class GuardNode : Node
    {
        public IEnumerable<Expression> Test { get; set; }

        public Expression Result { get; set; }
    }
}