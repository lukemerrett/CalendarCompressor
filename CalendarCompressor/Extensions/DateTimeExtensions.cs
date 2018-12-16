using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarCompressor.Extensions
{
    public static class DateTimeExtensions
    {
        /// <remarks>
        /// Source: https://stackoverflow.com/questions/38039/how-can-i-get-the-datetime-for-the-start-of-the-week
        /// </remarks>
        public static DateTime StartOfWeek(this DateTime dateTime)
        {
            int diff = (7 + (dateTime.DayOfWeek - DayOfWeek.Monday)) % 7;
            return dateTime.AddDays(-1 * diff).Date;
        }
    }
}
