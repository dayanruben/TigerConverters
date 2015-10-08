using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Windows.Data;
using Tiger.Build.Compiler.Ast;
using Expression = System.Linq.Expressions.Expression;

namespace Tiger.WpfConverters
{
    public class ValueConverter : IValueConverter
    {
        public string Program { get; set; }

        public string ReverseProgram { get; set; }

        private Func<object, object, object> Current { get; set; }

        private Func<object, object, object> ReverseCurrent { get; set; }

        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Func<object, object, object> func = Current ?? (Current = CreateFunc(Program));
            return func(value, parameter);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (string.IsNullOrEmpty(ReverseProgram))
                return Convert(value, targetType, parameter, culture);
            else
            {
                Func<object, object, object> func = ReverseCurrent ?? (ReverseCurrent = CreateFunc(ReverseProgram));
                return func(value, parameter);
            }
        }

        #endregion

        private static Func<object, object, object> CreateFunc(string program)
        {
            var assemblyName = new AssemblyName(Guid.NewGuid().ToString()) {Version = new Version(1, 0)};
            AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName,
                                                                                            AssemblyBuilderAccess.Run);
            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("Program");

            ParameterExpression valueParameter = Expression.Parameter(typeof (object), "value");
            ParameterExpression parameterParameter = Expression.Parameter(typeof (object), "parameter");

            AstHelper astHelper = AstHelper.Default(moduleBuilder);
            astHelper.Variables.Add("value", valueParameter);
            astHelper.Variables.Add("parameter", parameterParameter);

            Expression rootExpression = ProgramExpression.Compile(astHelper, program);

            Expression<Func<object, object, object>> lambda =
                Expression.Lambda<Func<object, object, object>>(Expression.Convert(rootExpression, typeof (object)),
                                                                valueParameter, parameterParameter);
            return lambda.Compile();
        }
    }
}