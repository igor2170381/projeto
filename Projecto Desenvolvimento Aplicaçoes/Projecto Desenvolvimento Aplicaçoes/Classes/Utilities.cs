using System;
using System.Text.RegularExpressions;

namespace Projecto_Desenvolvimento_Aplicaçoes.Classes
{
    public static class Utilities
    {
        public static bool ValidateInt(string Number, int neededLength,int maxvalue)
        {
            bool IsValid = true;

            if (Regex.IsMatch(Number, "^[0-9]*$") && Number.Length == neededLength)
            {

            }
            else if(Regex.IsMatch(Number, "^[0-9]*$") && Number.Length <= maxvalue)
            {
               
            }
            else
            {
                IsValid = false;
            }

            return IsValid;
        }

        public static bool ValidateString(string String, bool canContainNumbers)
        {
            bool IsValid = true;

            if (canContainNumbers == false)
            {
                if (String.Length > 0 && Regex.IsMatch(String, "^[a-zA-Z\\s]*$"))
                {
                }
                else
                {
                    IsValid = false;
                }
            }
            else
            {
                if (String.Length > 0 && Regex.IsMatch(String, "^[A-Za-z0-9\\s]*$"))
                {
                }
                else
                {
                    IsValid = false;
                }
            }

            return IsValid;
        }
    }
}