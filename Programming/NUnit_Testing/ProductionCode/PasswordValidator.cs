using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionCode
{
    public class PasswordValidator
    {
        public bool PasswordCheck(string password)
        {
            int ch = 0;
            int uc = 0;
            int digit = 0;

            char[] str=password.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'a' && str[i] <= 'z'))
                {
                    ch++;
                }
                else if (char.IsUpper(str[i]))
                {
                    uc++;
                    ch++;
                }
                else if (char.IsNumber(str[i]))
                {
                    digit++;
                    ch++;
                }
                if (digit > 1) return false;
                if(uc>1) return false;
                
            }
            if(ch<8) return false;
            return true;
        }
    }
}
