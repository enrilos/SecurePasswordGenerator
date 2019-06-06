namespace SecurePasswordGenerator.src.Contracts
{
    public interface IRandomPassword
    {
        void GenerateRandomPassword(int passwordStrength);
    }
}
