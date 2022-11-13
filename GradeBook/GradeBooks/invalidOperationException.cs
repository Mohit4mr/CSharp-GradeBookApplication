using System;
using System.Runtime.Serialization;

namespace GradeBook.GradeBooks
{
    [Serializable]
    internal class invalidOperationException : Exception
    {
        public invalidOperationException()
        {
        }

        public invalidOperationException(string message) : base(message)
        {
        }

        public invalidOperationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected invalidOperationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}