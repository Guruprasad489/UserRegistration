using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserReg
    {
        //UC1 - Method to Validate First Name entered by user using lambda statement(UC14)
        public static Func<string, string> ValidateFirstName = firstName =>
        {
            try
            {
                string firstName_pattern = "^[A-Z][a-zA-Z]{2,}$";

                if (firstName.Equals(string.Empty))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.EMPTY_MESSAGE_EXCEPTION, "First name should not be empty");
                }
                if (Regex.IsMatch(firstName, firstName_pattern))
                {
                    Console.WriteLine("First Name is Valid");
                    return firstName;
                }
                else
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.INVALID_MESSAGE_EXCEPTION, "First Name is not Valid");
                }
            }
            catch (UserRegistrationException ex)
            {
                return ex.Message;
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        };

        //UC2 - Method to Validate Last Name entered by user using lambda statement(UC14)
        public static Func<string, string> ValidateLastName = lastName =>
        {
            try
            {
                string lastName_pattern = "^[A-Z][a-zA-Z]{2,}$";

                if (lastName.Equals(string.Empty))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.EMPTY_MESSAGE_EXCEPTION, "Last name should not be empty");
                }
                if (Regex.IsMatch(lastName, lastName_pattern))
                {
                    Console.WriteLine("Last Name is Valid");
                    return lastName;
                }
                else
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.INVALID_MESSAGE_EXCEPTION, "Last Name is not Valid");
                }
            }
            catch (UserRegistrationException ex)
            {
                return ex.Message;
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        };

        //UC3 - Method to Validate Email-ID entered by user using lambda statement(UC14)
        public static Func<string, string> ValidateEmail = email =>
        {
            try
            {
                string email_pattern = @"^[a-zA-Z0-9]{3,10}([._+-][a-zA-Z0-9]{1,10})?@[a-zA-Z0-9]{1,10}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";

                if (email.Equals(string.Empty))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.EMPTY_MESSAGE_EXCEPTION, "Email should not be empty");
                }
                if (Regex.IsMatch(email, email_pattern))
                {
                    Console.WriteLine("Email is Valid");
                    NLog.SuccessInfo("Email-ID is Valid: " + email);
                    return email;
                }
                else
                {
                    NLog.ErrorInfo("Email-ID is not Valid: " + email);
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.INVALID_MESSAGE_EXCEPTION, "Email is not Valid");
                }
            }
            catch (UserRegistrationException ex)
            {
                return ex.Message;
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        };

        //UC4 - Method to Validate Mobile Number entered by user using lambda statement(UC14)
        public static Func<string, string> ValidateMobileNumber = mobNum =>
        {
            try
            {
                string mobNum_pattern = "^[+]?91[ -][1-9][0-9]{9}$";

                if (mobNum.Equals(string.Empty))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.EMPTY_MESSAGE_EXCEPTION, "Mobile Number should not be empty");
                }
                if (Regex.IsMatch(mobNum, mobNum_pattern))
                {
                    Console.WriteLine("Mobile Number is Valid");
                    return mobNum;
                }
                else
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.INVALID_MESSAGE_EXCEPTION, "Mobile Number is not Valid");
                }
            }
            catch (UserRegistrationException ex)
            {
                return ex.Message;
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        };

        //UC5, UC6, UC7, UC8  - Method to Validate Password entered by user using lambda statement(UC14)
        public static Func<string, string> ValidatePassword = password =>
        {
            try
            {
                //string password_Pattern = "^[a-zA-Z]{8,}$";                                               //UC5: Password must contain min 8 characters
                //string password_pattern = "^(?=.*[a-z])(?=.*[A-Z]).{8,}$";                                //UC6: UC5 + atleast 1 Upper Case
                //string password_Pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,}$";                     //UC7: UC6 + atleast 1 numeric number
                string password_Pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[&%$#@?^*!~]).{8,}$";     //UC8: UC7 + 1 special character

                if (password.Equals(string.Empty))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.EMPTY_MESSAGE_EXCEPTION, "Password should not be empty");
                }
                if (Regex.IsMatch(password, password_Pattern))
                {
                    Console.WriteLine("Password is Valid");
                    NLog.SuccessInfo("Password is Valid: " + password);
                    return password;
                }
                else
                {
                    NLog.ErrorInfo("Invalid Password: " + password);
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.INVALID_MESSAGE_EXCEPTION, "Password is not Valid");
                }
            }
            catch (UserRegistrationException ex)
            {
                return ex.Message;
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        };
    }
}
