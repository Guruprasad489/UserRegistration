using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserRegistrationException : Exception
    {
        //Declaring exception type 
        public ExceptionTypes type;

        //Using enum to define Exception Types (constants)
        public enum ExceptionTypes
        {
            INVALID_MESSAGE_EXCEPTION,
            EMPTY_MESSAGE_EXCEPTION
        }

        //Constructor to initialize the enum exception types
        public UserRegistrationException(ExceptionTypes type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
