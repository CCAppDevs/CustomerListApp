using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomerListApp
{
    public class Validators
    {
        public static bool IsValidPhone(string phone)
        {
            // is it null, contain only whitespace, or is empty? FAILURE
            if (string.IsNullOrWhiteSpace(phone) || string.IsNullOrEmpty(phone))
            {
                return false;
            }
            ;

            // phone has text. VALID
            return true;
        }

        public static bool ContainsValue(string text)
        {
            // is it null, contain only whitespace, or is empty? FAILURE
            if (string.IsNullOrWhiteSpace(text) || string.IsNullOrEmpty(text))
            {
                return false;
            }
            ;

            // text has contents. VALID
            return true;
        }

        public static bool IsValidEmail(string email)
        {
            // check for the pattern of an email address using regex
            string pattern = @"^([a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6})*$";

            return Regex.IsMatch(email, pattern);
        }
    }
}
