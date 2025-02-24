// Sixten Peterson (AQ9300) 2025-02-19
namespace DA204E.A2C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Temperature program
            TemperatureConverter converter = new TemperatureConverter();
            converter.Start();

            // String functions program
            StringFunctions stringFunctions = new StringFunctions();
            stringFunctions.Start();
        }
    }
}
