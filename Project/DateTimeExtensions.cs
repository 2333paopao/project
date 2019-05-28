using System;

namespace Project
{
    public static class DateTimeExtensions
    {
        public static DateTime ToLocalTime(this DateTime sourceDateTime)
        {
            return sourceDateTime.ToLocalTime();
        }

        public static DateTime ToLocalStartTime(this DateTime sourceDateTime)
        {
            var localTime = sourceDateTime.ToLocalTime();
            return new DateTime(localTime.Year, localTime.Month, localTime.Day, 0, 0, 0);
        }

        public static DateTime ToLocalEndTime(this DateTime sourceDateTime)
        {
            var localTime = sourceDateTime.ToLocalTime();
            return new DateTime(localTime.Year, localTime.Month, localTime.Day, 23, 59, 59);
        }

        public static string ToDateString(this DateTime sourceDateTime)
        {
            return sourceDateTime.ToString("yyyy-MM-dd");
        }

        public static string ToDateTimeString(this DateTime sourceDateTime)
        {
            return sourceDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static string ToDateMinuteString(this DateTime sourceDateTime)
        {
            return sourceDateTime.ToString("yyyy-MM-dd HH:mm");
        }
    }
}
