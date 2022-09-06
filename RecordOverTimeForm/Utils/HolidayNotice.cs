using HtmlAgilityPack;
using RecordOverTimeForm.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RecordOverTimeForm.Utils
{
    public static class HolidayNotice
    {
        private static readonly int _year = DateTime.Now.Year;

        /// <summary>
        /// 获取假期都在哪几个月
        /// </summary>
        /// <param name="holidays"></param>
        /// <returns></returns>
        public static List<int> GetHoliayMonthList(List<HolidayDto> holidays)
        {
            var holidayMonths = new List<int>();
            holidays.ForEach(h =>
            {
                h.HolidayDays?.ForEach(h2 =>
                {
                    if (!holidayMonths.Contains(Convert.ToDateTime(h2).Month))
                    {
                        holidayMonths.Add(Convert.ToDateTime(h2).Month);
                    }
                });
            });

            return holidayMonths;
        }



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
            var holidayList = new List<HolidayDto>();

            holidayList = FileOperations.ReadHolidaysFile();

            if (holidayList.Any()) return holidayList;

            var holidayNoticeUrl = GetHolidayNoticeUrl();
            var holidayNoticeHtml = new HttpClientHelper().Get(holidayNoticeUrl);

            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(holidayNoticeHtml);


            for (int i = 7; i <= 13; i++)
            {
                var xpath = $"//td[@id='UCAP-CONTENT']/p[{i}]";
                HtmlNodeCollection nodex = doc.DocumentNode.SelectNodes(xpath);
                holidayList.Add(HandleHolidayNoticeStr(nodex[0].InnerText));
            }

            FileOperations.WriteHolidaysFile(holidayList);

            return holidayList;
        }

        /// <summary>
        /// 获取假期通知UrL
        /// </summary>
        /// <returns></returns>
        private static string GetHolidayNoticeUrl()
        {
            string childPageXpath = "/html/body/div[6]/div[6]/div[2]/div[2]/div/div[1]/div/a";
            var requestUrl = $"http://sousuo.gov.cn/s.htm?q={_year}年部分节假日安排通知&t=zhengcelibrary&orpro=";
            var htmlData = new HttpClientHelper().Get(requestUrl);
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(htmlData);
            HtmlNodeCollection nodex = doc.DocumentNode.SelectNodes(childPageXpath);
            // 获取 http://www.gov.cn/zhengce/zhengceku/2021-10/25/content_5644835.htm
            return nodex[0].Attributes["href"].Value;
        }

        /// <summary>
        ///  将通知信息转成模型
        /// </summary>
        /// <param name="noticeStr"></param>
        /// <returns></returns>
        private static HolidayDto HandleHolidayNoticeStr(string noticeStr)
        {
            var holiday = new HolidayDto();
            //noticeStr = "五、端午节：6月3日至5日放假，共3天。";
            // 首先根据 句号 分成两块
            var data = noticeStr.Split(new char[] { '。' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            // 处理放假天数及时间列表
            var durantion = Convert.ToInt32(data[0].GetMidStr("共", "天"));
            holiday.Duration = durantion;
            var holidayDays = new List<string>();

            var priedtempList = data[0].GetMidStr("：", "放假").Split(new string[] { "至" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var year = DateTime.Now.Year;

            var startDay = Convert.ToDateTime(year + "/" + priedtempList[0].Split('年').LastOrDefault().Replace("月", "/").Replace("日", string.Empty));
            int predIndex = 0;

            while (predIndex < durantion)
            {
                holidayDays.Add(startDay.AddDays(predIndex).ToString("yyyy/MM/dd"));
                predIndex++;
            }

            // 处理调休时间列表
            var leaveinlieuDays = new List<string>();
            if (data.Count > 1)
            {
                var workDays = data[1].Split(new string[] { "、" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                workDays?.ForEach(w =>
                {
                    leaveinlieuDays.Add(Convert.ToDateTime(year + "/" + w.Split('（').FirstOrDefault().Replace("月", "/").Replace("日", string.Empty)).ToString("yyyy/MM/dd"));
                });
            }

            holiday.LeaveinlieuDays = leaveinlieuDays;
            holiday.HolidayDays = holidayDays;
            holiday.HolidayName = data[0].GetMidStr("、", "：");

            return holiday;
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
