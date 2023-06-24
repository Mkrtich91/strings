using System;
using System.Text.RegularExpressions;

namespace Strings
{
    public static class SplittingStrings
    {
        /// <summary>
        /// Splits a comma-separated string into substrings that are based on the comma character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitCommaSeparatedString(string str)
        {
            return str.Split(',');
        }

        /// <summary>
        /// Splits a colon-separated string into substrings that are based on the colon character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitColonSeparatedString(string str)
        {
            string[] substrings = str.Split(':');
            return substrings;
        }

        /// <summary>
        /// Splits a comma-separated string into substrings that are based on the comma character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitCommaSeparatedStringMaxTwoElements(string str)
        {
            string[] substrings = str.Split(new[] { ',' }, 2);
            return substrings;
        }

        /// <summary>
        /// Splits a colon-separated string into substrings that are based on the colon character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitColonSeparatedStringMaxThreeElements(string str)
        {
            string[] substrings = str.Split(new[] { ':' }, 3);
            return substrings;
        }

        /// <summary>
        /// Splits a hyphen-separated string into substrings that are based on the hyphen character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitHyphenSeparatedStringMaxThreeElementsRemoveEmptyStrings(string str)
        {
            string[] substrings = str.Split(new[] { '-' }, 3, StringSplitOptions.RemoveEmptyEntries);
            return substrings;
        }

        /// <summary>
        /// Splits a separated string that is separated with colon and comma characters into substrings, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitColonAndCommaSeparatedStringMaxFourElementsRemoveEmptyStrings(string str)
        {
            char[] separators = { ':', ',' };

            string[] substrings = str.Split(separators, 4, StringSplitOptions.RemoveEmptyEntries);

            return substrings;
        }

        /// <summary>
        /// Splits a sentence into substrings, and return an array whose elements contain only words.
        /// </summary>
        public static string[] GetOnlyWords(string str)
        {
            string pattern = @"\b\w+\b";

            MatchCollection matches = Regex.Matches(str, pattern);

            string[] words = new string[matches.Count];

            for (int i = 0; i < matches.Count; i++)
            {
                words[i] = matches[i].Value;
            }

            return words;
        }

        /// <summary>
        /// Splits a CSV (comma-separated values) string into substrings that are based on the comma character, and return an array of the CSV line elements.
        /// </summary>
        public static string[] GetDataFromCsvLine(string str)
        {
            string[] csvElements = str.Split(',');
            for (int i = 0; i < csvElements.Length; i++)
            {
                csvElements[i] = csvElements[i].Trim();
            }

            return csvElements;
        }
    }
}
