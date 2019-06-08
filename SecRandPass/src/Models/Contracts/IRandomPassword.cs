namespace SecurePasswordGenerator.src.Models.Contracts
{
    public interface IRandomPassword
    {
        void GenerateRandomPassword(int passwordStrength);
    }
}
