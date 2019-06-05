namespace SecurePasswordGenerator
{
    using System;

    public class Startup
    {
        private const int minValue = 7;
        private const int maxValue = 1024;
        private const string SecRandPassVersion = "Secure Password Generator v1.0";
        private const string PasswordLengthMessage = "How long should the password be? : ";
        private const string ErrorMessage = "Password length accepts only numbers in range {0} and {1}.";

        public static void Main()
        {
            int passwordStrength = GetUsersPasswordStrength();

            RandomPassword randomPassword = new RandomPassword(passwordStrength);

            PrintGeneratedPassword(randomPassword);
        }

        private static void PrintGeneratedPassword(RandomPassword randomPassword)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(randomPassword);

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static int GetUsersPasswordStrength()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(string.Format(SecRandPassVersion));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(string.Format(PasswordLengthMessage));

            while (true)
            {
                try
                {
                    int passwordStrength = int.Parse(Console.ReadLine());
                    while (passwordStrength < minValue || passwordStrength > maxValue)
                    {
                        Console.WriteLine(string.Format(ErrorMessage, minValue, maxValue));
                        passwordStrength = int.Parse(Console.ReadLine());
                    }

                    return passwordStrength;
                }
                catch (Exception)
                {
                    //if (ex.GetType().Name == nameof(OverflowException))
                    //{
                    //}
                    Console.WriteLine(string.Format(ErrorMessage, minValue, maxValue));
                }
            }
        }
    }
}
