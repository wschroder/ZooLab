using System;

namespace Zoo.Common.Exceptions
{
    public class ValidationException : ApplicationException
    {
        public ValidationException(string message): base(message)
        {
        }

        public ValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
