namespace SecurePasswordGenerator.src.Messages.Contracts
{
    interface ILength
    {
        string MinimumSymbolsRequiredMessage { get; }

        string MaximumSymbolsAllowedMessage { get; }
    }
}
