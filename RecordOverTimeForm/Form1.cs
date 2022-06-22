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
        public int _year;
        public int _month;
        public int _monthCount;

        public static string WorkDayError = "工作日加班时长不超过3.5小时！ ";

        public static string FreeDayError = "休息日加班时长不超过7.5小时！ ";

        public 计算加班时间()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            _year = DateTime.Now.Year;
            _month = DateTime.Now.Month;
            _monthCount = DateTime.DaysInMonth(_year, _month);
            ShowDates();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //var coltb = this.Controls.Find("textbox" + "10", false);
            //coltb[0].Text = "找到一个";
            //var i = 1;
            //TextBox tb = (TextBox)sender;
            //Label lbl = (Label)pan_father.Controls[tb.Name.Split('_')[1]];
            ShowDates();
        }

        private void ShowDates()
        {

            //var coltb = this.Controls.Find("textbox" + "10",false);
            var firstDayOfMonth = DateTime.Now.AddDays(1 - DateTime.Now.Day);

            int dayofweek = Convert.ToInt32(firstDayOfMonth.DayOfWeek);
            int controlnum = 7 + dayofweek;

            //var overtimehours = "";
            for (var i = 1; i <= _monthCount; i++)
            {
                var overtimehours = "";
                var coltb = this.Controls.Find("textbox" + controlnum, false);
                if (i == 6) overtimehours = "3.5";
                coltb[0].Text = i.ToString()+"    "+overtimehours+"hours";
                controlnum++;
                
            }
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
                if (textBox42.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(textBox42.Text, out oldf);
                    b2 = float.TryParse(textBox42.Text + e.KeyChar.ToString(), out f);
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            var date= Convert.ToDateTime(dateTimePicker1.Text);

            var overTimeHovers = Convert.ToDouble(textBox42.Text);
            
            int dayOfWeek =Convert.ToInt32(date.DayOfWeek);

            if (dayOfWeek < 6 && overTimeHovers>3.5) 
            {
                DialogResult dialogResult = Popup.Tips(WorkDayError);
                if (dialogResult.Equals(DialogResult.Yes))
                {
                    textBox42.Text = "";
                }
            }
            else if(overTimeHovers > 7.5)
            {
                DialogResult dialogResult = Popup.Tips(WorkDayError);
                if (dialogResult.Equals(DialogResult.Yes))
                {
                    textBox42.Text = "";
                }
            }
            
            
        }
    }
}
