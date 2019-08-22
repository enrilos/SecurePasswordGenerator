namespace SecurePasswordGenerator.src.Core
{
    using SecurePasswordGenerator.src.Core.Contracts;
    using SecurePasswordGenerator.src.Messages;
    using SecurePasswordGenerator.src.Models;
    using SecurePasswordGenerator.src.Models.Contracts;
    using System;

    public class Engine : IEngine
    {
       private PasswordMessenger messages;

        public void Run()
        {
            this.messages = new PasswordMessenger();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(messages.InputPasswordMessage);

            while (true)
            {
                try
                {
                    int length = int.Parse(Console.ReadLine());

                    if (length <= messages.MinValue)
                    {
                        throw new ArgumentException(string.Format(messages.MinimumSymbolsRequiredMessage, messages.MinValue));
                    }
                    else if (length >= messages.MaxValue)
                    {
                        throw new ArgumentException(string.Format(messages.MaximumSymbolsAllowedMessage, messages.MaxValue));
                    }

                    PrintGeneratedPassword(length);
                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private  void PrintGeneratedPassword(int length)
        {
            IRandomPassword password = new RandomPassword();
            password.GenerateRandomPassword(length);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(messages.OutputPasswordMessage);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(password);

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
