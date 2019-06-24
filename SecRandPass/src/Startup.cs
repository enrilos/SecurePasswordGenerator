namespace SecurePasswordGenerator
{
    using SecurePasswordGenerator.src.Core;

    public class Startup
    {
        public static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.Run();
        }
    }
}
