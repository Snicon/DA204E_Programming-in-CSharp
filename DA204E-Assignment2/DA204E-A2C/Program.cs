namespace DA204E.A2C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureConverter converter = new TemperatureConverter();
            converter.Start();

            StringFunctions stringFunctions = new StringFunctions();
            stringFunctions.Start();
        }
    }
}
