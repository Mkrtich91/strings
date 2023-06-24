using System;

namespace Strings
{
    public static class Interpolation
    {
        /// <summary>
        /// Returns a greeting that starts with "Hello".
        /// </summary>
        public static string GetHelloGreeting(string name)
        {
            return $"Hello, {name}!";
        }

        /// <summary>
        /// Returns a greeting that starts with a greeting argument.
        /// </summary>
        public static string GetGreeting(string greeting, string name)
        {
            return $"{greeting}, {name}!";
        }

        /// <summary>
        /// Returns a phrase that contains a square number.
        /// </summary>
        public static string GetSquareNumber(int i)
        {
            return $"The square number of {i} is {i * i}.";
        }

        /// <summary>
        /// Returns a phrase that contains a total price.
        /// </summary>
        public static string GetTotalPrice(double price, int items, double discount)
        {
            double totalPrice = price * items * discount;
            string totalPriceString = $"The price of all items is {totalPrice}.";

            return totalPriceString;
        }

        /// <summary>
        /// Returns a phrase that contains a sequence of numbers.
        /// </summary>
        public static string GetSequenceOfNumbers(int[] numbers)
        {
            string sequence = "{" + string.Join(",", numbers) + "}";
            string phrase = $"The sequence is {sequence}.";

            return phrase;
        }

        /// <summary>
        /// Returns a phrase that contains the length of a sequence.
        /// </summary>
        public static string GetSequenceOfNumbersLength(string sequence)
        {
            string[] substrings = sequence.Split(',', StringSplitOptions.RemoveEmptyEntries);
            int length = substrings.Length;

            string phrase = $"The sequence length is {length}.";

            return phrase;
        }

        /// <summary>
        /// Returns a file path to a document.
        /// </summary>
        public static string GetDocumentPath(string username, string filename, string extension)
        {
            string documentsFolder = "Documents";
            string folderPath = Path.Combine(@"c:\users", username.Trim(), documentsFolder);
            if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(filename) && string.IsNullOrWhiteSpace(extension))
            {
                return @"c:\users\\Documents\.";
            }

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(filename))
            {
                return Path.Combine(folderPath, ".");
            }

            if (string.IsNullOrEmpty(extension))
            {
                return Path.Combine(folderPath, filename.Trim() + ".");
            }

            return Path.Combine(folderPath, filename.Trim() + "." + extension.Trim());
        }

        /// <summary>
        /// Returns a network path to document.
        /// </summary>
        public static string GetNetworkPath(string workstation, string userFolder, string filename, string extension)
        {
            if (string.IsNullOrEmpty(workstation) || string.IsNullOrEmpty(userFolder) || string.IsNullOrEmpty(filename) || string.IsNullOrEmpty(extension))
            {
                return @"\\\users\\.";
            }

            string networkPath = $@"\\{workstation}\users\{userFolder}\{filename}.{extension}";

            return networkPath;
        }
    }
}
