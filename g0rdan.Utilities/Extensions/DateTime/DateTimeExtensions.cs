using System;

namespace g0rdan.Utilities
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Перевод времени в unix штамп
        /// </summary>
        /// <returns>The unix time.</returns>
        /// <param name="dateTime">Date time.</param>
        public static double DateTimeToUnixTime(this DateTime dateTime)
        {
            return (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }

        /// <summary>
        /// Перевод unix штампа в DateTime
        /// </summary>
        /// <returns>The time to date time.</returns>
        /// <param name="unixTimeStamp">Unix time stamp.</param>
        public static DateTime UnixTimeToDateTime(this double unixTimeStamp)
        {
            var dtDateTime = new DateTime(1970,1,1,0,0,0,0,System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds( unixTimeStamp ).ToLocalTime();
            return dtDateTime;
        }
    }
}

