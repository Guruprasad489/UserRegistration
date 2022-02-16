using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UserRegUsingAnnotationAndReflection
{
    public class UserRegReflector
    {
        UserRegUsingAnnotation user = new UserRegUsingAnnotation();           //Create Object

        //UC 13 - Method to UserReg with Parameter constructor using reflection
        public object CreateUserRegObject(string className, string constructorName, UserRegUsingAnnotation user)
        {
            Type type = typeof(ValidateUserReg);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {

                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo constructorInfo = type.GetConstructor(new Type[] { typeof(UserRegUsingAnnotation) });
                    var obj = constructorInfo.Invoke(new object[] { user });
                    return obj;
                }
                else
                {
                    throw new UserRegCustomException(UserRegCustomException.ExceptionType.CLASS_NOT_FOUND, "Class not found");
                }
            }
            else
            {
                throw new UserRegCustomException(UserRegCustomException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "Constructor not found");
            }
        }

        //UC 13 - Method to set field dynamically using reflection
        public string Setproperty(string propertyName, string userValue)
        {
            Type type = user.GetType();                   
            PropertyInfo propertyInfo = type.GetProperty(propertyName);     //Get property of which value to be assigned
            if (propertyInfo == null)
            {
                throw new UserRegCustomException(UserRegCustomException.ExceptionType.FIELD_NOT_FOUND, "Field not found");
            }
            else
            {
                if (propertyName.Equals(propertyInfo.Name))
                {
                    propertyInfo.SetValue(user, userValue, null);
                    return userValue;
                }
            }
            return default;
        }

        //UC 13 - Invoke method using reflector
        public void InvokeMethod(string methodName)
        {
            try
            {
                UserRegReflector reflector = new UserRegReflector();
                Type type = typeof(ValidateUserReg);
                MethodInfo methodinfo = type.GetMethod(methodName);
                object testUserRegObject = reflector.CreateUserRegObject("UserRegUsingAnnotationAndReflection.ValidateUserReg", "ValidateUserReg", user);
                object method = methodinfo.Invoke(testUserRegObject, null);
            }
            catch (NullReferenceException)
            {
                throw new UserRegCustomException(UserRegCustomException.ExceptionType.METHOD_NOT_FOUND, "Method not found");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
