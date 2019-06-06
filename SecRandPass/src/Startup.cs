namespace SecurePasswordGenerator
{
    using System;
    using System.Text;

    public class Startup
    {
        private const int minValue = 5;
        private const int maxValue = 1024;
        private const string PasswordLengthMessage = "Enter password length: ";
        private const string PasswordReceiverMessage = "Your password is: ";
        private const string PasswordShouldBeLongerMessage = "Password should be more than {0} symbols.";
        private const string PasswordShouldBeLessMessage = "Password should be less than {0} symbols.";

        public static void Main(string[] args)
        {
            Func<string, int> intParser = x => int.Parse(x);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write(string.Format(PasswordLengthMessage));

            while (true)
            {
                try
                {
                    int length = intParser(Console.ReadLine());

                    if (length <= minValue)
                    {
                        throw new ArgumentException(string.Format(PasswordShouldBeLongerMessage, minValue));
                    }

                    else if (length > maxValue)
                    {
                        throw new ArgumentException(string.Format(PasswordShouldBeLessMessage, maxValue));
                    }

                    RandomPassword password = new RandomPassword();
                    password.GenerateRandomPassword(length);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(string.Format(PasswordReceiverMessage));

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(password);

                    Console.ForegroundColor = ConsoleColor.Gray;
                    return;
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
