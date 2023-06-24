using System;

namespace Strings
{
    public static class JoiningStrings
    {
        /// <summary>
        /// Concatenates an array of strings, using the comma character between each member.
        /// </summary>
        public static string GetCommaSeparatedString(string[] values)
        {
            string result = string.Join(",", values);
            return result;
        }

        /// <summary>
        /// Concatenates an array of strings, using the colon character between each member.
        /// </summary>
        public static string GetColonSeparatedString(string[] values)
        {
            string result = string.Join(":", values);
            return result;
        }

        /// <summary>
        /// Concatenates an array of strings without the first array element, using the comma between each member.
        /// </summary>
        public static string GetCommaSeparatedStringWithoutFirstElement(string[] values)
        {
            string result = string.Join(",", values[1..]);
            return result;
        }

        /// <summary>
        /// Concatenates an array of strings without the first and the last array elements, using the hyphen between each member.
        /// </summary>
        public static string GetHyphenSeparatedStringWithoutFirstAndLastElements(string[] values)
        {
            string result = string.Join("-", values[1..^1]);
            return result;
        }

        /// <summary>
        /// Concatenates an array of strings, using the plus sign between each member.
        /// </summary>
        public static string GetPlusSeparatedString(IEnumerable<string> values)
        {
            string a = "+";
            string result = string.Join(a, values);
            return result;
        }

        /// <summary>
        /// Concatenates an array of strings, using the backslash sign between each member.
        /// </summary>
        public static string GetBackslashSeparatedString(IEnumerable<object> values)
        {
            string result = string.Join("\\", values);
            return result;
        }

        /// <summary>
        /// Concatenates an array of strings, using the separator string between each member.
        /// </summary>
        public static string GetStringSeparatedString(object[] values)
        {
            string separator = "], [";

            string result = string.Join(separator, values);

            return result;
        }

        /// <summary>
        /// Concatenates an array of strings, using the separator string between each member.
        /// </summary>
        public static string GetStringSeparatedStringForLastThreeElements(string separator, string[] values)
        {
            string result = string.Join(separator, values[^3..]);
            return result;
        }
    }
}
