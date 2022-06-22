using RecordOverTimeForm.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordOverTimeForm.Business
{
    public class FileOperations
    {

        //string filePath = Path.Combine(_diaryFilePath, date.Year.ToString(), date.Month.ToString(), "dairy" + date.Day.ToString() + ".ini");

        private static string _baseFilePath = @"C:/Users/overtimeRecord";

        //public List<Diary> GetDiaryList()
        //{
        //    List<Diary> diaries = new List<Diary>();
        //    string[] yearDirs = Directory.GetDirectories(_diaryFilePath);
        //    foreach (var ydir in yearDirs)
        //    {
        //        string[] monthDirs = Directory.GetDirectories(ydir);
        //        foreach (var mdir in monthDirs)
        //        {
        //            string[] iniFiles = Directory.GetFiles(mdir, "*");
        //            diaries.AddRange(ReadIniFiles(iniFiles));
        //        }
        //    }

        //    return diaries.OrderBy(x => x.Date).ToList();
        //}


        /// <summary>
        /// 读取Ini  文件
        /// </summary>
        /// <param name="paths"></param>
        /// <returns></returns>
        public static Dictionary<int, double> ReadIniFile(DateTime date, int count)
        {
            //var diaries = new List<Diary>();
            //foreach (var path in paths)
            //{
            //    var diary = new Diary();
            //    diary.DiaryId = Guid.Parse(IniHelper.Read("diary", "DiaryId", null, path));
            //    diary.Date = DateTime.Parse(IniHelper.Read("diary", "Date", null, path));
            //    diary.Weather = IniHelper.Read("diary", "Weather", null, path);
            //    diary.Content = Encoding.UTF8.DecodeBase64(IniHelper.Read("diary", "Content", null, path));
            //    diaries.Add(diary);
            //}

            if (GetFilePath(date) == null) return null; 
            


            

            int i = 0;

            Dictionary<int, double> overtimeKV = new Dictionary<int, double>();
            while (i < count)
            {
                var overtimevValue = Convert.ToDouble(IniHelper.Read("", i.ToString(), null, path));
                if (overtimevValue != 0)
                {
                    overtimeKV.Add(i, overtimevValue);
                }

                i++;
            }

            return overtimeKV;
        }

        private static  string CheckFilePath(DateTime date)
        {
            FileHelper.CreateDirectory(_baseFilePath);

            string year = date.Year.ToString();
            string yearPath = Path.Combine(_baseFilePath, year);
            FileHelper.CreateDirectory(yearPath);

            string filePath = Path.Combine(_baseFilePath, date.Year.ToString(), "overtimeRecord" + date.Month.ToString()  + ".ini");
            FileHelper.CrateFile(filePath);

            return filePath;
        }

        private static string GetFilePath(DateTime date)
        {
            var filePath=Path.Combine(_baseFilePath, date.Year.ToString(), "overtimeRecord" + date.Month.ToString() + ".ini");

            if (!File.Exists(filePath))
            {
                return null;
            }

            return filePath;
        }

        public static  bool WriteIniFile(DateTime date, double overtime)
        {
            string filePath = CheckFilePath(date);
            bool Haswrite = IniHelper.Write(date.Month.ToString(), date.Day.ToString(), overtime.ToString(), filePath) != 0;

            return Haswrite;
        }
    }
}
