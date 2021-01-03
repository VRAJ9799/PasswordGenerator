using System;
using System.Text;

namespace PasswordGenerator
{
    class GeneratePassword
    {
        bool RequireLowerCase { get; set; }
        bool RequireUpperCase { get; set; }
        bool RequireSpecialCharacter { get; set; }
        bool RequireDigits { get; set; }
        int RequireLength { get; set; }

        public GeneratePassword(bool lower, bool upper, bool special, bool digits, int len)
        {
            this.RequireLowerCase = lower;
            this.RequireUpperCase = upper;
            this.RequireSpecialCharacter = special;
            this.RequireDigits = digits;
            this.RequireLength = len;
        }
        public string GetPassword()
        {
            string lowerCharacter = "abcdefghijklmnopqrstuvwxyz";
            string upperCharacter = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string specialCharacter = "!@#$%^&*";
            string digits = "0123456789";
            StringBuilder generatedPassword = new StringBuilder();
            StringBuilder str = new StringBuilder();
            if (RequireLowerCase)
            {
                str.Append(lowerCharacter);
            }
            if (RequireUpperCase)
            {
                str.Append(upperCharacter);
            }
            if (RequireDigits)
            {
                str.Append(digits);
            }
            if (RequireSpecialCharacter)
            {
                str.Append(specialCharacter);
            }
            Random random = new Random();
            for (int i = 0; i < RequireLength; i++)
            {
                int a = random.Next(0, str.Length);
                generatedPassword.Append(str[a]);
            }
            return generatedPassword.ToString();
        }
    }
}