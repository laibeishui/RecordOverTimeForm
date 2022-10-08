using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordOverTimeForm.Utils
{
    public static class DateHelper
    {
        /// <summary>
        /// 获取本月还有几天周六和周日
        /// </summary>
        public static int CountOfLastWeekNumberInMonth(int lastMonthCount, DateTime today)
        {
            int i = 1;
            int lastWeekCount = 0;
            while (i < lastMonthCount)
            {
                int k = i;
                if (today.AddDays(k).DayOfWeek == DayOfWeek.Saturday
                    && k + 1 < lastMonthCount)
                {
                    lastWeekCount += 2;
                    i += 6;
                }
                else if (today.AddDays(k).DayOfWeek == DayOfWeek.Sunday)
                {
                    lastWeekCount++;
                    i += 6;
                }
                else
                {
                    i++;
                }
            }

            return lastWeekCount;
        }

        /// <summary>
        /// 通过本月的某一天获取当月的第一天
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime GetFirstDayByADayInMonth(this DateTime date) => date.AddDays(1 - date.Day);


        /// <summary>
        /// 获取本月总共有多少天周六周日
        /// </summary>
        /// <returns></returns>
        public static int CountOfWeekNumberInMonth(int monthCount, DateTime firstdayinMonth, List<HolidayDto> holidays)
        {
            int i = 0;
            int weekCount = 0;
            int flagMonth = firstdayinMonth.Month;
            while (i < monthCount)
            {
                int k = i;
                if (firstdayinMonth.AddDays(k).DayOfWeek == DayOfWeek.Saturday
                    && k + 1 < monthCount)
                {
                    weekCount += 2;
                    i += 6;
                }
                else if (firstdayinMonth.AddDays(k).DayOfWeek == DayOfWeek.Sunday)
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


        /// <summary>
        /// 获取一个月总共有多少天
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static int CountOfMonth(this DateTime date)
        {
            var year = date.Year;
            var month = date.Month;
            return DateTime.DaysInMonth(year, month);
        }


        /// <summary>
        /// 获取所有的假期时间
        /// </summary>
        /// <param name="holidays"></param>
        /// <returns></returns>
        public static List<string> GetAllHolidays(List<HolidayDto> holidays)
        {
            var allHolidays = new List<string>();
            holidays.ForEach(h =>
            {
                allHolidays.AddRange(h.HolidayDays);
            });

            return allHolidays;
        }

        /// <summary>
        /// 获取所有的调休时间
        /// </summary>
        /// <param name="holidays"></param>
        /// <returns></returns>
        public static List<string> GetAllLeaveinlieuDays(List<HolidayDto> holidays)
        {
            var allLeaveinlieuday = new List<string>();
            holidays.ForEach(h =>
            {
                allLeaveinlieuday.AddRange(h.LeaveinlieuDays);
            });

            return allLeaveinlieuday;
        }
    }
}
