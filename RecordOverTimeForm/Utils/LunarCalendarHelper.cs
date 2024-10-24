namespace RecordOverTimeForm.Utils
{
    /// <summary>
    /// 阳历假期
    /// </summary>
    public struct SolarHolidayStruct
    {
        public int Month;
        public int Day;
        public int Recess; //假期长度
        public string HolidayName;
        public SolarHolidayStruct(int month, int day, int recess, string name)
        {
            Month = month;
            Day = day;
            Recess = recess;
            HolidayName = name;
        }
    }

    /// <summary>
    /// 农历假期
    /// </summary>
    public struct LunarHolidayStruct
    {
        public int Month;
        public int Day;
        public int Recess;
        public string HolidayName;

        public LunarHolidayStruct(int month, int day, int recess, string name)
        {
            Month = month;
            Day = day;
            Recess = recess;
            HolidayName = name;
        }
    }

    /// <summary>
    /// 周末假期
    /// </summary>
    public struct WeekHolidayStruct
    {
        public int Month;
        public int WeekAtMonth;
        public int WeekDay;
        public string HolidayName;

        public WeekHolidayStruct(int month, int weekAtMonth, int weekDay, string name)
        {
            Month = month;
            WeekAtMonth = weekAtMonth;
            WeekDay = weekDay;
            HolidayName = name;
        }
    }
}
