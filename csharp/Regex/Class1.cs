using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Text;
using System.Text.RegularExpressions;


namespace RegexPractice
{
    internal class Class1
    {
        public bool OnlyDigits(string input)
        {
            if(string.IsNullOrEmpty(input)) return false;   
            return Regex.IsMatch(input,@"^\d+$");
        }

        public bool OnlyAlphabets(string input)
        {
            if(string.IsNullOrEmpty(input)) return false;
            return Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }
        public bool AlphaNumeric(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            return Regex.IsMatch(input, @"^[a-zA-Z0-9]+$");
        }

        //Username should contain letters, digits and underscore, 3–15 characters.
        public bool IsUsername(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            //return Regex.IsMatch(input,@"[a-zA-Z0-9_]{3,15}");
            return Regex.IsMatch(input, @"\w{3,15}");

        }

        public bool PasswordValidation(string input)
        {
            // not-efficient way
            //if (input.Length < 8) return false;
            //if (!Regex.IsMatch(input, @"[A-Z]*")) return false;
            //if (!Regex.IsMatch(input, @"[a-z]*")) return false;
            //if (!Regex.IsMatch(input, @"[0-9]*")) return false;
            //if (Regex.IsMatch(input, @"[^a-zA-Z0-9]")) return false;
            //return true;

            // efficient way - using Lookaheads

            return Regex.IsMatch(input, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,}$");
        }

        public bool StrongPassword(string input)
        {
            return Regex.IsMatch(input, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{9,}$");
        }
    }
}
