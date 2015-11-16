using System;
using System.Text;
using System.Linq;

namespace g0rdan.Utilities
{
    public static class StringExtensions
    {
        /// <summary>
        /// Replace html tags to string equivalents
        /// </summary>
        /// <returns>The html to string.</returns>
        /// <param name="value">Value.</param>
        public static string ClearHTML(this string value)
        {
            if (value.ToLower().Contains("<br>"))
            {
                value = value.Replace("<br>", "\n");
            }

            return value;
        }

        /// <summary>
        /// Check if any "options" of empty in strings
        /// </summary>
        public static bool IsEmpty(this string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }

        /// <summary>
        /// Возвращает только числа из строки
        /// </summary>
        /// <returns>The numbers.</returns>
        public static string GetConcatNumbers(this string value)
        {
            return new String(value.ToCharArray().Where(c => Char.IsDigit(c)).ToArray());
        }
    }
}

