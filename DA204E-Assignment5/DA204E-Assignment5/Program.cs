// Sixten Peterson (AQ9300) 2025-04-21
namespace DA204E_Assignment5
{
    /// <summary>
    /// The class housing the entry point of the application, all left default.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
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