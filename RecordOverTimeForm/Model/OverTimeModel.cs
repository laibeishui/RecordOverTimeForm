using System;

namespace RecordOverTimeForm.Model
{
    public class OvertimeModel
    {
        public TimeSpan StartTime { get; set;}

        public TimeSpan EndTime { get; set;}

        public double PeriodDiff { get; set; }
    }
}
