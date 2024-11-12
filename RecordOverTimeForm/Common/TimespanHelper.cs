using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordOverTimeForm.Common
{
    public static class TimespanHelper
    {
        public static double GetDif(TimeSpan starttime, TimeSpan endtime)
        {
            var difHour = (endtime - starttime).TotalHours;
            return Math.Round(difHour, 1);
        }
    }
}
