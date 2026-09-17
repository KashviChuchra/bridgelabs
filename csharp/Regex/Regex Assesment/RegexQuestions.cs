using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexQuestions.Regex_Assesment
{
    internal class RegexQuestions
    {
        public bool ValidateSocialSecurityNumber(string str)
        {
            if (string.IsNullOrEmpty(str)) return false;
            string pattern = @"^[0-9]{3}-[0-9]{2}-[0-9]{4}$";
            return Regex.IsMatch(str, pattern);
        }

        public string FindRepeatingWord(string str)
        {

        }

        public void ExtractCurrency(string str)
        {
            string pattern = @"\$\s+[0-9]+(?:\.[0-9]{2})?";
            MatchCollection match =  Regex.Matches(str, pattern);
            foreach(Match m in match)
            {
                Console.WriteLine(m.Value);
            }
        }

        public void ExtractProgrammingLanguageName(string str)
        {
            MatchCollection match = Regex.Matches(str, @"\b(Java|Python|Go|JavaScript)\b");
            // Use boundary as Go can be matched for Good
            foreach(Match m in match){
                Console.WriteLine(m.Value+",");
            }
        }
        public bool ValidateCreditCard(string str)
        {
            if (string.IsNullOrEmpty(str)) return false;
            string pattern = @"^[4-5]\d{15}$";
            return Regex.IsMatch(str,pattern);
        }

        public bool ValidateIpAddress(string str)
        {
            if (string.IsNullOrEmpty(str)) return false;
            string pattern = @"^[0-255]\.[0-255]\.[0-255]\.[0-255]$";
            return Regex.IsMatch(str, pattern);

        }

        public string CensorBadWords(string str)
        {
            if (string.IsNullOrEmpty(str)) return str;
            string s= Regex.Replace(str, @"\b(damn|stupid)\b","****");
            return s;
        }

        public string ReplaceString(string str)
        {
            string s = Regex.Replace(str, @"\s+"," ");
            return s;
        }
        public void ExtractLinks(string str)
        {
            if (string.IsNullOrEmpty(str)) return ;
            string pattern = @"http(s)?\://[^\s]+";
            MatchCollection match = Regex.Matches(str, pattern);
            foreach (Match m in match)
            {
                Console.WriteLine(m.Value);
            }
        }

        public void ExtractDate(string str)
        {
            if (string.IsNullOrEmpty(str)) return;
            string pattern = @"\b[0-9]{2}/[0-9]{2}/[0-9]{4}\b";
            MatchCollection match = Regex.Matches(str, pattern);
            foreach (Match m in match)
            {
                Console.WriteLine(m.Value);
            }
        }
        public void ExtractCapitalizedWords(string str)
        {
            if (string.IsNullOrEmpty(str)) return;
            string pattern = @"\b([A-Z][a-zA-Z]*)\b";
            MatchCollection match = Regex.Matches(str, pattern);
            foreach (Match m in match)
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
