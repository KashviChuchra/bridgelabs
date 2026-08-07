using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionCode
{
    public class UserRegisteration
    {
        public string RegisterUser(string username, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentNullException("Username is required");
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentNullException("Email is required");
            }
            if (!email.Contains('@'))
            {
                throw new ArgumentNullException("Invalid Email!");

            }
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentNullException("Password is required");
            }
            if (password.Length < 8)
            {
                throw new ArgumentOutOfRangeException("Password should contain at least 8 characters");
            }
            return "User Successfully Registered!";
        }
    }
}
