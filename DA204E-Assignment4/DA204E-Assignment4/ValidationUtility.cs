// Sixten Peterson (AQ9300) 2025-04-08
namespace DA204E_Assignment4
{
    /// <summary>
    /// A utility static class making it "easier" to show message boxes in a consistent way. Not toally necessary but I like this way of doing it.
    /// </summary>
    public static class ValidationUtility
    {
        /// <summary>
        /// Warns the user based on the provided message
        /// </summary>
        /// <param name="message">The message to be shown to the user.</param>
        public static void WarnUser(string message)
        {
            MessageBox.Show(message, "Whoops!");
        }

        /// <summary>
        /// Asks the user about incomplete data based on the provided message and allows the user to either press yer or no.
        /// </summary>
        /// <param name="message">The message to be show to the user.</param>
        /// <returns>A DialogResult bsaed on the button pressed by the user.</returns>
        public static DialogResult AskUser(string message)
        {
            return MessageBox.Show(message, "Incomplete data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
