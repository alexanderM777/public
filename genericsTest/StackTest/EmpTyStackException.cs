using System.Runtime.Serialization;

namespace StackTest
{
    [Serializable]
    public class EmpTyStackException : Exception
    {
        public EmpTyStackException():  base("Stack is empty")
        {
            //empty constructor 
        }

        //tap-parameter constructor 
        public EmpTyStackException(string? message) : base(message)
        {
            //empty constructor 

        }

        public EmpTyStackException(string? message, Exception? innerException) : base(message, innerException)
        {
            //empty constructor 

        }

        protected EmpTyStackException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            //empty constructor 

        }
    }
}