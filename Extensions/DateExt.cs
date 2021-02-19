using System;
using System.Collections.Generic;
using System.Text;

namespace Walle.Components.Extensions
{
    public static class DateExt
    {
        public static bool InRange(this DateTime dt, DateTime dtBegin, DateTime dtEnd)
        {
            if (dtBegin <= dt && dt <= dtEnd)
            {
                return true;
            }
            return false;
        }

        public static DateTime FromTimestamp(this long unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddMilliseconds(unixTime);
        }

        public static long ToTimestamp(this DateTime date)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return Convert.ToInt64((date.ToUniversalTime() - epoch).TotalMilliseconds);
        }

    }
}
