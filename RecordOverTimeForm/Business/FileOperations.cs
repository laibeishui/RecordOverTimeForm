using Newtonsoft.Json;
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
        private static readonly string _baseFilePath = @"C:/Users/overtimeRecord/";

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
                var overtimevValueStr = IniHelper.Read(month.ToString(), i.ToString(), null, filePath);
                var overtimevValue = string.IsNullOrEmpty(overtimevValueStr) ? 0 : Convert.ToDouble(overtimevValueStr);
                if (overtimevValue != 0)
                {
                    overtimeKV.Add(i, overtimevValue);
                }

                i++;
            }

            return overtimeKV;
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
        public static bool WriteIniFile(DateTime date, double overtime)
        {
            string filePath = CheckFilePath(date);
            return IniHelper.Write(date.Month.ToString(), date.Day.ToString(), overtime.ToString(), filePath) != 0;
        }

        /// <summary>
        /// 从文本中获取节假日信息
        /// </summary>
        /// <returns></returns>
        public static List<HolidayDto> ReadHolidaysFile()
        {
            var year = DateTime.Now.Year;
            var fileName = "holidayNoticeDataOf" + year.ToString() + ".txt";
            string filePath = _baseFilePath + "\\" + fileName;
            var holidays = new List<HolidayDto>();
            if (!File.Exists(filePath))
            {
                FileHelper.CreateDirectory(_baseFilePath);
                new HttpClientHelper().DownLoad($"{ConfigurationManager.AppSettings["HolidaysDownloadUrl"]}/{fileName}", filePath);
            }
            var readJson = File.ReadAllText(filePath, Encoding.UTF8);
            if (!string.IsNullOrWhiteSpace(readJson))
                holidays = JsonConvert.DeserializeObject<List<HolidayDto>>(readJson);
            return holidays;
        }
    }
}
