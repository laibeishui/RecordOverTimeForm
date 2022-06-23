using RecordOverTimeForm.Business;
using RecordOverTimeForm.Common;
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
        private void textBox42_KeyPress(object sender, KeyPressEventArgs e)
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

        private void SubmitOverTime_Click(object sender, EventArgs e)
        {
            var date = Convert.ToDateTime(addOverTimeTimepicker.Text);
            var overTimeHovers = Convert.ToDouble(overTimeInput.Text);
            int dayOfWeek = Convert.ToInt32(date.DayOfWeek);

            // DayOfWeek 会返回0，需要改成 7
            if (dayOfWeek == 0) dayOfWeek = 7;

            if (dayOfWeek < 6 && overTimeHovers > 3.5)
            {
                DialogResult dialogResult = Popup.Tips(WorkDayError);
                if (dialogResult.Equals(DialogResult.Yes))
                {
                    overTimeInput.Text = "";
                    return;
                }
            }
            else if (overTimeHovers > 7.5)
            {
                DialogResult dialogResult = Popup.Tips(WorkDayError);
                if (dialogResult.Equals(DialogResult.Yes))
                {
                    overTimeInput.Text = "";
                    return;
                }
            }

            bool hasWrite = FileOperations.WriteIniFile(date, overTimeHovers);
            if (hasWrite)
            {
                DialogResult dialogResult = Popup.Tips("保存成功");
                if (dialogResult.Equals(DialogResult.Yes)|| dialogResult.Equals(DialogResult.No)) 
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
                var coltb = this.Controls.Find("tb" + controlnum, false);
                if (readDicKeyList != null && readDicKeyList.Count != 0 && readDicKeyList.Contains(i))
                {
                    coltb[0].Text = i.ToString() + "  " + readDic[i].ToString() + "小时";
                    coltb[0].BackColor = Color.Yellow;
                }
                else
                {
                    coltb[0].Text = i.ToString();
                }
                coltb[0].Visible = true;
                controlnum++;
            }
        }


        /// <summary>
        ///  更改label 上的加班时间和剩余时间
        /// </summary>
        private void LabelShowTime()
        {
            var extraOvertime = Calculate.CallculateAllTime();

            label4.Text = $"这个月总共有 {Calculate._monthWorkDayCount} 个工作日，所以你需要加班的时长为 {Calculate.CallculateAllTime()}+40 = {extraOvertime + 40} 个小时";

            overtime.Text = $" 这个月你一共加班了{Calculate.CalculateHadOverTime()}小时的班";

            LastOverTimeShow();
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
            LastOverTimeShow();
        }


        /// <summary>
        /// 显示还能再加多长时间班的方法
        /// </summary>
        private void LastOverTimeShow()
        {
            lastovertime.Text = includeWeek.Checked ?
                $"这个月你撑死还能再加{Calculate.CalculateLastOverTime()}小时(不包含今天)"
                : $"这个月你撑死还能再加{Calculate.CalculateLastOverTimeWithoutWeek()}小时(不包含今天)";
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
    }
}
