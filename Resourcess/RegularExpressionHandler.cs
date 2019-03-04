using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Resources

{
    // regexhandler ska användas av view till att kontrollera att inmatade värden är riktiga. 
    public class RegularExpressionHandler
    {
        // Checks phone number input format using regular expressions. Current allowed formats:
        // (xxx)xxxxxxx
        // (xxx) xxxxxxx
        // (xxx)xxx-xxxx
        // (xxx) xxx-xxxx
        // xxxxxxxxxx
        // xxx-xxx-xxxxx
        // TODO: Add +xxx-xxx xx xx 
        public static Boolean IsValidPhone(string number)
        {
            bool isPhonenumber = false;

            Regex rx = new Regex(@"^\(?\d{3}\)?-? *\d{3}-? *-?\d{4}$");
            Match match = rx.Match(number);

            if (match.Success)
            {
                isPhonenumber = true;
            }
            return isPhonenumber;
        }

        // Checks email input format using regular expressions.
        public static Boolean IsValidEmail(string email)
        {
            bool isEmail = false;

            Regex rx = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = rx.Match(email);

            if (match.Success)
            {
                isEmail = true;
            }
            return isEmail;
        }
    }
}
