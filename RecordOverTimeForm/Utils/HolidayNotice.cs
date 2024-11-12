using RecordOverTimeForm.Business;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RecordOverTimeForm.Utils
{
    public static class HolidayNotice
    {
        /// <summary>
        /// 根据日期获取日期类型
        /// </summary>
        /// <param name="day"></param>
        /// <param name="holidays"></param>
        /// <returns></returns>
        public static DayType GetDayType(DateTime day, List<HolidayDto> holidays)
        {
            var daytype = DayType.工作;
            if (daytype == DayType.工作 && (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday))
            {
                daytype = DayType.周末;
            }
            if (!holidays.Any()) return daytype;

            var dayStr = day.ToString("yyyy/MM/dd");
            
            foreach (var h in holidays)
            {
                if (h.HolidayDays.Contains(dayStr))
                {
                    return DayType.假期;
                }
                if (h.LeaveinlieuDays.Contains(dayStr))
                {
                    return DayType.调休;
                }
            }
            return daytype;
        }

        /// <summary>
        ///  获取假期模型列表
        /// </summary>
        /// <returns></returns>
        public static List<HolidayDto> GetHolidayList(int year)
        {
            return  FileOperations.ReadHolidaysFile(year);
        }
    }


    public class HolidayDto
    {
        /// <summary>
        /// 假期名称
        /// </summary>
        public string HolidayName { get; set; }

        /// <summary>
        /// 假期天
        /// </summary>
        public List<string> HolidayDays { get; set; }

        /// <summary>
        /// 调休天
        /// </summary>
        public List<string> LeaveinlieuDays { get; set; }

        /// <summary>
        /// 假期持续天数
        /// </summary>
        public int Duration { get; set; }
    }

    public enum DayType
    {
        工作 = 0,
        假期 = 1,
        调休 = 2,
        周末 = 3,
    }
}
