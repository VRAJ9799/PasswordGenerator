using System.Text.RegularExpressions;

namespace PasswordGenerator
{
    class CheckPassword
    {
        public bool ValidPassword(string password, bool lower, bool upper, bool special, bool digits)
        {
            if (lower && !Regex.IsMatch(password, @"^.*[a-z].*$"))
            {
                return false;
            }
            if (upper && !Regex.IsMatch(password, @"^.*[A-Z].*$"))
            {
                return false;
            }
            if (digits && !Regex.IsMatch(password, @"^.*[0-9].*$"))
            {
                return false;
            }
            if (special && !Regex.IsMatch(password, @"^.*[!@#$%^&*].*$"))
            {
                return false;
            }
            return true;
        }
    }
}
