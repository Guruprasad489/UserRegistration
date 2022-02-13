using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistration;

namespace UserRegTesting
{
    [TestClass]
    public class UserRegTestCases
    {
        //Test case to validate user first name
        //Arrange 
        [TestCategory("User FirstName")]
        [TestMethod]
        [DataRow("Guru", "Guru")]
        [DataRow("guru", "First Name is not Valid")]
        [DataRow("", "First name should not be empty")]
        [DataRow(null, "Object reference not set to an instance of an object.")]
        public void TestFirstName(string userInput, string expected)
        {
            ///Act
            string actual = UserReg.ValidateFirstName(userInput);

            ///Asert
            Assert.AreEqual(expected, actual);
        }

        //Test case to validate user last name
        //Arrange
        [TestCategory("User LastName")]
        [TestMethod]
        [DataRow("Kumbar", "Kumbar")]
        [DataRow("kumbar", "Last Name is not Valid")]
        [DataRow("", "Last name should not be empty")]
        [DataRow(null, "Object reference not set to an instance of an object.")]
        public void TestLastName(string userInput, string expected)
        {
            ///Act
            string actual = UserReg.ValidateLastName(userInput);

            ///Asert
            Assert.AreEqual(expected, actual);
        }

        //Test case for validating Email Id
        //Arrange   
        [TestCategory("User EmailId")]
        [TestMethod]
        [DataRow("", "Email should not be empty")]
        [DataRow(null, "Object reference not set to an instance of an object.")]
        [DataRow("abc@gmail.com", "abc@gmail.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc111@yahoo.com", "abc111@yahoo.com")]
        [DataRow("abc111@abc.com", "abc111@abc.com")]
        [DataRow("abc-100@abc.net", "abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
        [DataRow("abc@1.com", "abc@1.com")]
        [DataRow("abc@gmail.com.com", "abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com", "abc+100@gmail.com")]
        [DataRow("abc", "Email is not Valid")]
        [DataRow("abc@.com.my", "Email is not Valid")]
        [DataRow("abc123@.com", "Email is not Valid")]
        [DataRow("abc123@.com.com", "Email is not Valid")]
        [DataRow("abc()*@gmail.com", "Email is not Valid")]
        [DataRow(".abc@abc.com", "Email is not Valid")]
        [DataRow("abc@%*.com", "Email is not Valid")]
        [DataRow("abc..2002@gmail.com", "Email is not Valid")]
        [DataRow("abc.@gmail.com", "Email is not Valid")]
        [DataRow("abc@abc@gmail.com", "Email is not Valid")]
        [DataRow("abc@gmail.com.1a", "Email is not Valid")]
        [DataRow("abc@gmail.com.aa.au", "Email is not Valid")]
        public void TestUserEmailId(string userData, string expected)
        {
            ///Act
            string actual = UserReg.ValidateEmail(userData);

            ///Asert
            Assert.AreEqual(expected, actual);
        }


        //Test case for validating phone number
        [TestCategory("User Phone Number")]
        [TestMethod]
        [DataRow("91 1234567890", "91 1234567890")]
        [DataRow("+91-9113544214", "+91-9113544214")]
        [DataRow("91-9113544214", "91-9113544214")]
        [DataRow("91 0123456789", "Mobile Number is not Valid")]
        [DataRow("91123456789", "Mobile Number is not Valid")]
        [DataRow("9112345678", "Mobile Number is not Valid")]
        [DataRow("91+123456789", "Mobile Number is not Valid")]
        [DataRow("91 12345678901112", "Mobile Number is not Valid")]
        [DataRow("", "Mobile Number should not be empty")]
        [DataRow(null, "Object reference not set to an instance of an object.")]
        public void TestUserPhoneNumber(string userInput, string expected)
        {
            ///Act
            string actual = UserReg.ValidateMobileNumber(userInput);

            ///Asert
            Assert.AreEqual(expected, actual);
        }

        //Test case for validating user password
        [TestCategory("User Password")]
        [TestMethod]
        [DataRow("Abcd@1234", "Abcd@1234")]
        [DataRow("hjGHJv12#", "hjGHJv12#")]
        [DataRow("?hjghjGHJGHgj21345GH", "?hjghjGHJGHgj21345GH")]
        [DataRow("GHJKFGJFYJ", "Password is not Valid")]
        [DataRow("GHJGHjghjfgj", "Password is not Valid")]
        [DataRow("hgfgh#123554", "Password is not Valid")]
        [DataRow("HGgf@#1", "Password is not Valid")]
        [DataRow("", "Password should not be empty")]
        [DataRow(null, "Object reference not set to an instance of an object.")]
        public void TestUserPassword(string userInput, string expected)
        {
            ///Act
            string actual = UserReg.ValidatePassword(userInput);

            ///Asert
            Assert.AreEqual(expected, actual);
        }
    }
}
