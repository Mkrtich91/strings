using System;
using System.Text;

namespace Strings
{
    public static class CopyingStrings
    {
        /// <summary>
        /// Copies one character from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyOneChar(string source, string destination)
        {
            char[] destinationArray = destination.ToCharArray();
            source.CopyTo(0, destinationArray, 4, source.Length);

            return new string(destinationArray);
        }

        /// <summary>
        /// Copies three characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyThreeChars(string source, string destination)
        {
            string copiedChars = string.Concat(source.Take(3));
            return copiedChars + (destination.Length > 3 ? destination[3..] : " ");
        }

        /// <summary>
        /// Copies five characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyFiveChars(string source, string destination)
        {
            string copiedChars = new string(source.Take(5).ToArray());
            return $"{destination[..Math.Min(4, destination.Length)]}{copiedChars}{destination[9..]}";
        }

        /// <summary>
        /// Copies six characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopySixChars(string source, string destination)
        {
            string copiedChars = source.Substring(2, 6);
            string replacedDestination = destination.Replace("******", copiedChars, StringComparison.Ordinal);
            return replacedDestination;
        }

        /// <summary>
        /// Gets a production code by copying substrings of the <paramref name="regionCode"/>, <paramref name="locationCode"/>, <paramref name="dateCode"/> and <paramref name="factoryCode"/> parameters to the <paramref name="template"/>.
        /// </summary>
        public static string GetProductionCode(string template, string regionCode, string locationCode, string dateCode, string factoryCode)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < template.Length; i++)
            {
                char currentChar = template[i];

                if (i == 0 && currentChar == '*')
                {
                    result.Append(regionCode[1]);
                }
                else if (i >= 3 && i <= 4 && template.Substring(i, 2) == "**")
                {
                    result.Append(locationCode.AsSpan(4, 2));

                    i++;
                }
                else if (i >= 7 && i <= 9 && template.Substring(i, 3) == "***")
                {
                    result.Append(dateCode.AsSpan(3, 3));
                    i += 2;
                }
                else if (i >= 12 && i <= 15 && template.Substring(i, 4) == "****")
                {
                    result.Append(factoryCode.AsSpan(2, 4));
                    i += 3;
                }
                else
                {
                    result.Append(currentChar);
                }
            }

            return result.ToString();
        }
    }
}
