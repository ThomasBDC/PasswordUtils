using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PasswordUtils
{
    public static class PasswordTester
    {
        private static string numerics = "0123456789";
        private static string charsMAJ = "AZERTYUIOPQSDFGHJKLMWXCVBN";
        private static string charsMIN = "azertyuiopqsdfghjklmwxcvbn";
        private static string chars = charsMAJ + charsMIN;
        private static string specialChars = "!@#$%^&*()-_+=[]{}\\|;:'\",.<>/?`~¡¿¢£€¥©®™§°µ±×÷¶†‡";

        public static PasswordStrength GetStrengthPassword(string password)
        {
            int securityPts = 0;

            bool haveCharacters = PasswordContainsOneOfThis(password, chars);
            bool haveNumerics = PasswordContainsOneOfThis(password, numerics);
            bool haveMAJ = PasswordContainsOneOfThis(password, charsMAJ);
            bool haveMIN = PasswordContainsOneOfThis(password, charsMIN);
            bool haveSpecialChars = PasswordContainsOneOfThis(password, specialChars);
            bool moreThat8Chars = password.Length > 8;
            bool moreThat12Chars = password.Length > 12;

            if(moreThat8Chars)
            {
                securityPts++;
            }
            if(moreThat12Chars)
            {
                securityPts++;
            }
            if (haveMAJ && haveMIN)
            {
                securityPts++;
            }
            if (haveCharacters && haveNumerics)
            {
                securityPts++;
            }
            if (haveSpecialChars)
            {
                securityPts++;
            }

            switch(securityPts)
            {
                case 0:
                case 1:
                    return PasswordStrength.Weak;
                case 2:
                case 3:
                    return PasswordStrength.Normal;
                case 4:
                    return PasswordStrength.Strong;
                case 5:
                default:
                    return PasswordStrength.Invincible;
            }
        }

        //Retourner si le mot de passe contient un élément de la chaine donnée
        private static bool PasswordContainsOneOfThis(string password, string chaineATester)
        {
            return password.Any(ch => chaineATester.Contains(ch));
        }
    }
    
    public enum PasswordStrength
    {
        Weak, 
        Normal, 
        Strong,
        Invincible
    }
}
