using System;
using System.Text;

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
    }
}

