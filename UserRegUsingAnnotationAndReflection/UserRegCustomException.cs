using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegUsingAnnotationAndReflection
{
    public class UserRegCustomException :Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            FIELD_NOT_FOUND,
            METHOD_NOT_FOUND,
            CLASS_NOT_FOUND,
            CONSTRUCTOR_NOT_FOUND
        }
        public UserRegCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
