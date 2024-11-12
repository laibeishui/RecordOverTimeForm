using RecordOverTimeForm.Business;
using RecordOverTimeForm.Common;
using RecordOverTimeForm.Controls;
using RecordOverTimeForm.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RecordOverTimeForm
{
    public partial class 计算加班时间 : Form
    {
        public static List<HolidayDto> _holidays = HolidayNotice.GetHolidayList(DateTime.Now.Year);
        public Calculate _calculate = new Calculate(_holidays);
        private bool isClicked = false;
        private Color _panelHoverBorderColor;
        private Color _panelHoverBackColor;

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
            //ShowDates(DateTime.Now);
            //addOverTimeTimepicker.Value = DateTime.Now;
            //LabelShowTime();
            //datePicker1.Value = DateTime.Now;
            //startTimePicker.
            var now = DateTime.Now;
            yearSelect.SelectedValue = now.Year;
            monthSelect.SelectedValue = now.Month;

            DatesInit(DateTime.Now);
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
            var inputHours = FileOperations.ReadInputOvertimeHours();
            overtimeInput.Value = inputHours;
            var freeDayCount = _calculate.GetFreeDayCount();
            var workDayCount = _calculate._monthCount - freeDayCount;
            var supplytimeHours = workDayCount * 0.5;
            var needOvertimeHours = supplytimeHours + Convert.ToDouble(inputHours);
            var haveOvertimeHours = _calculate.CalculateHadOverTime();
            needOvertimeLabel.Text = $"本月共{workDayCount} 个工作日，需要加{supplytimeHours}个补时 +";
            sumHoursLabel.Text = $"小时 = {supplytimeHours + Convert.ToDouble(inputHours)}个小时";
            var surplusOvertime = needOvertimeHours - haveOvertimeHours;
            if (surplusOvertime > 0)
            {
                overtime.Text = $"本月目前已加{haveOvertimeHours}小时，还需要加{needOvertimeHours - haveOvertimeHours}个小时";
            }
            else if (surplusOvertime == 0)
            {
                overtime.Text = $"本月目前已加{haveOvertimeHours}小时，恭喜你已经加满啦！！！";
            }
            else
            {
                overtime.Text = $"本月目前已加{haveOvertimeHours}小时，你被公司白嫖了{Math.Abs(surplusOvertime)}个小时 ！！！";
            }
        }


        public void DatesInit(DateTime date)
        {
            DateTime nowDate = DateTime.Now;
            DatePanelBoxInit();
            LabelShowTime();
            var firstDayOfMonth = date.AddDays(1 - date.Day);
            var year = date.Year;
            var month = date.Month;
            bool isSameMonth = nowDate.Year == year && nowDate.Month == month ? true : false;
            var monthCount = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(firstDayOfMonth.DayOfWeek);
            // dayOfWeek 周日获取出来是 0  ,需要修改成 7
            if (dayofweek == 0) dayofweek = 7;
            int controlnum = dayofweek;
            var readDic = FileOperations.ReadIniFile(date);
            var readDicKeyList = readDic?.Keys.ToList();
            List<AntdUI.Panel> datePanels = GetDatePanels();
            var holidays = HolidayNotice.GetHolidayList(date.Year);
            for (var i = 1; i <= monthCount; i++)
            {
                var overtime = "";
                if (readDicKeyList != null && readDicKeyList.Count != 0 && readDicKeyList.Contains(i) && readDic[i] >= 0)
                {
                    overtime = readDic[i].ToString("F1");
                }
                var day = firstDayOfMonth.AddDays(i - 1);
                var datePanel = datePanels[controlnum - 1];
                PanelStyle(datePanel, day, i,holidays, overtime);

                datePanel.Visible = true;
                if (isSameMonth && nowDate.Day == i)
                {
                    datePanel.Badge = "今";
                    datePanel.BadgeBack = System.Drawing.Color.Blue;
                    datePanel.BadgeOffsetX = -1;
                    datePanel.BadgeOffsetY = -1;
                    datePanel.BadgeSize = 1F;
                }
                controlnum++;
            }
        }

        private void PanelStyle(AntdUI.Panel panel, DateTime day, int dayindex, List<HolidayDto> holidays, string overtime = "")
        {
            var dayType = HolidayNotice.GetDayType(day, holidays);
            var cc = new ChineseCalendar(day);
            var holidayName = GetHolidayStr(cc);
            var labels = GetLabelsInPanel(panel);
            foreach (var label in labels)
            {
                if (label.Name.Contains("dateLabel"))
                {
                    label.Text = dayindex.ToString("D2");
                }
                else if (label.Name.Contains("overtimeLabel"))
                {
                    label.Text = overtime;
                }
                else if (label.Name.Contains("holidayLabel"))
                {
                    label.Text = holidayName;
                }
                else
                {
                    label.Text = cc.ChineseMonthData;
                }
            }

            if (dayType == DayType.假期)
            {
                panel.BorderColor = Color.Green;
                panel.Badge = "休";
                panel.BadgeBack = System.Drawing.Color.Green;
                panel.BadgeOffsetX = -1;
                panel.BadgeOffsetY = -1;
                panel.BadgeSize = 1F;
                panel.BorderColor = Color.Green;
            }
            else if (dayType == DayType.周末)
            {
                panel.BorderColor = Color.Green;
            }
            else if (dayType == DayType.工作)
            {
                panel.BorderColor = Color.LightGray;
            }
            else if (dayType == DayType.调休)
            {
                panel.Badge = "班";
                panel.BadgeBack = System.Drawing.Color.Red;
                panel.BadgeOffsetX = -1;
                panel.BadgeOffsetY = -1;
                panel.BadgeSize = 1F;
                panel.BorderColor = Color.LightGray;
            }

            if (overtime != "" && overtime != "0")
            {
                panel.BackColor = Color.Yellow;
                panel.Back = Color.Yellow;
                foreach (Control control in panel.Controls)
                {
                    control.BackColor = Color.Yellow;
                }
            }
        }

        private void DatePanelBoxInit()
        {
            List<AntdUI.Panel> foundPanels = GetDatePanels();
            foreach (var panel in foundPanels)
            {
                var labels = GetLabelsInPanel(panel);
                foreach (var label in labels)
                {
                    label.Text = "";
                    label.Enabled = false;
                }
                panel.Badge = null;
                panel.BackColor = Color.White;
                panel.Back = Color.White;
                foreach (Control control in panel.Controls)
                {
                    control.BackColor = Color.White;
                }
                panel.Visible = false;
            }
        }

        // 获取 Panel 下的所有 Label 控件
        private List<AntdUI.Label> GetLabelsInPanel(AntdUI.Panel panel)
        {
            List<AntdUI.Label> labels = new List<AntdUI.Label>();

            foreach (Control control in panel.Controls)
            {
                if (control is AntdUI.Label)
                {
                    labels.Add((AntdUI.Label)control);
                }
            }

            return labels;
        }

        // 查找一个 Panel 上的所有直接子 Panel 控件（不递归）
        private List<AntdUI.Panel> GetDatePanels()
        {
            var backgroundPanel = FindPanelByName("backgroundpanel");

            List<AntdUI.Panel> panels = new List<AntdUI.Panel>();

            // 遍历 parentPanel 的所有直接子控件
            foreach (Control control in backgroundPanel.Controls)
            {
                if (control is AntdUI.Panel)
                {
                    panels.Add((AntdUI.Panel)control);  // 如果是 Panel 控件，添加到结果列表
                }
            }

            return panels.OrderBy(p => ExtractNumberFromName(p.Name)).ToList();
        }

        // 提取 Name 中的数字部分
        private int ExtractNumberFromName(string name)
        {
            // 使用正则表达式提取 Name 中的数字部分
            var match = Regex.Match(name, @"\d+");
            return match.Success ? int.Parse(match.Value) : 0;
        }

        // 通过 Name 查找指定的 Panel 控件
        private AntdUI.Panel FindPanelByName(string panelName)
        {
            foreach (Control control in this.Controls)
            {
                if (control is AntdUI.Panel && control.Name == panelName)
                {
                    return (AntdUI.Panel)control;
                }
            }
            return null; // 如果没有找到，返回 null
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            base.OnMouseEnter(e);
            if (!isClicked)
            {
                AntdUI.Panel panel = sender as AntdUI.Panel;
                _panelHoverBorderColor = (Color)panel.BorderColor;
                _panelHoverBackColor = (Color)panel.BackColor;
                foreach (Control control in panel.Controls)
                {
                    control.BackColor = Color.FromArgb(210, 210, 210);
                }

                panel.BackColor = Color.FromArgb(210, 210, 210);
                panel.Back = Color.FromArgb(210, 210, 210);
                panel.BorderColor = Color.DarkBlue;
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            base.OnMouseLeave(e);
            AntdUI.Panel panel = sender as AntdUI.Panel;
            panel.BackColor = _panelHoverBackColor;
            foreach (Control control in panel.Controls)
            {
                control.BackColor = _panelHoverBackColor;
            }
            panel.Back = _panelHoverBackColor;
            panel.BorderColor = _panelHoverBorderColor;
            isClicked = false;
        }

        private void DatePanel_Click(object sender, EventArgs e)
        {
            var monthValue = Convert.ToInt32(monthSelect.SelectedValue);
            var yearValue = Convert.ToInt32(yearSelect.SelectedValue);
            base.OnClick(e);
            AntdUI.Panel panel = sender as AntdUI.Panel;
            var labels = GetLabelsInPanel(panel);
            var dateLabel = labels.Where(x => x.Name.Contains("dateLabel")).FirstOrDefault();
            var date = new DateTime(yearValue, monthValue, Convert.ToInt32(dateLabel.Text));
            new Drawer(this, date).DatePanel_Click(sender, e);
        }

        private void yearOrmonth_SelectedValueChanged(object sender, AntdUI.ObjectNEventArgs e)
        {
            var monthValue = Convert.ToInt32(monthSelect.SelectedValue ?? "1");
            var yearValue = Convert.ToInt32(yearSelect.SelectedValue);
            var date = new DateTime(yearValue, monthValue, 1);
            DatesInit(date);
        }

        private void overtimeInput_ValueChanged(object sender, AntdUI.DecimalEventArgs e)
        {
            var overtimeHour = overtimeInput.Value;
            if (overtimeHour > 0)
            {
                var isWrite = FileOperations.WriteInputOverTimeHours(overtimeHour);
                if (isWrite)
                {
                    LabelShowTime();
                }
            }
        }
    }
}
