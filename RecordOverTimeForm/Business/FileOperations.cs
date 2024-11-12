using Newtonsoft.Json;
using RecordOverTimeForm.Model;
using RecordOverTimeForm.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordOverTimeForm.Business
{
    public static class FileOperations
    {
        private static readonly string _baseFilePath = Environment.CurrentDirectory + "/overtimeRecord";

        /// <summary>
        /// 读取Ini  文件
        /// </summary>
        /// <param name="paths"></param>
        /// <returns></returns>
        public static Dictionary<int, double> ReadIniFile(DateTime date)
        {
            string filePath = GetFilePath(date);
            if (string.IsNullOrEmpty(filePath)) return null;

            int month = date.Month;

            var dayCount = date.CountOfMonth();

            int i = 1;
            Dictionary<int, double> overtimeKV = new Dictionary<int, double>();
            while (i <= dayCount)
            {
                var overtimevStr = IniHelper.Read(month.ToString(), i.ToString(), null, filePath);
                var overtimevValue = string.IsNullOrEmpty(overtimevStr) ? 0 : CalcSum(GetOverTimeInfo(overtimevStr));
                if (overtimevValue != 0)
                {
                    overtimeKV.Add(i, overtimevValue);
                }
                i++;
            }

            return overtimeKV;
        }

        public static List<OvertimeModel> ReadDayOverTime(DateTime date)
        {
            string filePath = GetFilePath(date);
            if (string.IsNullOrEmpty(filePath)) return null;
            var overtimevStr = IniHelper.Read(date.Month.ToString(), date.Day.ToString(), null, filePath);
            if (string.IsNullOrEmpty(overtimevStr))
                return null;
            return GetOverTimeInfo(overtimevStr);

        }

        private static double CalcSum(List<OvertimeModel> overtimeList)
        {
            return overtimeList.Sum(x => x.PeriodDiff);
        }


        private static List<OvertimeModel> GetOverTimeInfo(string overtimeStr)
        {
            var overtimeList = new List<OvertimeModel>();
            string[] periods = overtimeStr.Split(',');
            foreach (var period in periods)
            {
                // 按照 | 分隔开始时间和结束时间
                string[] times = period.Split('|');

                if (times.Length == 2 && int.TryParse(times[0], out int startMinutes) && int.TryParse(times[1], out int endMinutes))
                {
                    // 将分钟数转换为 TimeSpan
                    TimeSpan startTime = TimeSpan.FromSeconds (startMinutes);
                    TimeSpan endTime = TimeSpan.FromSeconds(endMinutes);

                    // 计算小时差
                    double periodDiff = (endTime - startTime).TotalHours;

                    // 添加到模型列表
                    overtimeList.Add(new OvertimeModel
                    {
                        StartTime = startTime,
                        EndTime = endTime,
                        PeriodDiff = Math.Round(periodDiff, 1)
                    });
                }
            }

            return overtimeList;
        }

        /// <summary>
        /// 通过日期检查文件路径
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        private static string CheckFilePath(DateTime date)
        {
            FileHelper.CreateDirectory(_baseFilePath);

            string year = date.Year.ToString();
            string yearPath = Path.Combine(_baseFilePath, year);
            FileHelper.CreateDirectory(yearPath);

            string filePath = Path.Combine(_baseFilePath, date.Year.ToString(), "overtimeRecord" + date.Month.ToString() + ".ini");
            FileHelper.CrateFile(filePath);

            return filePath;
        }


        /// <summary>
        /// 通过日期获取文件路径
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        private static string GetFilePath(DateTime date)
        {
            var filePath = Path.Combine(_baseFilePath, date.Year.ToString(), "overtimeRecord" + date.Month.ToString() + ".ini");

            if (!File.Exists(filePath))
            {
                return null;
            }

            return filePath;
        }


        /// <summary>
        /// 写入ini 文件
        /// </summary>
        /// <param name="date"></param>
        /// <param name="overtime"></param>
        /// <returns></returns>
        public static bool WriteIniFile(DateTime date, double startTimespan, double endTimespan)
        {
            string filePath = CheckFilePath(date);
            var fileContent = IniHelper.Read(date.Month.ToString(), date.Day.ToString(), null, filePath);
            var saveStr = startTimespan.ToString() + "|" + endTimespan.ToString();
            if (!string.IsNullOrEmpty(fileContent))
            {
                saveStr = fileContent + "," + saveStr;
            }
            bool hasWrite = IniHelper.Write(date.Month.ToString(), date.Day.ToString(), saveStr, filePath) != 0;

            return hasWrite;
        }

        public static bool UpdateIniFileContent(DateTime date, double startTimespan, double endTimespan,int index)
        {
            string filePath = GetFilePath(date);
            if (string.IsNullOrEmpty(filePath)) return false;
            var overtimeStr = IniHelper.Read(date.Month.ToString(), date.Day.ToString(), null, filePath);
            if (string.IsNullOrEmpty(overtimeStr))
                return false;
            var saveStr = "";
            var overTimeList = GetOverTimeInfo(overtimeStr);
            for (int i = 1; i <= overTimeList.Count; i++)
            {
                var head = i==1?"":",";
                if (i == index)
                {
                    saveStr += $"{head}{startTimespan}|{endTimespan}";
                }
                else 
                {
                    saveStr += $"{head}{overTimeList[i - 1].StartTime.TotalSeconds}|{overTimeList[i - 1].EndTime.TotalSeconds}";
                }
            }
            bool hasWrite = IniHelper.Write(date.Month.ToString(), date.Day.ToString(), saveStr, filePath) != 0;
            return hasWrite;
        }

        public static bool DeleteIniFileContent(DateTime date,int index)
        {
            string filePath = GetFilePath(date);
            if (string.IsNullOrEmpty(filePath)) return false;
            var overtimeStr = IniHelper.Read(date.Month.ToString(), date.Day.ToString(), null, filePath);
            if (string.IsNullOrEmpty(overtimeStr))
                return false;
            var saveStr = "";
            var overTimeList = GetOverTimeInfo(overtimeStr);
            for (int i = 1; i <=  overTimeList.Count; i++)
            {
                var head = i == 1 ? "" : ",";
                if (i != index)
                {
                    saveStr += $"{head}{overTimeList[i - 1].StartTime.TotalSeconds}|{overTimeList[i - 1].EndTime.TotalSeconds}";
                }
            }
            bool hasWrite = IniHelper.Write(date.Month.ToString(), date.Day.ToString(), saveStr, filePath) != 0;
            return hasWrite;
        }

        /// <summary>
        /// 从文本中获取节假日信息
        /// </summary>
        /// <returns></returns>
        public static List<HolidayDto> ReadHolidaysFile(int year)
        {
            var fileName = "holidayNoticeDataOf" + year.ToString() + ".txt";
            string filePath = _baseFilePath + "\\" + fileName;
            var holidays = new List<HolidayDto>();
            try
            {
                if (!File.Exists(filePath))
                {
                    FileHelper.CreateDirectory(_baseFilePath);
                    new HttpClientHelper().DownLoad($"{ConfigurationManager.AppSettings["HolidaysDownloadUrl"]}/{fileName}", filePath);
                }
                var readJson = File.ReadAllText(filePath, Encoding.UTF8);
                if (!string.IsNullOrWhiteSpace(readJson))
                    holidays = JsonConvert.DeserializeObject<List<HolidayDto>>(readJson);
            }
            catch (Exception ex)
            {
                Console.WriteLine("报错");
            }
            return holidays;

        }

        public static decimal ReadInputOvertimeHours()
        {
            var fileName = "inputOvertimeHours.txt";
            string filePath = _baseFilePath + "\\" + fileName;
            if (string.IsNullOrEmpty(filePath)) return 0;
            var year = DateTime.Now.Year;
            var month = DateTime.Now.Month;
            var overtime = IniHelper.Read(year.ToString(), month.ToString(), null, filePath);
            if (string.IsNullOrEmpty(overtime))
            {
                return 0;
            }
            else
            {
                return Convert.ToDecimal(overtime);
            }
        }

        public static bool WriteInputOverTimeHours(decimal overtime)
        {
            var year = DateTime.Now.Year;
            var month = DateTime.Now.Month;
            var fileName = "inputOvertimeHours.txt";
            string filePath = _baseFilePath + "\\" + fileName;
            FileHelper.CreateDirectory(_baseFilePath);
            FileHelper.CrateFile(filePath);
            return IniHelper.Write(year.ToString(), month.ToString(), overtime.ToString(), filePath) != 0;
        }
    }
}
