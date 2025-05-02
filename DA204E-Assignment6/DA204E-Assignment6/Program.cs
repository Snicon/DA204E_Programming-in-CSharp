// Sixten Peterson (AQ9300) 2025-04-30
namespace DA204E_Assignment6
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application. Left unchanged
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}