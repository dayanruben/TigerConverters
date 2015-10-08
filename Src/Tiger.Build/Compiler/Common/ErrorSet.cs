using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Compiler.Ast
{
    public class ErrorSet : AddOnlyList<ErrorBase>
    {
        public bool HasErrors
        {
            get { return Count > 0; }
        }

        /// <summary>
        /// if the error <see cref="ErrorBase.IsActive"/> then is added to the error
        /// collection and the method returns true
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        public bool Check(ErrorBase error)
        {
            if (error.IsActive)
            {
                Add(error);
                return true;
            }
            return false;
        }
    }
}