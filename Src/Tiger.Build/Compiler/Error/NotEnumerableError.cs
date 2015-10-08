using System;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    public class NotEnumerableError : ErrorBase
    {
        private readonly bool _isActive;

        public NotEnumerableError(Type targetType, SourceLocation location) : base(location)
        {
            TargetType = targetType;

            try
            {
                CollectionType = TypeUtils.GetCollectionType(targetType);
            }
            catch (ArgumentException e)
            {
                _isActive = true;
            }
        }

        public Type TargetType { get; private set; }

        public override bool IsActive
        {
            get { return _isActive; }
        }

        public Type CollectionType { get; private set; }

        protected override string GetMessage()
        {
            throw new NotImplementedException();
        }
    }
}