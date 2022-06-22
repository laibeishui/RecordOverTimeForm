using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordOverTimeForm.Utils
{
    public class DateHelper
    {

        public static readonly DateTime _now = DateTime.Now;

        public static readonly int _year = _now.Year;

        public static readonly int _month = _now.Month;

        public static readonly int _monthCount = DateTime.DaysInMonth(_year, _month);


        /// <summary>
        /// 获取本月还有几天周六和周日
        /// </summary>
        public static int CountOfWeekNumberInAMonth()
        {
            var countOfLastDay = _monthCount - _now.Day;
            int i = 0;
            int weekCount = 0;
            while (i < countOfLastDay)
            {
                int k = i;
                if (_now.AddDays(k).DayOfWeek == DayOfWeek.Saturday
                    && k + 1 < countOfLastDay)
                {
                    weekCount += 2;
                    i += 6;
                }
                else if (_now.AddDays(k).DayOfWeek == DayOfWeek.Sunday)
                {
                    weekCount++;
                    i += 6;
                }
                else 
                {
                    i++;
                }
            }

            return weekCount;
        }
    }
}
