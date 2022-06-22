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

        public static readonly int _monthCount = DateTime.DaysInMonth(_year, _month);

        /// <summary>
        /// 计算加班时间
        /// </summary>
        /// <returns></returns>
        public static string CalculateOverTime()
        {
            
            return "";
        }

        /// <summary>
        /// 计算剩余加班时间
        /// </summary>
        /// <returns></returns>
        public static string CalculateLastOverTime()
        {
            
            return "";
        }

        public static string CalculateLastOverTimeWithoutWeek()
        {
            return "";
        }
    }
}
