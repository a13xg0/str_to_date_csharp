using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace str_to_date_mssql
{
    public class StringConverter
    {
        public static DateTime UseConvert(string date)
        {
            return Convert.ToDateTime(date);
        }

        public static DateTime UseParse(string date)
        {
            return DateTime.Parse(date);
        }

        public static DateTime UseParseWithDots(string date)
        {

            DateTimeFormatInfo dtfi = new DateTimeFormatInfo
            {
                ShortDatePattern = "dd.MM.yyyy",
                DateSeparator = ".",
            };

            return DateTime.ParseExact(date, "d", dtfi);
        }

    }
}
