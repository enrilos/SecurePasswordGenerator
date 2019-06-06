namespace SecurePasswordGenerator.src.Messages
{
    public class Messenger
    {
        public Messenger()
        {
        }

        public int MinValue { get; } = 5;

        public int MaxValue { get; } = 1024;

        public string InputPasswordLengthMessage { get; } = "Enter password length: ";

        public string OutputPasswordMessage { get; } = "Your password is: ";

        public string MinimumSymbolsMessage { get; } = "Password should be more than 5 symbols.";

        public string MaximumSymbolsMessage { get; } = "Password should be less than 1024 symbols.";

    }
}
