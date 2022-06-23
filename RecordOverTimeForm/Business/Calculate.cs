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
        public static readonly int _monthCount = DateTime.DaysInMonth(_year, _month);

        // 本月总共有多少休息天
        public static readonly int _monthFreeDayCount = DateHelper.CountOfWeekNumberInMonth(_monthCount, _now.GetFirstDayByADayInMonth());

        // 本月总共有多少工作日
        public static readonly int _monthWorkDayCount = _monthCount - _monthFreeDayCount;

        // 本月还剩下多少天 (不包括今天)
        public static readonly int _lastMonthCount = _monthCount - _now.Day;

        // 本月还剩下多少休息天（不包括今天）        
        public static readonly int _lastMonthFreeDayCount = DateHelper.CountOfLastWeekNumberInMonth(_lastMonthCount, _now);

        // 本月还剩下多少工作日  （不包括今天）
        public static readonly int _lastMonthWorkDayCount = _lastMonthCount - _lastMonthFreeDayCount;


        /// <summary>
        /// 计算本月总共需要加多少班
        /// </summary>
        /// <returns></returns>
        public static double CallculateAllTime() => _monthWorkDayCount * 0.5;

        /// <summary>
        /// 计算本月总共可以加多少时间的班
        /// </summary>
        /// <returns></returns>
        public static double CalculateOverTime() => _monthFreeDayCount * 7.5 + _monthWorkDayCount * 3.5;


        /// <summary>
        /// 计算本月已经加了多少天的班
        /// </summary>
        /// <returns></returns>
        public static double CalculateHadOverTime()
        {
            var overTimeDic = FileOperations.ReadIniFile(DateTime.Now);
            return overTimeDic.Values.ToList().Sum();
        }


        /// <summary>
        /// 计算剩余加班时间
        /// </summary>
        /// <returns></returns>
        public static double CalculateLastOverTime() => _lastMonthFreeDayCount * 7.5 + _lastMonthWorkDayCount * 3.5;


        /// <summary>
        /// 计算剩余加班时间不包括周六周日
        /// </summary>
        /// <returns></returns>
        public static double CalculateLastOverTimeWithoutWeek() => _lastMonthWorkDayCount * 3.5;

    }
}
