using RecordOverTimeForm.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordOverTimeForm.Business
{
    public class Calculate
    {
        public static readonly DateTime _now = DateTime.Now;

        public static readonly int _year = _now.Year;

        public static readonly int _month = _now.Month;

        // 本月总共有多少天
        public readonly int _monthCount = DateTime.DaysInMonth(_year, _month);

        public static List<HolidayDto> _holidays = new List<HolidayDto>();

        public Calculate(List<HolidayDto> holidays)
        {
            _holidays = holidays;
        }


        /// <summary>
        /// 计算本月已经加了多少天的班
        /// </summary>
        /// <returns></returns>
        public  double CalculateHadOverTime()
        {
            var overTimeDic = FileOperations.ReadIniFile(DateTime.Now);
            if (overTimeDic == null) return 0;
            return overTimeDic.Values.ToList().Sum();
        }

        /// <summary>
        /// 获取所有的假期时间
        /// </summary>
        /// <param name="holidays"></param>
        /// <returns></returns>
        private  List<string> GetAllHolidays()
        {
            var allHolidays = new List<string>();
            _holidays.ForEach(h =>
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
        public  List<string> GetAllLeaveinlieuDays()
        {
            var allLeaveinlieuday = new List<string>();
            _holidays.ForEach(h =>
            {
                allLeaveinlieuday.AddRange(h.LeaveinlieuDays);
            });

            return allLeaveinlieuday;
        }

        /// <summary>
        /// 获取一个月的所有休息天数
        /// </summary>
        /// <returns></returns>
        public int GetFreeDayCount()
        {
            var firstDayinMonth = _now.GetFirstDayByADayInMonth();
            var weekDayCount = DateHelper.CountOfWeekNumberInMonth(_monthCount, firstDayinMonth, _holidays);
            int flagMonth = firstDayinMonth.Month;
            int holidayCount = 0;
            var holidaysList = GetAllHolidays();
            holidaysList.ForEach(x =>
            {
                var temp = Convert.ToDateTime(x);
                if (temp.Month == flagMonth && temp.DayOfWeek != DayOfWeek.Saturday && temp.DayOfWeek != DayOfWeek.Sunday)
                    holidayCount++;
            });

            int leaveinlieuDayCount = 0;
            var leaveinlieuDaysList = GetAllLeaveinlieuDays();
            leaveinlieuDaysList.ForEach(x =>
            {
                var temp = Convert.ToDateTime(x);
                if (temp.Month == flagMonth && temp.DayOfWeek == DayOfWeek.Saturday && temp.DayOfWeek == DayOfWeek.Sunday)
                    leaveinlieuDayCount++;
            });

            return weekDayCount + holidayCount - leaveinlieuDayCount;
        }
    }
}
