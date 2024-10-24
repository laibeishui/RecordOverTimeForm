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
        public static dayType GetDayType(DateTime day, List<HolidayDto> holidays)
        {
            var daytype = dayType.工作;
            if (!holidays.Any()) return daytype;

            var dayStr = day.ToString("yyyy/MM/dd");
            
            foreach (var h in holidays)
            {
                if (h.HolidayDays.Contains(dayStr))
                {
                    return dayType.假期;
                }
                if (h.LeaveinlieuDays.Contains(dayStr))
                {
                    return dayType.调休;
                }
            }
            if (daytype==dayType.工作&&(day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday))
            {
                return dayType.周末;
            }

            return daytype;
        }

        /// <summary>
        ///  获取假期模型列表
        /// </summary>
        /// <returns></returns>
        public static List<HolidayDto> GetHolidayList()
        {
            return  FileOperations.ReadHolidaysFile();
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

    public enum dayType
    {
        工作 = 0,
        假期 = 1,
        调休 = 2,
        周末 = 3,
    }
}
