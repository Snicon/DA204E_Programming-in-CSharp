// Sixten Peterson (AQ9300) 2025-04-22
namespace DA204E_Assignment5
{
    /// <summary>
    /// A utility class used for popups and prompts during validation. Typially used when a user has written invalid input or if the user presses cancel and needs to confirm.
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
        /// <param name="title">The title of the message box</param>
        /// <param name="message">The message to be show to the user.</param>
        /// <returns>A DialogResult based on the button pressed by the user.</returns>
        public static DialogResult AskUser(string title, string message)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
