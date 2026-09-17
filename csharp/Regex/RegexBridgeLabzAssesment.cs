using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    internal class RegexBridgeLabzAssesment
    {
        public bool ValidateUsername(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            return Regex.IsMatch(input, @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$");
            // {4,14} because first -> 1 , second 4,14=> overall 5,15
        }
        public bool ValidateLicensePlateNumber(string input)
        {
            if(string.IsNullOrEmpty(input)) return false;
            return Regex.IsMatch(input, @"^[A-Z]{2}\d{4}$");
        }

        public bool ValidateHexCode(string input)
        {
            if(string.IsNullOrEmpty (input)) return false;
            return Regex.IsMatch(input, @"^[#][a-fA-F0-9]{6}$");
        }

        public void ExtractEmailAddress(string email)
        {
            MatchCollection match = Regex.Matches(email, @"[^@\s]+@[^@\s]+\.[^@\s]+");
            foreach(Match m in match)
            {
                Console.WriteLine(m.Value);
            }
        }

        public void CapatalizeWords(string input)
        {
            MatchCollection match = Regex.Matches(input, @"[A-Z]");
            foreach(Match m in match)
            {
                Console.WriteLine(m.Value);
            }
        }
        //public void ExtractDate(string input)
        //{
        //    MatchCollection match = Regex.Matches(input, @"[0-");
        //}

        public void ExtractLink(string input)
        {
            MatchCollection match = Regex.Matches(input, @"https?://[a-zA-Z0-9.-]+\.[a-zA-Z.]{2,}");
            foreach(Match m in match)
            {
                Console.WriteLine(m.Value);
            }
        }

        public void CensorBadWords(string input)
        {

        }
        public bool VaidateIpAddress(string input)
        {
            return Regex.IsMatch(input, @"[0-255]+\.[0-255]+\.[0-255]+\.[0-255]+");
        }
        public bool ValidateCreditCardNumber(string input)
        {
            return Regex.IsMatch(input, @"[4-5][0-9]{15}");
        }
        public void ExtractProgrammingLanguageName(string input)
        {

        }
        public void ExtractCurrency(string input)
        {
            MatchCollection match = Regex.Matches(input, @"$[0-9.][0-9]");
            foreach(Match m in match)
            {
                Console.WriteLine(m.Value);
            }
        }
        public void FindRepeatingWords(string input)
        {

        }
        public bool ValidateSSN(string input)
        {
            if (string.IsNullOrEmpty(input)) return true;
            return Regex.IsMatch(input, @"[0-9]{3}-[0-9]{2}-[0-9]{4}");
        }
    }
}
