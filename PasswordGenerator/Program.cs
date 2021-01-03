using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckPassword checkPassword = new CheckPassword();
            string finalPassword = "";
            bool done = false;
            bool lower = false;
            bool upper = false;
            bool special = false;
            bool digit = false;
            Console.Write("Lower Case Required(type yes or y otherwise no considered) : ");
            string input = Console.ReadLine().Trim();
            if (input == "yes" || input == "y" || input == "Yes")
            {
                lower = true;
                input = "";
            }
            Console.Write("Upper Case Required(type yes or y otherwise no considered) : ");
            input = Console.ReadLine().Trim();
            if (input == "yes" || input == "y" || input == "Yes")
            {
                upper = true;
                input = "";
            }

            Console.Write("Special Case Required(type yes or y otherwise no considered) : ");
            input = Console.ReadLine().Trim();
            if (input == "yes" || input == "y" || input == "Yes")
            {
                special = true;
                input = "";
            }

            Console.Write("Digits Case Required(type yes or y otherwise no considered) : ");
            input = Console.ReadLine().Trim();
            if (input == "yes" || input == "y" || input == "Yes")
            {
                digit = true;
                input = "";
            }

            Console.Write("Length Required (number) : ");
            int len = int.Parse(Console.ReadLine());
            do
            {
                GeneratePassword generatePassword = new GeneratePassword(lower, upper, special, digit, len);
                finalPassword = generatePassword.GetPassword();
                done = checkPassword.ValidPassword(finalPassword, lower, upper, special, digit);
            } while (!done);
            Console.WriteLine("Password is : {0} ", finalPassword);
            Console.ReadKey();
        }
    }
}
