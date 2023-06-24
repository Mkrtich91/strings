using System;
using System.Globalization;

namespace Strings
{
    public static class Manipulations
    {
        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetHelloGreeting1(string name)
        {
            return $"Hello, {name}!";
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetGreeting1(string greeting, string name)
        {
            string upperCaseName = name.ToUpperInvariant();
            return $"{greeting}, {upperCaseName}!";
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetHelloGreeting2(string name)
        {
            string trimmedName = name.Trim();
            return $"Hello, {trimmedName}!";
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetGreeting2(string greeting, string name)
        {
            string trimmedGreeting = greeting.Trim();
            string trimmedName = name.Trim();
            string lowercaseName = trimmedName.ToLowerInvariant();
            string formattedGreeting = $"{trimmedGreeting}, {lowercaseName}!";

            return formattedGreeting;
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetHelloGreeting3(string template, string name)
        {
            return template.Replace("{name}", name, StringComparison.InvariantCulture);
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetGreeting3(string template, string greeting, string name)
        {
            CultureInfo culture = CultureInfo.InvariantCulture;

            string formattedTemplate = template.Replace("{greeting}", greeting.ToLower(culture), StringComparison.OrdinalIgnoreCase)
                                             .Replace("{name}", name.ToUpper(culture), StringComparison.OrdinalIgnoreCase);
            return formattedTemplate;
        }

        /// <summary>
        /// Returns refined code - without zero characters.
        /// </summary>
        public static string GetRefinedCode(string code)
        {
            string refinedCode = code;

            int zeroIndex = refinedCode.IndexOf("0", StringComparison.Ordinal);
            while (zeroIndex != -1)
            {
                refinedCode = refinedCode.Remove(zeroIndex, 1);
                zeroIndex = refinedCode.IndexOf("0", StringComparison.Ordinal);
            }

            return refinedCode;
        }

            /// <summary>
            /// Returns refined date - without dash characters.
            /// </summary>
        public static string GetRefinedDate(string date)
        {
            string refinedDate = date.Remove(date.IndexOf("-", StringComparison.Ordinal), 1);

            while (refinedDate.Contains('-', StringComparison.Ordinal))
            {
                refinedDate = refinedDate.Remove(refinedDate.IndexOf("-", StringComparison.Ordinal), 1);
            }

            return refinedDate;
        }
    }
}
