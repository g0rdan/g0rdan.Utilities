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

        /// <summary>
        /// Метод возвращает строку с первой заглавной буквой
        /// </summary>
        /// <returns>string</returns>
        /// <param name="value">Строка, которую мы хотим изменить</param>
        /// <param name="makeAllOtherLower">Если все буквы в капсе, ставим true</param>
        public static string UppercaseFirst (this string value, bool makeAllOtherLower = false)
        {
            if (IsEmpty(value))
            {
                return string.Empty;
            }

            if (makeAllOtherLower)
            {
                value = value.ToLower();
            }

            return char.ToUpper(value[0]) + value.Substring(1);
        }

        /// <summary>
        /// Возвращает перевернутую строку. Пример: "Денис" -> "синеД"
        /// </summary>
        /// <param name="value">Строка, которую нужно перевернуть</param>
        public static string Revert(this string value)
        {
            var str = new StringBuilder(value);
            int strLength = str.Length;

            for (int i = 0; i < strLength / 2; i++)
            {
                char currentLeftLetter = str[i];
                char currentRightLetter = str[strLength - 1 - i];
                str[i] = currentRightLetter;
                str[strLength - 1 - i] = currentLeftLetter;
            }
            return str.ToString();
        }
    }
}

