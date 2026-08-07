using System;
using System.Collections.Generic;
using System.Text;
using ProductionCode;

namespace TestCode
{
    internal class UserRegisterationTest
    {
        private UserRegisteration user;
        [SetUp]
        public void SetUp()
        {
            user = new UserRegisteration();
        }

        [TestCase("_kashvichuchra","chuchrakashvi@gmail.com","Kashvi123", "User Successfully Registered!")]
        public void Check_RegistredUser_UsernameEmailPassword(string username, string email, string password, string expected)
        {
            string result = user.RegisterUser(username, email, password);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
