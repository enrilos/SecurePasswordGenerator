namespace SecurePasswordGenerator
{
    using SecurePasswordGenerator.src.Messages;
    using SecurePasswordGenerator.src.Models;
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            Messenger messages = new Messenger();
            Func<string, int> stringParser = x => int.Parse(x);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(messages.InputPasswordMessage);

            while (true)
            {
                try
                {
                    int length = stringParser(Console.ReadLine());

                    if (length <= messages.MinValue)
                    {
                        throw new ArgumentException(string.Format(messages.MinimumSymbolsRequiredMessage, messages.MinValue));
                    }
                    else if (length >= messages.MaxValue)
                    {
                        throw new ArgumentException(string.Format(messages.MaximumSymbolsAllowedMessage, messages.MaxValue));
                    }

                    PrintGeneratedPassword(length, messages);
                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void PrintGeneratedPassword(int length, Messenger messages)
        {
            RandomPassword password = new RandomPassword();
            password.GenerateRandomPassword(length);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(messages.OutputPasswordMessage);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(password);

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
