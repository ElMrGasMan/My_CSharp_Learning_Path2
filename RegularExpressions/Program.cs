using System.Text.RegularExpressions;

namespace RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "My phone number is (455) 239-1440.";

            Console.WriteLine(PhoneNumberRegex(text));
        }

        /// <summary>
        /// Searches for a "user@domain.com" pattern in a text.
        /// </summary>
        /// <param name="text"> The text to analize.</param>
        /// <returns> The first ocurrence of the matched pattern as a string.</returns>
        public static string EmailRegex(string text)
        {
            string pattern = @"\b(?x) [\w-%]+?@[a-zA-Z0-9]+?\.com";

            Regex regex = new(pattern);
            Match match = regex.Match(text);

            return match.ToString();
        }

        /// <summary>
        /// Searches for a "(123) 456-7890" pattern in a text.
        /// </summary>
        /// <param name="text">The text to analize.</param>
        /// <returns>The first ocurrence of the matched pattern as a string.</returns>
        public static string PhoneNumberRegex(string text) 
        {
            string pattern = @"\(\d{3}\)\s*?\d{3}-\d{4}";

            Regex regex = new(pattern);
            Match match = regex.Match(text);

            return match.ToString();
        }
    }
}
