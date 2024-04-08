using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordUtils
{
    public static class PasswordTester
    {
        private static string numerics = "0123456789";
        private static string chars = "azertyuiopqsdfghjklmwxcvbnAZERTYUIOPQSDFGHJKLMWXCVBN";

        public static PasswordStrength GetStrengthPassword(string password)
        {
            bool haveCharacters = password.Any(ch => chars.Contains(ch));
            bool haveNumerics = password.Any(characters => numerics.Contains(characters));

            if (password.Length < 8)
            {
                return PasswordStrength.Weak;
            }
            else
            {
                if (haveNumerics && haveCharacters)
                {
                    return PasswordStrength.Strong;
                }
                else
                {
                    return PasswordStrength.Normal;
                }
            }
        }
    }
    
    public enum PasswordStrength
    {
        Weak, 
        Normal, 
        Strong
    }
}
