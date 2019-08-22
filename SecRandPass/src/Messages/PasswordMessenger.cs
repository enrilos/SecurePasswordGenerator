namespace SecurePasswordGenerator.src.Messages
{
    using SecurePasswordGenerator.src.Messages.Contracts;

    public class PasswordMessenger : IInputOutput, ILength, IValue
    {
        public int MinValue { get; } = 5;

        public int MaxValue { get; } = 1024;

        public string InputPasswordMessage { get; } = "Enter password length: ";

        public string OutputPasswordMessage { get; } = "Your password is: ";

        public string MinimumSymbolsRequiredMessage { get; } = "Password should be more than {0} symbols.";

        public string MaximumSymbolsAllowedMessage { get; } = "Password should be less than {0} symbols.";

    }
}
