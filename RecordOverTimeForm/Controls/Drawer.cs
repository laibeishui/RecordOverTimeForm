using RecordOverTimeForm.Business;
using RecordOverTimeForm.Common;
using RecordOverTimeForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RecordOverTimeForm.Controls
{
    public partial class Drawer : UserControl
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private AntdUI.Panel drawerPanel;
        private AntdUI.Panel addPanel;
        private AntdUI.Panel temppanel1;
        private AntdUI.Label lt1;
        private AntdUI.Label label1;
        private AntdUI.TimePicker tpe1;
        private AntdUI.TimePicker tps1;
        private AntdUI.Label addHourLabel;
        private AntdUI.Button addOvertimeBtn;

        private AntdUI.Label label5;
        private AntdUI.TimePicker addStarttimePicker;
        private AntdUI.TimePicker addEndtimepicker;
        private AntdUI.Button button3;
        private AntdUI.Button button1;
        Form _form;
        private DateTime _date;
        private AntdUI.Panel _addPanel;
        private AntdUI.TimePicker _addStarttimePicker;
        private AntdUI.TimePicker _addEndtimePicker;
        private AntdUI.Label _addHourLabel;
        private AntdUI.Button _addOvertimeBtn;


        public Drawer(Form form, DateTime date)
        {
            _form = form;
            _date = date;
            InitializeComponent();
        }

        public void DatePanel_Click(object sender, EventArgs e)
        {
            DatePanelInitialize();
        }


        private void DatePanelInitialize()
        {
            var overtimes = FileOperations.ReadDayOverTime(_date);
            // 删除界面样式
            drawerPanel.Controls.Clear();
            addPanelInitialize();
            if (overtimes == null || overtimes.Count == 0)
            {
                addPanel.Location = new System.Drawing.Point(39, 3);
                drawerPanel.Size = new System.Drawing.Size(762, 80);
            }
            else
            {
                for (int i = 0; i < overtimes.Count; i++)
                {
                    var tempPanel = new AntdUI.Panel()
                    {
                        Location = new System.Drawing.Point(39, 3 + 69 * i),
                        Name = "addedPanel" + (i + 1).ToString(),
                        Shadow = 5,
                        ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5))))),
                        Size = new System.Drawing.Size(639, 66),
                        TabIndex = 0,
                        Text = "panel1"
                    };
                    tempPanel.Controls.Add(new AntdUI.TimePicker()
                    {
                        Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                        Format = "HH:mm",
                        Location = new System.Drawing.Point(27, 3),
                        Name = "starttimePicker" + (i + 1).ToString(),
                        PlaceholderText = "开始时间",
                        Size = new System.Drawing.Size(111, 60),
                        TabIndex = 18,
                        Value = overtimes[i].StartTime
                    });
                    var endTimePickerTemp = new AntdUI.TimePicker()
                    {
                        Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                        Format = "HH:mm",
                        Location = new System.Drawing.Point(174, 3),
                        Name = "endtimePicker" + (i + 1).ToString(),
                        PlaceholderText = "开始时间",
                        Size = new System.Drawing.Size(111, 60),
                        TabIndex = 18,
                        Value = overtimes[i].EndTime
                    };
                    endTimePickerTemp.ValueChanged += new AntdUI.TimeSpanNEventHandler(this.panelEndTimePicker_Changed);
                    tempPanel.Controls.Add(endTimePickerTemp);
                    tempPanel.Controls.Add(new AntdUI.Label()
                    {
                        BackColor = System.Drawing.SystemColors.ControlLightLight,
                        Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                        Location = new System.Drawing.Point(321, 17),
                        Name = "labelTime" + (i + 1).ToString(),
                        Size = new System.Drawing.Size(95, 36),
                        TabIndex = 20,
                        Text = overtimes[i].PeriodDiff + "  h"
                    });
                    // 创建 "修改" 按钮并绑定 Click 事件
                    var updateButton = new AntdUI.Button()
                    {
                        Cursor = System.Windows.Forms.Cursors.Default,
                        Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                        Location = new System.Drawing.Point(437, 3),
                        Name = "updateBtn" + (i + 1).ToString(),
                        Size = new System.Drawing.Size(81, 60),
                        TabIndex = 19,
                        Text = "修改",
                        Type = AntdUI.TTypeMini.Warn
                    };
                    updateButton.Click += new System.EventHandler(UpdateButton_Click); // 绑定事件
                    tempPanel.Controls.Add(updateButton);

                    var deleteButton = new AntdUI.Button()
                    {
                        Cursor = System.Windows.Forms.Cursors.Default,
                        Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                        Location = new System.Drawing.Point(543, 3),
                        Name = "deleteBtn" + (i + 1).ToString(),
                        Size = new System.Drawing.Size(81, 60),
                        TabIndex = 19,
                        Text = "删除",
                        Type = AntdUI.TTypeMini.Error
                    };

                    deleteButton.Click += new System.EventHandler(DeleteButton_Click); // 绑定事件
                    tempPanel.Controls.Add(deleteButton);
                    drawerPanel.Controls.Add(tempPanel);
                }
                _addPanel.Location = new System.Drawing.Point(39, 70 * overtimes.Count + 1);
                drawerPanel.Size = new System.Drawing.Size(762, 80 + 70 * overtimes.Count);
            }
            drawerPanel.Controls.Add(_addPanel);
            var align = AntdUI.TAlignMini.Top;

            var config = new AntdUI.Drawer.Config(_form, drawerPanel)
            {
                Align = AntdUI.TAlignMini.Top,
                MaskClosable=true,
                // 设置关闭回调函数
                OnClose = () =>
                {
                    计算加班时间 form =  _form as 计算加班时间 ;
                    form.DatesInit(_date);
                }
            };
            AntdUI.Drawer.open(config);
        }

        private void addPanelInitialize()
        {
            _addPanel = new AntdUI.Panel()
            {
                Location = new System.Drawing.Point(39, 3),
                Name = "addPanel",
                Shadow = 5,
                ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5))))),
                Size = new System.Drawing.Size(639, 66),
                TabIndex = 0,
                Text = "panel1"
            };

            _addStarttimePicker = new AntdUI.TimePicker()
            {
                Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                Format = "HH:mm",
                Location = new System.Drawing.Point(27, 3),
                Name = "addStarttimePicker",
                PlaceholderText = "开始时间",
                Size = new System.Drawing.Size(111, 60),
                TabIndex = 18
            };

            _addEndtimePicker = new AntdUI.TimePicker()
            {
                Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                Format = "HH:mm",
                Location = new System.Drawing.Point(174, 3),
                Name = "addEndtimepicker",
                PlaceholderText = "开始时间",
                Size = new System.Drawing.Size(111, 60),
                TabIndex = 18,
                Text = "00:00"
            };
            _addEndtimePicker.ValueChanged += new AntdUI.TimeSpanNEventHandler(this.endTimePicker_Changed);

            _addHourLabel = new AntdUI.Label()
            {
                BackColor = System.Drawing.SystemColors.ControlLightLight,
                Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                Location = new System.Drawing.Point(336, 12),
                Name = "addHourLabel",
                Size = new System.Drawing.Size(95, 42),
                TabIndex = 20,
                Text = "0 h"
            };
            _addOvertimeBtn = new AntdUI.Button()
            {
                Cursor = System.Windows.Forms.Cursors.Default,
                Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                Location = new System.Drawing.Point(474, 3),
                Name = "addOvertimeBtn",
                Size = new System.Drawing.Size(123, 60),
                TabIndex = 19,
                Text = "添加加班时间",
                Type = AntdUI.TTypeMini.Primary
            };
            _addOvertimeBtn.Click += new System.EventHandler(this.SubmitOverTime_Click);
            _addPanel.Controls.Add(_addStarttimePicker);
            _addPanel.Controls.Add(_addEndtimePicker);
            _addPanel.Controls.Add(_addHourLabel);
            _addPanel.Controls.Add(_addOvertimeBtn);
        }

        private void InitializeComponent()
        {
            this.drawerPanel = new AntdUI.Panel();
            this.addPanel = new AntdUI.Panel();
            this.addHourLabel = new AntdUI.Label();
            this.addOvertimeBtn = new AntdUI.Button();
            this.addEndtimepicker = new AntdUI.TimePicker();
            this.label5 = new AntdUI.Label();
            this.addStarttimePicker = new AntdUI.TimePicker();
            this.temppanel1 = new AntdUI.Panel();
            this.lt1 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.tpe1 = new AntdUI.TimePicker();
            this.tps1 = new AntdUI.TimePicker();
            this.button3 = new AntdUI.Button();
            this.button1 = new AntdUI.Button();
            this.drawerPanel.SuspendLayout();
            this.addPanel.SuspendLayout();
            this.temppanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawerPanel
            // 
            this.drawerPanel.Back = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.drawerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.drawerPanel.Controls.Add(this.addPanel);
            this.drawerPanel.Controls.Add(this.temppanel1);
            this.drawerPanel.Location = new System.Drawing.Point(3, 3);
            this.drawerPanel.Name = "drawerPanel";
            this.drawerPanel.Size = new System.Drawing.Size(762, 321);
            this.drawerPanel.TabIndex = 0;
            this.drawerPanel.Text = "panel1";
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.addHourLabel);
            this.addPanel.Controls.Add(this.addOvertimeBtn);
            this.addPanel.Controls.Add(this.addEndtimepicker);
            this.addPanel.Controls.Add(this.label5);
            this.addPanel.Controls.Add(this.addStarttimePicker);
            this.addPanel.Location = new System.Drawing.Point(39, 141);
            this.addPanel.Name = "addPanel";
            this.addPanel.Shadow = 5;
            this.addPanel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.addPanel.Size = new System.Drawing.Size(639, 66);
            this.addPanel.TabIndex = 0;
            this.addPanel.Text = "panel1";
            // 
            // addHourLabel
            // 
            this.addHourLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addHourLabel.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addHourLabel.Location = new System.Drawing.Point(336, 12);
            this.addHourLabel.Name = "addHourLabel";
            this.addHourLabel.Size = new System.Drawing.Size(95, 42);
            this.addHourLabel.TabIndex = 20;
            this.addHourLabel.Text = "0 h";
            // 
            // addOvertimeBtn
            // 
            this.addOvertimeBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.addOvertimeBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addOvertimeBtn.Location = new System.Drawing.Point(474, 3);
            this.addOvertimeBtn.Name = "addOvertimeBtn";
            this.addOvertimeBtn.Size = new System.Drawing.Size(123, 60);
            this.addOvertimeBtn.TabIndex = 19;
            this.addOvertimeBtn.Text = "添加加班时间";
            this.addOvertimeBtn.Type = AntdUI.TTypeMini.Primary;
            this.addOvertimeBtn.Click += new System.EventHandler(this.SubmitOverTime_Click);
            // 
            // addEndtimepicker
            // 
            this.addEndtimepicker.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addEndtimepicker.Format = "HH:mm";
            this.addEndtimepicker.Location = new System.Drawing.Point(174, 3);
            this.addEndtimepicker.Name = "addEndtimepicker";
            this.addEndtimepicker.PlaceholderText = "开始时间";
            this.addEndtimepicker.Size = new System.Drawing.Size(111, 60);
            this.addEndtimepicker.TabIndex = 18;
            this.addEndtimepicker.Text = "00:00";
            this.addEndtimepicker.ValueChanged += new AntdUI.TimeSpanNEventHandler(this.endTimePicker_Changed);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(144, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "-->";
            // 
            // addStarttimePicker
            // 
            this.addStarttimePicker.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addStarttimePicker.Format = "HH:mm";
            this.addStarttimePicker.Location = new System.Drawing.Point(27, 3);
            this.addStarttimePicker.Name = "addStarttimePicker";
            this.addStarttimePicker.PlaceholderText = "开始时间";
            this.addStarttimePicker.Size = new System.Drawing.Size(111, 60);
            this.addStarttimePicker.TabIndex = 18;
            this.addStarttimePicker.Text = "00:00";
            // 
            // temppanel1
            // 
            this.temppanel1.Controls.Add(this.lt1);
            this.temppanel1.Controls.Add(this.label1);
            this.temppanel1.Controls.Add(this.tpe1);
            this.temppanel1.Controls.Add(this.tps1);
            this.temppanel1.Controls.Add(this.button3);
            this.temppanel1.Controls.Add(this.button1);
            this.temppanel1.Location = new System.Drawing.Point(39, 3);
            this.temppanel1.Name = "temppanel1";
            this.temppanel1.Shadow = 5;
            this.temppanel1.Size = new System.Drawing.Size(639, 66);
            this.temppanel1.TabIndex = 0;
            this.temppanel1.Text = "panel1";
            // 
            // lt1
            // 
            this.lt1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lt1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lt1.Location = new System.Drawing.Point(321, 17);
            this.lt1.Name = "lt1";
            this.lt1.Size = new System.Drawing.Size(95, 36);
            this.lt1.TabIndex = 20;
            this.lt1.Text = "3.5 h";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(144, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "-->";
            // 
            // tpe1
            // 
            this.tpe1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tpe1.Format = "HH:mm";
            this.tpe1.Location = new System.Drawing.Point(174, 3);
            this.tpe1.Name = "tpe1";
            this.tpe1.PlaceholderText = "开始时间";
            this.tpe1.Size = new System.Drawing.Size(111, 60);
            this.tpe1.TabIndex = 18;
            this.tpe1.Text = "00:00";
            // 
            // tps1
            // 
            this.tps1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tps1.Format = "HH:mm";
            this.tps1.Location = new System.Drawing.Point(27, 3);
            this.tps1.Name = "tps1";
            this.tps1.PlaceholderText = "开始时间";
            this.tps1.Size = new System.Drawing.Size(111, 60);
            this.tps1.TabIndex = 18;
            this.tps1.Text = "00:00";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(437, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 60);
            this.button3.TabIndex = 19;
            this.button3.Text = "修改";
            this.button3.Type = AntdUI.TTypeMini.Warn;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(543, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 60);
            this.button1.TabIndex = 19;
            this.button1.Text = "删除";
            this.button1.Type = AntdUI.TTypeMini.Error;
            // 
            // Drawer
            // 
            this.Controls.Add(this.drawerPanel);
            this.Name = "Drawer";
            this.Size = new System.Drawing.Size(770, 398);
            this.drawerPanel.ResumeLayout(false);
            this.addPanel.ResumeLayout(false);
            this.temppanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        // "修改" 按钮事件处理方法
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"修改按钮被点击");
            // 获取触发事件的按钮
            var button = sender as AntdUI.Button;
            if (button == null) return;

            // 获取按钮所在的父级 Panel
            var parentPanel = button.Parent as AntdUI.Panel;
            if (parentPanel == null) return;

            var panelName = parentPanel.Name;
            var index = Convert.ToInt32(panelName.Replace("addedPanel", ""));

            // 查找父 Panel 中的 startTimePicker 和 endTimePicker
            var startTimePicker = parentPanel.Controls.OfType<AntdUI.TimePicker>().FirstOrDefault(tp => tp.Name.StartsWith("starttimePicker"));
            var endTimePicker = parentPanel.Controls.OfType<AntdUI.TimePicker>().FirstOrDefault(tp => tp.Name.StartsWith("endtimePicker"));

            if (startTimePicker != null && endTimePicker != null)
            {
                // 获取 TimePicker 的值
                var startTime = startTimePicker.Value;
                var endTime = endTimePicker.Value;
                if (IsRightPeriod(startTime, endTime))
                {
                    var updated = FileOperations.UpdateIniFileContent(_date, startTime.TotalSeconds, endTime.TotalSeconds, index);
                    if (updated)
                    {
                        DatePanelInitialize();
                    }
                    else
                    {
                        MessageBox.Show("数据更新失败，请重新操作");
                        DatePanelInitialize();
                    }
                }
            }
            else
            {
                MessageBox.Show("未找到 TimePicker 控件");
            }
        }

        // "删除" 按钮事件处理方法
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var button = sender as AntdUI.Button;
            if (button == null) return;

            // 获取按钮所在的父级 Panel
            var parentPanel = button.Parent as AntdUI.Panel;
            if (parentPanel == null) return;

            var panelName = parentPanel.Name;
            var index = Convert.ToInt32(panelName.Replace("addedPanel", ""));
            // 查找父 Panel 中的 startTimePicker 和 endTimePicker
            bool hasdelete = FileOperations.DeleteIniFileContent(_date, index);
            if (hasdelete)
            {
                DatePanelInitialize();
            }
            else
            {
                MessageBox.Show("删除失败，请重新操作！！！");
                DatePanelInitialize();
            }
        }

        private void SubmitOverTime_Click(object sender, EventArgs e)
        {
            var startTime = _addStarttimePicker.Value;
            var endTime = _addEndtimePicker.Value;
            if (IsRightPeriod(startTime, endTime))
            {
                bool haswrite = FileOperations.WriteIniFile(_date, startTime.TotalSeconds, endTime.TotalSeconds);
                if (haswrite)
                {
                    DatePanelInitialize();
                }
                else
                {
                    MessageBox.Show("添加失败，请重新操作！！！");
                    DatePanelInitialize();
                }
            }
        }

        private void panelEndTimePicker_Changed(object sender, AntdUI.TimeSpanNEventArgs e)
        {
            // 添加你的业务逻辑
            // 获取触发事件的按钮
            var endTimePicker = sender as AntdUI.TimePicker;
            if (endTimePicker == null) return;

            // 获取按钮所在的父级 Panel
            var parentPanel = endTimePicker.Parent as AntdUI.Panel;
            if (parentPanel == null) return;
            // 查找父 Panel 中的 startTimePicker 和 endTimePicker
            var startTimePicker = parentPanel.Controls.OfType<AntdUI.TimePicker>().FirstOrDefault(tp => tp.Name.StartsWith("starttimePicker"));
            if (startTimePicker != null && endTimePicker != null)
            {
                // 获取 TimePicker 的值
                var startTime = startTimePicker.Value;
                var endTime = endTimePicker.Value;
                if (startTime < endTime)
                {
                    var label = parentPanel.Controls.OfType<AntdUI.Label>().FirstOrDefault(tp => tp.Name.StartsWith("labelTime"));
                    var difHour = (endTime - startTime).TotalHours;
                    label.Text = Math.Round(difHour, 1).ToString() + " h";
                }
            }
        }
        private void endTimePicker_Changed(object sender, AntdUI.TimeSpanNEventArgs e)
        {
            var starttime = _addStarttimePicker.Value;
            var endtime = _addEndtimePicker.Value;
            if (IsRightPeriod(starttime, endtime,false))
            {
                var difHour = (endtime - starttime).TotalHours;
                _addHourLabel.Text = Math.Round(difHour, 1).ToString() + " h";
            }
        }

        private bool IsRightPeriod(TimeSpan start,TimeSpan end,bool showMsg = true)
        {
            if (start == TimeSpan.Zero && end == TimeSpan.Zero)
            {
                return false;
            }
            else if (start > end)
            {
                if (showMsg)
                {
                    MessageBox.Show("结束时间应大于开始时间！！！");
                }
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
