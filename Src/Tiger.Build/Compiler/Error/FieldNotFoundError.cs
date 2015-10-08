using System;
using System.Reflection;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    public class FieldNotFoundError : MemberNotFoundError
    {
        private readonly bool _isActive;

        public FieldNotFoundError(Type targetType, string fieldName, SourceLocation location)
            : base(targetType, fieldName, location)
        {
            FieldInfo fieldInfo = targetType.GetField(fieldName);
            if (fieldInfo != null)
            {
                PropertyType = fieldInfo.FieldType;
                _isActive = false;
            }
            else
            {
                PropertyInfo propertyInfo = targetType.GetProperty(fieldName);
                if (propertyInfo != null)
                {
                    PropertyType = propertyInfo.PropertyType;
                    _isActive = false;
                }
                else
                {
                    _isActive = true;
                }
            }
        }

        public Type PropertyType { get; private set; }

        public override bool IsActive
        {
            get { return _isActive; }
        }

        protected override string GetMessage()
        {
            return string.Format("The field {0} is not defined for the type {1}", MemberName, TargetType.Name);
        }
    }
}