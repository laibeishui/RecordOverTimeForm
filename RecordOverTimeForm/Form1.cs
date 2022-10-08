using RecordOverTimeForm.Business;
using RecordOverTimeForm.Common;
using RecordOverTimeForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordOverTimeForm
{
    public partial class 计算加班时间 : Form
    {
        public static List<HolidayDto> holidays = HolidayNotice.GetHolidayList();

        public Calculate calculate = new Calculate(holidays);

        public static string WorkDayError = "工作日加班时长不超过3.5小时！ ";

        public static string FreeDayError = "休息日加班时长不超过7.5小时！ ";

        public 计算加班时间()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowDates(DateTime.Now);
            LabelShowTime();
        }

        /// <summary>
        /// 点击输入加班时长，限制只能输入数字和小数点，并且小数点不能作为开头，不能存在两个小数点 
        /// （时长：周六周日不能超过7.5 ，周一到周五不能超过3.5）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void overTimeInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;
            //小数点的处理。
            if ((int)e.KeyChar == 46) //小数点                          
            {
                if (overTimeInput.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(overTimeInput.Text, out oldf);
                    b2 = float.TryParse(overTimeInput.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }


        /// <summary>
        /// 展示某月和当月加班时间
        /// </summary>
        private void ShowDates(DateTime date)
        {
            TextBoxInit();
            var firstDayOfMonth = date.AddDays(1 - date.Day);
            var year = date.Year;
            var month = date.Month;
            var monthCount = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(firstDayOfMonth.DayOfWeek);

            // dayOfWeek 周日获取出来是 0  ,需要修改成 7
            if (dayofweek == 0) dayofweek = 7;

            int controlnum = dayofweek;
            var readDic = FileOperations.ReadIniFile(date);
            var readDicKeyList = readDic?.Keys.ToList();
            for (var i = 1; i <= monthCount; i++)
            {
                var day = firstDayOfMonth.AddDays(i - 1);
                var dayType = HolidayNotice.GetDayType(day,holidays);
                
                var cc = new ChineseCalendar(day);
                var coltb = this.Controls.Find("tb" + controlnum, false);
                if (dayType == dayType.假期)
                {
                    coltb[0].BackColor = Color.LightGreen;
                    coltb[0].ForeColor = Color.Black;
                }
                else if (dayType == dayType.周末)
                {
                    coltb[0].BackColor = Color.SkyBlue;
                    coltb[0].ForeColor = Color.Black;
                }
                else if (dayType == dayType.工作)
                {
                    coltb[0].BackColor = Color.LightPink;
                    coltb[0].ForeColor = Color.Black;
                }
                else if (dayType == dayType.调休)
                {
                    coltb[0].BackColor = Color.OrangeRed;
                    coltb[0].ForeColor = Color.White;
                }
                var calendarCellText = "\r\n农历：" + cc.ChineseMonthData + "\r\n"+ dayType.ToString() + "\r\n" + GetHolidayStr(cc);
                if (readDicKeyList != null && readDicKeyList.Count != 0 && readDicKeyList.Contains(i) && readDic[i]!=0)
                {
                    coltb[0].Text = i.ToString() + "  " + readDic[i].ToString() + "小时"+ calendarCellText;
                    coltb[0].BackColor = Color.Yellow;
                }
                else
                {
                    coltb[0].Text = i.ToString()+calendarCellText;
                }
                coltb[0].Visible = true;
                controlnum++;
            }
        }

        /// <summary>
        /// 获取节日字符串
        /// </summary>
        private string GetHolidayStr(ChineseCalendar cc)
        {
            var holidayStr = string.Empty;
            if (!string.IsNullOrEmpty(cc.ChineseCalendarHoliday))
            {
                holidayStr = cc.ChineseCalendarHoliday;
            }

            if (!string.IsNullOrEmpty(cc.DateHoliday))
            {
                if (!string.IsNullOrEmpty(holidayStr))
                    holidayStr += "|";
                holidayStr += cc.DateHoliday;
            }
            return holidayStr;
        }


        /// <summary>
        ///  更改label 上的加班时间和剩余时间
        /// </summary>
        private void LabelShowTime()
        {
            var freeDayCount = calculate.GetFreeDayCount();
            var workDayCount = calculate._monthCount - freeDayCount;
            label4.Text = $"这个月总共有 {workDayCount} 个工作日，所以你需要加班的时长为 {workDayCount*0.5+40} 个小时";
            overtime.Text = $" 这个月你一共加班了{calculate.CalculateHadOverTime()}小时的班";

        }


        /// <summary>
        /// 查看加班记录日期选择器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void watchOverTimeRecordTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var date = Convert.ToDateTime(watchOverTimeRecordTimePicker.Text);
            ShowDates(date);
        }

        
        /// <summary>
        /// 周六周日计算与否
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// 初始化日期列表
        /// </summary>
        private void TextBoxInit()
        {
            for (var i = 1; i <= 42; i++)
            {
                var coltb = this.Controls.Find("tb" + i.ToString(), false);
                coltb[0].Text = "";
                coltb[0].BackColor= Color.White;
                coltb[0].Visible = false;
            }
        }

        private void submitOverTime_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(overTimeInput.Text)) return;
            var date = Convert.ToDateTime(addOverTimeTimepicker.Text);
            var dayType = HolidayNotice.GetDayType(date, holidays);
            var overTimeHovers = Convert.ToDouble(overTimeInput.Text);

            if ((dayType ==dayType.工作||dayType==dayType.调休)&&overTimeHovers>3.5)
            {
                DialogResult dialogResult = Popup.Tips(WorkDayError);
                if (dialogResult.Equals(DialogResult.Yes) || dialogResult.Equals(DialogResult.No))
                {
                    overTimeInput.Text = "";
                    return;
                }
            }
            else if (overTimeHovers > 7.5)
            {
                DialogResult dialogResult = Popup.Tips(FreeDayError);
                if (dialogResult.Equals(DialogResult.Yes)||dialogResult.Equals(DialogResult.No))
                {
                    overTimeInput.Text = "";
                    return;
                }
            }

            bool hasWrite = FileOperations.WriteIniFile(date, overTimeHovers);
            if (hasWrite)
            {
                DialogResult dialogResult = Popup.Tips("保存成功");
                if (dialogResult.Equals(DialogResult.Yes) || dialogResult.Equals(DialogResult.No))
                {
                    ShowDates(DateTime.Now);
                    LabelShowTime();
                }
            }
            else
            {
                DialogResult dialogResult = Popup.Tips("保存失败，请尝试重新提交");
                if (dialogResult.Equals(DialogResult.Yes)) { }
            }
        }

        private void tb8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
