using System.Runtime.Serialization;

namespace StackTest
{
    [Serializable]
    public class FallStackException : Exception
    {
        public FallStackException() : base("Stack is full")
        {
            //empty constructor 
        }

        //tap-parameter constructor 
        public FallStackException(string? message) : base(message)
        {
            //empty constructor 

        }

        public FallStackException(string? message, Exception? innerException) : base(message, innerException)
        {
            //empty constructor 

        }

        protected FallStackException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            //empty constructor 

        }
    }
}