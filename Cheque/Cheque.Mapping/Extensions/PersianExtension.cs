using System;
using System.Globalization;
using System.Threading;

namespace Cheque.Mapping.Extensions
{
    /// <summary>
    /// </summary>
    public static class PersianExtension
    {
        /// <summary>
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static string ToPersianDateTime(this DateTime dateTime)
        {
            var year = dateTime.Year;
            var month = dateTime.Month;
            var day = dateTime.Day;
            var persianCalendar = new PersianCalendar();
            var pYear = persianCalendar.GetYear(new DateTime(year, month, day, new GregorianCalendar()));
            var pMonth = persianCalendar.GetMonth(new DateTime(year, month, day, new GregorianCalendar()));
            var pDay = persianCalendar.GetDayOfMonth(new DateTime(year, month, day, new GregorianCalendar()));
            return string.Format("{0}{1}{2}{1}{3}", pYear, "/", pMonth.ToString("00", CultureInfo.InvariantCulture),
                pDay.ToString("00", CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string ToPersianString(this DateTime dateTime,
            PersianDateTimeFormat format = PersianDateTimeFormat.ShortDateShortTime)
        {
            return new PersianDateTime(dateTime).ToString(format);
        }

        /// <summary>
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string ToPersianString(this DateTime? dateTime, PersianDateTimeFormat format)
        {
            return dateTime != null ? new PersianDateTime(dateTime.Value).ToString(format) : string.Empty;
        }

        public static DateTime ToGeorgeDateTime(this string userInput)
        {CultureInfo en = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = en;

            int year = int.Parse(userInput.Substring(0, 4));
            int month = int.Parse(userInput.Substring(5, 2));
            int day = int.Parse(userInput.Substring(8, 2));
            PersianCalendar p = new PersianCalendar();
            DateTime date = p.ToDateTime(year, month, day, 0, 0, 0, 0);
            
            return date;

            //System.String[] userDateParts = userInput.Split(new[] { "/" }, System.StringSplitOptions.None);
            //int userYear = int.Parse(userDateParts[0]);
            //int userMonth = int.Parse(userDateParts[1]);
            //int userDay = int.Parse(userDateParts[2]);

            //PersianCalendar pCalendar = new PersianCalendar();
            //DateTime gDate = pCalendar.ToDateTime(userYear, userMonth, userDay, 0, 0, 0, 0);
            //return gDate;

            //  DateTime epoch = new DateTime(userYear, userMonth, userDay, new PersianCalendar());
            //   return epoch;
            //  PersianCalendar pc = new PersianCalendar();
            //   pc.
            //  return    pc.ToDateTime(userYear, userMonth, userDay, 0, 0, 0, 0);

            // DateTime dt = new DateTime(userYear, userMonth, userDay, new PersianCalendar());
            //   return pc;

        }
    }
}