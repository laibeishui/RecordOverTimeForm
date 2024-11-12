using RecordOverTimeForm.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RecordOverTimeForm
{
    partial class 计算加班时间
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(计算加班时间));
            this.overtime = new System.Windows.Forms.Label();
            this.needOvertimeLabel = new System.Windows.Forms.Label();
            this.sumHoursLabel = new System.Windows.Forms.Label();
            this.windowBar1 = new AntdUI.WindowBar();
            this.backgroundpanel = new AntdUI.Panel();
            this.yearSelect = new AntdUI.Select();
            this.monthSelect = new AntdUI.Select();
            this.panel42 = new AntdUI.Panel();
            this.lunarLabel42 = new AntdUI.Label();
            this.dateLabel42 = new AntdUI.Label();
            this.holidayLabel42 = new AntdUI.Label();
            this.overtimeLabel42 = new AntdUI.Label();
            this.panel35 = new AntdUI.Panel();
            this.lunarLabel35 = new AntdUI.Label();
            this.dateLabel35 = new AntdUI.Label();
            this.holidayLabel35 = new AntdUI.Label();
            this.overtimeLabel35 = new AntdUI.Label();
            this.panel28 = new AntdUI.Panel();
            this.lunarLabel28 = new AntdUI.Label();
            this.dateLabel28 = new AntdUI.Label();
            this.holidayLabel28 = new AntdUI.Label();
            this.overtimeLabel28 = new AntdUI.Label();
            this.panel21 = new AntdUI.Panel();
            this.lunarLabel21 = new AntdUI.Label();
            this.dateLabel21 = new AntdUI.Label();
            this.holidayLabel21 = new AntdUI.Label();
            this.overtimeLabel21 = new AntdUI.Label();
            this.panel14 = new AntdUI.Panel();
            this.lunarLabel14 = new AntdUI.Label();
            this.dateLabel14 = new AntdUI.Label();
            this.holidayLabel14 = new AntdUI.Label();
            this.overtimeLabel14 = new AntdUI.Label();
            this.panel7 = new AntdUI.Panel();
            this.lunarLabel7 = new AntdUI.Label();
            this.dateLabel7 = new AntdUI.Label();
            this.holidayLabel7 = new AntdUI.Label();
            this.overtimeLabel7 = new AntdUI.Label();
            this.panel41 = new AntdUI.Panel();
            this.lunarLabel41 = new AntdUI.Label();
            this.dateLabel41 = new AntdUI.Label();
            this.holidayLabel41 = new AntdUI.Label();
            this.overtimeLabel41 = new AntdUI.Label();
            this.panel34 = new AntdUI.Panel();
            this.lunarLabel34 = new AntdUI.Label();
            this.dateLabel34 = new AntdUI.Label();
            this.holidayLabel34 = new AntdUI.Label();
            this.overtimeLabel34 = new AntdUI.Label();
            this.panel27 = new AntdUI.Panel();
            this.lunarLabel27 = new AntdUI.Label();
            this.dateLabel27 = new AntdUI.Label();
            this.holidayLabel27 = new AntdUI.Label();
            this.overtimeLabel27 = new AntdUI.Label();
            this.panel20 = new AntdUI.Panel();
            this.lunarLabel20 = new AntdUI.Label();
            this.dateLabel20 = new AntdUI.Label();
            this.holidayLabel20 = new AntdUI.Label();
            this.overtimeLabel20 = new AntdUI.Label();
            this.panel13 = new AntdUI.Panel();
            this.lunarLabel13 = new AntdUI.Label();
            this.dateLabel13 = new AntdUI.Label();
            this.holidayLabel13 = new AntdUI.Label();
            this.overtimeLabel13 = new AntdUI.Label();
            this.panel6 = new AntdUI.Panel();
            this.lunarLabel6 = new AntdUI.Label();
            this.dateLabel6 = new AntdUI.Label();
            this.holidayLabel6 = new AntdUI.Label();
            this.overtimeLabel6 = new AntdUI.Label();
            this.panel40 = new AntdUI.Panel();
            this.lunarLabel40 = new AntdUI.Label();
            this.dateLabel40 = new AntdUI.Label();
            this.holidayLabel40 = new AntdUI.Label();
            this.overtimeLabel40 = new AntdUI.Label();
            this.panel33 = new AntdUI.Panel();
            this.lunarLabel33 = new AntdUI.Label();
            this.dateLabel33 = new AntdUI.Label();
            this.holidayLabel33 = new AntdUI.Label();
            this.overtimeLabel33 = new AntdUI.Label();
            this.panel26 = new AntdUI.Panel();
            this.lunarLabel26 = new AntdUI.Label();
            this.dateLabel26 = new AntdUI.Label();
            this.holidayLabel26 = new AntdUI.Label();
            this.overtimeLabel26 = new AntdUI.Label();
            this.panel19 = new AntdUI.Panel();
            this.lunarLabel19 = new AntdUI.Label();
            this.dateLabel19 = new AntdUI.Label();
            this.holidayLabel19 = new AntdUI.Label();
            this.overtimeLabel19 = new AntdUI.Label();
            this.panel12 = new AntdUI.Panel();
            this.lunarLabel12 = new AntdUI.Label();
            this.dateLabel12 = new AntdUI.Label();
            this.holidayLabel12 = new AntdUI.Label();
            this.overtimeLabel12 = new AntdUI.Label();
            this.panel5 = new AntdUI.Panel();
            this.lunarLabel5 = new AntdUI.Label();
            this.dateLabel5 = new AntdUI.Label();
            this.holidayLabel5 = new AntdUI.Label();
            this.overtimeLabel5 = new AntdUI.Label();
            this.panel39 = new AntdUI.Panel();
            this.lunarLabel39 = new AntdUI.Label();
            this.dateLabel39 = new AntdUI.Label();
            this.holidayLabel39 = new AntdUI.Label();
            this.overtimeLabel39 = new AntdUI.Label();
            this.panel32 = new AntdUI.Panel();
            this.lunarLabel32 = new AntdUI.Label();
            this.dateLabel32 = new AntdUI.Label();
            this.holidayLabel32 = new AntdUI.Label();
            this.overtimeLabel32 = new AntdUI.Label();
            this.panel25 = new AntdUI.Panel();
            this.lunarLabel25 = new AntdUI.Label();
            this.dateLabel25 = new AntdUI.Label();
            this.holidayLabel25 = new AntdUI.Label();
            this.overtimeLabel25 = new AntdUI.Label();
            this.panel18 = new AntdUI.Panel();
            this.lunarLabel18 = new AntdUI.Label();
            this.dateLabel18 = new AntdUI.Label();
            this.holidayLabel18 = new AntdUI.Label();
            this.overtimeLabel18 = new AntdUI.Label();
            this.panel11 = new AntdUI.Panel();
            this.lunarLabel11 = new AntdUI.Label();
            this.dateLabel11 = new AntdUI.Label();
            this.holidayLabel11 = new AntdUI.Label();
            this.overtimeLabel11 = new AntdUI.Label();
            this.panel4 = new AntdUI.Panel();
            this.lunarLabel4 = new AntdUI.Label();
            this.dateLabel4 = new AntdUI.Label();
            this.holidayLabel4 = new AntdUI.Label();
            this.overtimeLabel4 = new AntdUI.Label();
            this.panel38 = new AntdUI.Panel();
            this.lunarLabel38 = new AntdUI.Label();
            this.dateLabel38 = new AntdUI.Label();
            this.holidayLabel38 = new AntdUI.Label();
            this.overtimeLabel38 = new AntdUI.Label();
            this.panel31 = new AntdUI.Panel();
            this.lunarLabel31 = new AntdUI.Label();
            this.dateLabel31 = new AntdUI.Label();
            this.holidayLabel31 = new AntdUI.Label();
            this.overtimeLabel31 = new AntdUI.Label();
            this.panel24 = new AntdUI.Panel();
            this.lunarLabel24 = new AntdUI.Label();
            this.dateLabel24 = new AntdUI.Label();
            this.holidayLabel24 = new AntdUI.Label();
            this.overtimeLabel24 = new AntdUI.Label();
            this.panel17 = new AntdUI.Panel();
            this.lunarLabel17 = new AntdUI.Label();
            this.dateLabel17 = new AntdUI.Label();
            this.holidayLabel17 = new AntdUI.Label();
            this.overtimeLabel17 = new AntdUI.Label();
            this.panel10 = new AntdUI.Panel();
            this.lunarLabel10 = new AntdUI.Label();
            this.dateLabel10 = new AntdUI.Label();
            this.holidayLabel10 = new AntdUI.Label();
            this.overtimeLabel10 = new AntdUI.Label();
            this.panel3 = new AntdUI.Panel();
            this.lunarLabel3 = new AntdUI.Label();
            this.holidayLabel3 = new AntdUI.Label();
            this.overtimeLabel3 = new AntdUI.Label();
            this.dateLabel3 = new AntdUI.Label();
            this.panel37 = new AntdUI.Panel();
            this.lunarLabel37 = new AntdUI.Label();
            this.dateLabel37 = new AntdUI.Label();
            this.holidayLabel37 = new AntdUI.Label();
            this.overtimeLabel37 = new AntdUI.Label();
            this.panel30 = new AntdUI.Panel();
            this.lunarLabel30 = new AntdUI.Label();
            this.dateLabel30 = new AntdUI.Label();
            this.holidayLabel30 = new AntdUI.Label();
            this.overtimeLabel30 = new AntdUI.Label();
            this.panel23 = new AntdUI.Panel();
            this.lunarLabel23 = new AntdUI.Label();
            this.dateLabel23 = new AntdUI.Label();
            this.holidayLabel23 = new AntdUI.Label();
            this.overtimeLabel23 = new AntdUI.Label();
            this.panel16 = new AntdUI.Panel();
            this.lunarLabel16 = new AntdUI.Label();
            this.dateLabel16 = new AntdUI.Label();
            this.holidayLabel16 = new AntdUI.Label();
            this.overtimeLabel16 = new AntdUI.Label();
            this.panel9 = new AntdUI.Panel();
            this.lunarLabel9 = new AntdUI.Label();
            this.dateLabel9 = new AntdUI.Label();
            this.holidayLabel9 = new AntdUI.Label();
            this.overtimeLabel9 = new AntdUI.Label();
            this.panel2 = new AntdUI.Panel();
            this.overtimeLabel2 = new AntdUI.Label();
            this.holidayLabel2 = new AntdUI.Label();
            this.lunarLabel2 = new AntdUI.Label();
            this.dateLabel2 = new AntdUI.Label();
            this.panel36 = new AntdUI.Panel();
            this.lunarLabel36 = new AntdUI.Label();
            this.dateLabel36 = new AntdUI.Label();
            this.holidayLabel36 = new AntdUI.Label();
            this.overtimeLabel36 = new AntdUI.Label();
            this.panel29 = new AntdUI.Panel();
            this.lunarLabel29 = new AntdUI.Label();
            this.dateLabel29 = new AntdUI.Label();
            this.holidayLabel29 = new AntdUI.Label();
            this.overtimeLabel29 = new AntdUI.Label();
            this.panel22 = new AntdUI.Panel();
            this.lunarLabel22 = new AntdUI.Label();
            this.dateLabel22 = new AntdUI.Label();
            this.holidayLabel22 = new AntdUI.Label();
            this.overtimeLabel22 = new AntdUI.Label();
            this.panel15 = new AntdUI.Panel();
            this.lunarLabel15 = new AntdUI.Label();
            this.dateLabel15 = new AntdUI.Label();
            this.holidayLabel15 = new AntdUI.Label();
            this.overtimeLabel15 = new AntdUI.Label();
            this.panel8 = new AntdUI.Panel();
            this.lunarLabel8 = new AntdUI.Label();
            this.dateLabel8 = new AntdUI.Label();
            this.holidayLabel8 = new AntdUI.Label();
            this.overtimeLabel8 = new AntdUI.Label();
            this.panel1 = new AntdUI.Panel();
            this.overtimeLabel1 = new AntdUI.Label();
            this.holidayLabel1 = new AntdUI.Label();
            this.dateLabel1 = new AntdUI.Label();
            this.lunarLabel1 = new AntdUI.Label();
            this.sunLabel = new AntdUI.Label();
            this.satLabel = new AntdUI.Label();
            this.friLabel = new AntdUI.Label();
            this.thurLabel = new AntdUI.Label();
            this.wedLabel = new AntdUI.Label();
            this.tuesLabel = new AntdUI.Label();
            this.monLabel = new AntdUI.Label();
            this.overtimeInput = new AntdUI.InputNumber();
            this.backgroundpanel.SuspendLayout();
            this.panel42.SuspendLayout();
            this.panel35.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel41.SuspendLayout();
            this.panel34.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel40.SuspendLayout();
            this.panel33.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel39.SuspendLayout();
            this.panel32.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel38.SuspendLayout();
            this.panel31.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel37.SuspendLayout();
            this.panel30.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel36.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // overtime
            // 
            this.overtime.AutoSize = true;
            this.overtime.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtime.Location = new System.Drawing.Point(22, 85);
            this.overtime.Name = "overtime";
            this.overtime.Size = new System.Drawing.Size(222, 21);
            this.overtime.TabIndex = 0;
            this.overtime.Text = "本月目前加了20.6小时";
            this.overtime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // needOvertimeLabel
            // 
            this.needOvertimeLabel.AutoSize = true;
            this.needOvertimeLabel.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.needOvertimeLabel.Location = new System.Drawing.Point(21, 51);
            this.needOvertimeLabel.Name = "needOvertimeLabel";
            this.needOvertimeLabel.Size = new System.Drawing.Size(403, 21);
            this.needOvertimeLabel.TabIndex = 11;
            this.needOvertimeLabel.Text = "本月共21个工作日，需要加10.5个补时 + ";
            // 
            // sumHoursLabel
            // 
            this.sumHoursLabel.AutoSize = true;
            this.sumHoursLabel.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sumHoursLabel.Location = new System.Drawing.Point(515, 51);
            this.sumHoursLabel.Name = "sumHoursLabel";
            this.sumHoursLabel.Size = new System.Drawing.Size(170, 21);
            this.sumHoursLabel.TabIndex = 15;
            this.sumHoursLabel.Text = "小时 = 30个小时";
            // 
            // windowBar1
            // 
            this.windowBar1.Font = new System.Drawing.Font("庞门正道粗书体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.windowBar1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.windowBar1.IsMax = false;
            this.windowBar1.Location = new System.Drawing.Point(12, -1);
            this.windowBar1.Name = "windowBar1";
            this.windowBar1.Size = new System.Drawing.Size(728, 40);
            this.windowBar1.TabIndex = 24;
            this.windowBar1.Text = "加班记录";
            // 
            // backgroundpanel
            // 
            this.backgroundpanel.Controls.Add(this.yearSelect);
            this.backgroundpanel.Controls.Add(this.monthSelect);
            this.backgroundpanel.Controls.Add(this.panel42);
            this.backgroundpanel.Controls.Add(this.panel35);
            this.backgroundpanel.Controls.Add(this.panel28);
            this.backgroundpanel.Controls.Add(this.panel21);
            this.backgroundpanel.Controls.Add(this.panel14);
            this.backgroundpanel.Controls.Add(this.panel7);
            this.backgroundpanel.Controls.Add(this.panel41);
            this.backgroundpanel.Controls.Add(this.panel34);
            this.backgroundpanel.Controls.Add(this.panel27);
            this.backgroundpanel.Controls.Add(this.panel20);
            this.backgroundpanel.Controls.Add(this.panel13);
            this.backgroundpanel.Controls.Add(this.panel6);
            this.backgroundpanel.Controls.Add(this.panel40);
            this.backgroundpanel.Controls.Add(this.panel33);
            this.backgroundpanel.Controls.Add(this.panel26);
            this.backgroundpanel.Controls.Add(this.panel19);
            this.backgroundpanel.Controls.Add(this.panel12);
            this.backgroundpanel.Controls.Add(this.panel5);
            this.backgroundpanel.Controls.Add(this.panel39);
            this.backgroundpanel.Controls.Add(this.panel32);
            this.backgroundpanel.Controls.Add(this.panel25);
            this.backgroundpanel.Controls.Add(this.panel18);
            this.backgroundpanel.Controls.Add(this.panel11);
            this.backgroundpanel.Controls.Add(this.panel4);
            this.backgroundpanel.Controls.Add(this.panel38);
            this.backgroundpanel.Controls.Add(this.panel31);
            this.backgroundpanel.Controls.Add(this.panel24);
            this.backgroundpanel.Controls.Add(this.panel17);
            this.backgroundpanel.Controls.Add(this.panel10);
            this.backgroundpanel.Controls.Add(this.panel3);
            this.backgroundpanel.Controls.Add(this.panel37);
            this.backgroundpanel.Controls.Add(this.panel30);
            this.backgroundpanel.Controls.Add(this.panel23);
            this.backgroundpanel.Controls.Add(this.panel16);
            this.backgroundpanel.Controls.Add(this.panel9);
            this.backgroundpanel.Controls.Add(this.panel2);
            this.backgroundpanel.Controls.Add(this.panel36);
            this.backgroundpanel.Controls.Add(this.panel29);
            this.backgroundpanel.Controls.Add(this.panel22);
            this.backgroundpanel.Controls.Add(this.panel15);
            this.backgroundpanel.Controls.Add(this.panel8);
            this.backgroundpanel.Controls.Add(this.panel1);
            this.backgroundpanel.Controls.Add(this.sunLabel);
            this.backgroundpanel.Controls.Add(this.satLabel);
            this.backgroundpanel.Controls.Add(this.friLabel);
            this.backgroundpanel.Controls.Add(this.thurLabel);
            this.backgroundpanel.Controls.Add(this.wedLabel);
            this.backgroundpanel.Controls.Add(this.tuesLabel);
            this.backgroundpanel.Controls.Add(this.monLabel);
            this.backgroundpanel.Location = new System.Drawing.Point(33, 142);
            this.backgroundpanel.Name = "backgroundpanel";
            this.backgroundpanel.Shadow = 5;
            this.backgroundpanel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(99)))), ((int)(((byte)(220)))));
            this.backgroundpanel.Size = new System.Drawing.Size(672, 702);
            this.backgroundpanel.TabIndex = 29;
            // 
            // yearSelect
            // 
            this.yearSelect.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yearSelect.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033"});
            this.yearSelect.Location = new System.Drawing.Point(393, 8);
            this.yearSelect.Name = "yearSelect";
            this.yearSelect.Size = new System.Drawing.Size(101, 53);
            this.yearSelect.TabIndex = 4;
            this.yearSelect.Text = "2024";
            this.yearSelect.SelectedValueChanged += new AntdUI.ObjectNEventHandler(this.yearOrmonth_SelectedValueChanged);
            // 
            // monthSelect
            // 
            this.monthSelect.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.monthSelect.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.monthSelect.Location = new System.Drawing.Point(521, 8);
            this.monthSelect.Name = "monthSelect";
            this.monthSelect.Size = new System.Drawing.Size(104, 53);
            this.monthSelect.TabIndex = 4;
            this.monthSelect.Text = "1";
            this.monthSelect.SelectedValueChanged += new AntdUI.ObjectNEventHandler(this.yearOrmonth_SelectedValueChanged);
            // 
            // panel42
            // 
            this.panel42.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel42.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel42.BorderWidth = 1F;
            this.panel42.Controls.Add(this.lunarLabel42);
            this.panel42.Controls.Add(this.dateLabel42);
            this.panel42.Controls.Add(this.holidayLabel42);
            this.panel42.Controls.Add(this.overtimeLabel42);
            this.panel42.Location = new System.Drawing.Point(567, 597);
            this.panel42.Name = "panel42";
            this.panel42.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel42.Size = new System.Drawing.Size(85, 89);
            this.panel42.TabIndex = 3;
            this.panel42.Text = "panel1";
            this.panel42.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel42.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel42.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel42
            // 
            this.lunarLabel42.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel42.Location = new System.Drawing.Point(4, 61);
            this.lunarLabel42.Name = "lunarLabel42";
            this.lunarLabel42.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel42.TabIndex = 1;
            this.lunarLabel42.Text = "十一月二八";
            // 
            // dateLabel42
            // 
            this.dateLabel42.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel42.Location = new System.Drawing.Point(32, 4);
            this.dateLabel42.Name = "dateLabel42";
            this.dateLabel42.Size = new System.Drawing.Size(26, 26);
            this.dateLabel42.TabIndex = 0;
            this.dateLabel42.Text = "30";
            this.dateLabel42.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel42
            // 
            this.holidayLabel42.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel42.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel42.Name = "holidayLabel42";
            this.holidayLabel42.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel42.TabIndex = 2;
            this.holidayLabel42.Text = "国庆节";
            // 
            // overtimeLabel42
            // 
            this.overtimeLabel42.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel42.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel42.Location = new System.Drawing.Point(4, 18);
            this.overtimeLabel42.Name = "overtimeLabel42";
            this.overtimeLabel42.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel42.TabIndex = 3;
            this.overtimeLabel42.Text = "3.5";
            // 
            // panel35
            // 
            this.panel35.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel35.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel35.BorderWidth = 1F;
            this.panel35.Controls.Add(this.lunarLabel35);
            this.panel35.Controls.Add(this.dateLabel35);
            this.panel35.Controls.Add(this.holidayLabel35);
            this.panel35.Controls.Add(this.overtimeLabel35);
            this.panel35.Location = new System.Drawing.Point(567, 502);
            this.panel35.Name = "panel35";
            this.panel35.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel35.Size = new System.Drawing.Size(85, 89);
            this.panel35.TabIndex = 3;
            this.panel35.Text = "panel1";
            this.panel35.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel35.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel35.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel35
            // 
            this.lunarLabel35.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel35.Location = new System.Drawing.Point(4, 61);
            this.lunarLabel35.Name = "lunarLabel35";
            this.lunarLabel35.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel35.TabIndex = 1;
            this.lunarLabel35.Text = "十一月二八";
            // 
            // dateLabel35
            // 
            this.dateLabel35.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel35.Location = new System.Drawing.Point(32, 4);
            this.dateLabel35.Name = "dateLabel35";
            this.dateLabel35.Size = new System.Drawing.Size(26, 26);
            this.dateLabel35.TabIndex = 0;
            this.dateLabel35.Text = "30";
            this.dateLabel35.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel35
            // 
            this.holidayLabel35.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel35.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel35.Name = "holidayLabel35";
            this.holidayLabel35.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel35.TabIndex = 2;
            this.holidayLabel35.Text = "国庆节";
            // 
            // overtimeLabel35
            // 
            this.overtimeLabel35.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel35.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel35.Location = new System.Drawing.Point(4, 19);
            this.overtimeLabel35.Name = "overtimeLabel35";
            this.overtimeLabel35.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel35.TabIndex = 3;
            this.overtimeLabel35.Text = "3.5";
            // 
            // panel28
            // 
            this.panel28.Back = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panel28.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel28.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel28.BorderWidth = 1F;
            this.panel28.Controls.Add(this.lunarLabel28);
            this.panel28.Controls.Add(this.dateLabel28);
            this.panel28.Controls.Add(this.holidayLabel28);
            this.panel28.Controls.Add(this.overtimeLabel28);
            this.panel28.Location = new System.Drawing.Point(567, 407);
            this.panel28.Name = "panel28";
            this.panel28.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel28.Size = new System.Drawing.Size(85, 89);
            this.panel28.TabIndex = 3;
            this.panel28.Text = "panel1";
            this.panel28.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel28.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel28.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel28
            // 
            this.lunarLabel28.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel28.Location = new System.Drawing.Point(4, 61);
            this.lunarLabel28.Name = "lunarLabel28";
            this.lunarLabel28.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel28.TabIndex = 1;
            this.lunarLabel28.Text = "十一月二八";
            // 
            // dateLabel28
            // 
            this.dateLabel28.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel28.Location = new System.Drawing.Point(32, 4);
            this.dateLabel28.Name = "dateLabel28";
            this.dateLabel28.Size = new System.Drawing.Size(26, 26);
            this.dateLabel28.TabIndex = 0;
            this.dateLabel28.Text = "30";
            this.dateLabel28.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel28
            // 
            this.holidayLabel28.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel28.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel28.Name = "holidayLabel28";
            this.holidayLabel28.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel28.TabIndex = 2;
            this.holidayLabel28.Text = "国庆节";
            // 
            // overtimeLabel28
            // 
            this.overtimeLabel28.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel28.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel28.Location = new System.Drawing.Point(4, 18);
            this.overtimeLabel28.Name = "overtimeLabel28";
            this.overtimeLabel28.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel28.TabIndex = 3;
            this.overtimeLabel28.Text = "3.5";
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel21.BorderWidth = 1F;
            this.panel21.Controls.Add(this.lunarLabel21);
            this.panel21.Controls.Add(this.dateLabel21);
            this.panel21.Controls.Add(this.holidayLabel21);
            this.panel21.Controls.Add(this.overtimeLabel21);
            this.panel21.Location = new System.Drawing.Point(567, 312);
            this.panel21.Name = "panel21";
            this.panel21.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel21.Size = new System.Drawing.Size(85, 89);
            this.panel21.TabIndex = 3;
            this.panel21.Text = "panel1";
            this.panel21.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel21.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel21.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel21
            // 
            this.lunarLabel21.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel21.Location = new System.Drawing.Point(4, 63);
            this.lunarLabel21.Name = "lunarLabel21";
            this.lunarLabel21.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel21.TabIndex = 1;
            this.lunarLabel21.Text = "十一月二八";
            // 
            // dateLabel21
            // 
            this.dateLabel21.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel21.Location = new System.Drawing.Point(32, 4);
            this.dateLabel21.Name = "dateLabel21";
            this.dateLabel21.Size = new System.Drawing.Size(26, 26);
            this.dateLabel21.TabIndex = 0;
            this.dateLabel21.Text = "30";
            this.dateLabel21.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel21
            // 
            this.holidayLabel21.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel21.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel21.Name = "holidayLabel21";
            this.holidayLabel21.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel21.TabIndex = 2;
            this.holidayLabel21.Text = "国庆节";
            // 
            // overtimeLabel21
            // 
            this.overtimeLabel21.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel21.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel21.Location = new System.Drawing.Point(4, 20);
            this.overtimeLabel21.Name = "overtimeLabel21";
            this.overtimeLabel21.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel21.TabIndex = 3;
            this.overtimeLabel21.Text = "3.5";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel14.BorderWidth = 1F;
            this.panel14.Controls.Add(this.lunarLabel14);
            this.panel14.Controls.Add(this.dateLabel14);
            this.panel14.Controls.Add(this.holidayLabel14);
            this.panel14.Controls.Add(this.overtimeLabel14);
            this.panel14.Location = new System.Drawing.Point(567, 217);
            this.panel14.Name = "panel14";
            this.panel14.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel14.Size = new System.Drawing.Size(85, 89);
            this.panel14.TabIndex = 3;
            this.panel14.Text = "panel1";
            this.panel14.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel14.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel14.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel14
            // 
            this.lunarLabel14.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel14.Location = new System.Drawing.Point(4, 61);
            this.lunarLabel14.Name = "lunarLabel14";
            this.lunarLabel14.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel14.TabIndex = 1;
            this.lunarLabel14.Text = "十一月二八";
            // 
            // dateLabel14
            // 
            this.dateLabel14.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateLabel14.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel14.Location = new System.Drawing.Point(32, 4);
            this.dateLabel14.Name = "dateLabel14";
            this.dateLabel14.Size = new System.Drawing.Size(26, 26);
            this.dateLabel14.TabIndex = 0;
            this.dateLabel14.Text = "30";
            this.dateLabel14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel14
            // 
            this.holidayLabel14.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel14.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel14.Name = "holidayLabel14";
            this.holidayLabel14.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel14.TabIndex = 2;
            this.holidayLabel14.Text = "国庆节";
            // 
            // overtimeLabel14
            // 
            this.overtimeLabel14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel14.Location = new System.Drawing.Point(4, 14);
            this.overtimeLabel14.Name = "overtimeLabel14";
            this.overtimeLabel14.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel14.TabIndex = 3;
            this.overtimeLabel14.Text = "3.5";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(235)))), ((int)(((byte)(87)))));
            this.panel7.BorderWidth = 1F;
            this.panel7.Controls.Add(this.lunarLabel7);
            this.panel7.Controls.Add(this.dateLabel7);
            this.panel7.Controls.Add(this.holidayLabel7);
            this.panel7.Controls.Add(this.overtimeLabel7);
            this.panel7.Location = new System.Drawing.Point(567, 122);
            this.panel7.Name = "panel7";
            this.panel7.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel7.Size = new System.Drawing.Size(85, 89);
            this.panel7.TabIndex = 3;
            this.panel7.Text = "panel1";
            this.panel7.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel7.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel7.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel7
            // 
            this.lunarLabel7.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel7.Location = new System.Drawing.Point(4, 61);
            this.lunarLabel7.Name = "lunarLabel7";
            this.lunarLabel7.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel7.TabIndex = 1;
            this.lunarLabel7.Text = "十一月二八";
            // 
            // dateLabel7
            // 
            this.dateLabel7.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel7.Location = new System.Drawing.Point(32, 4);
            this.dateLabel7.Name = "dateLabel7";
            this.dateLabel7.Size = new System.Drawing.Size(26, 26);
            this.dateLabel7.TabIndex = 0;
            this.dateLabel7.Text = "30";
            this.dateLabel7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel7
            // 
            this.holidayLabel7.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel7.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel7.Name = "holidayLabel7";
            this.holidayLabel7.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel7.TabIndex = 2;
            this.holidayLabel7.Text = "国庆节";
            // 
            // overtimeLabel7
            // 
            this.overtimeLabel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel7.Location = new System.Drawing.Point(4, 14);
            this.overtimeLabel7.Name = "overtimeLabel7";
            this.overtimeLabel7.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel7.TabIndex = 3;
            this.overtimeLabel7.Text = "3.5";
            // 
            // panel41
            // 
            this.panel41.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel41.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel41.BorderWidth = 1F;
            this.panel41.Controls.Add(this.lunarLabel41);
            this.panel41.Controls.Add(this.dateLabel41);
            this.panel41.Controls.Add(this.holidayLabel41);
            this.panel41.Controls.Add(this.overtimeLabel41);
            this.panel41.Location = new System.Drawing.Point(476, 597);
            this.panel41.Name = "panel41";
            this.panel41.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel41.Size = new System.Drawing.Size(85, 89);
            this.panel41.TabIndex = 3;
            this.panel41.Text = "panel1";
            this.panel41.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel41.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel41.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel41
            // 
            this.lunarLabel41.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel41.Location = new System.Drawing.Point(3, 61);
            this.lunarLabel41.Name = "lunarLabel41";
            this.lunarLabel41.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel41.TabIndex = 1;
            this.lunarLabel41.Text = "十一月二八";
            // 
            // dateLabel41
            // 
            this.dateLabel41.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel41.Location = new System.Drawing.Point(32, 4);
            this.dateLabel41.Name = "dateLabel41";
            this.dateLabel41.Size = new System.Drawing.Size(26, 26);
            this.dateLabel41.TabIndex = 0;
            this.dateLabel41.Text = "30";
            this.dateLabel41.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel41
            // 
            this.holidayLabel41.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel41.Location = new System.Drawing.Point(3, 41);
            this.holidayLabel41.Name = "holidayLabel41";
            this.holidayLabel41.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel41.TabIndex = 2;
            this.holidayLabel41.Text = "国庆节";
            // 
            // overtimeLabel41
            // 
            this.overtimeLabel41.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel41.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel41.Location = new System.Drawing.Point(4, 18);
            this.overtimeLabel41.Name = "overtimeLabel41";
            this.overtimeLabel41.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel41.TabIndex = 3;
            this.overtimeLabel41.Text = "3.5";
            // 
            // panel34
            // 
            this.panel34.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel34.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel34.BorderWidth = 1F;
            this.panel34.Controls.Add(this.lunarLabel34);
            this.panel34.Controls.Add(this.dateLabel34);
            this.panel34.Controls.Add(this.holidayLabel34);
            this.panel34.Controls.Add(this.overtimeLabel34);
            this.panel34.Location = new System.Drawing.Point(476, 502);
            this.panel34.Name = "panel34";
            this.panel34.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel34.Size = new System.Drawing.Size(85, 89);
            this.panel34.TabIndex = 3;
            this.panel34.Text = "panel1";
            this.panel34.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel34.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel34.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel34
            // 
            this.lunarLabel34.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel34.Location = new System.Drawing.Point(4, 61);
            this.lunarLabel34.Name = "lunarLabel34";
            this.lunarLabel34.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel34.TabIndex = 1;
            this.lunarLabel34.Text = "十一月二八";
            // 
            // dateLabel34
            // 
            this.dateLabel34.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel34.Location = new System.Drawing.Point(32, 4);
            this.dateLabel34.Name = "dateLabel34";
            this.dateLabel34.Size = new System.Drawing.Size(26, 26);
            this.dateLabel34.TabIndex = 0;
            this.dateLabel34.Text = "30";
            this.dateLabel34.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel34
            // 
            this.holidayLabel34.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel34.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel34.Name = "holidayLabel34";
            this.holidayLabel34.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel34.TabIndex = 2;
            this.holidayLabel34.Text = "国庆节";
            // 
            // overtimeLabel34
            // 
            this.overtimeLabel34.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel34.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel34.Location = new System.Drawing.Point(4, 19);
            this.overtimeLabel34.Name = "overtimeLabel34";
            this.overtimeLabel34.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel34.TabIndex = 3;
            this.overtimeLabel34.Text = "3.5";
            // 
            // panel27
            // 
            this.panel27.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel27.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel27.BorderWidth = 1F;
            this.panel27.Controls.Add(this.lunarLabel27);
            this.panel27.Controls.Add(this.dateLabel27);
            this.panel27.Controls.Add(this.holidayLabel27);
            this.panel27.Controls.Add(this.overtimeLabel27);
            this.panel27.Location = new System.Drawing.Point(476, 407);
            this.panel27.Name = "panel27";
            this.panel27.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel27.Size = new System.Drawing.Size(85, 89);
            this.panel27.TabIndex = 3;
            this.panel27.Text = "panel1";
            this.panel27.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel27.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel27.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel27
            // 
            this.lunarLabel27.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel27.Location = new System.Drawing.Point(4, 61);
            this.lunarLabel27.Name = "lunarLabel27";
            this.lunarLabel27.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel27.TabIndex = 1;
            this.lunarLabel27.Text = "十一月二八";
            // 
            // dateLabel27
            // 
            this.dateLabel27.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel27.Location = new System.Drawing.Point(32, 4);
            this.dateLabel27.Name = "dateLabel27";
            this.dateLabel27.Size = new System.Drawing.Size(26, 26);
            this.dateLabel27.TabIndex = 0;
            this.dateLabel27.Text = "30";
            this.dateLabel27.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel27
            // 
            this.holidayLabel27.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel27.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel27.Name = "holidayLabel27";
            this.holidayLabel27.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel27.TabIndex = 2;
            this.holidayLabel27.Text = "国庆节";
            // 
            // overtimeLabel27
            // 
            this.overtimeLabel27.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel27.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel27.Location = new System.Drawing.Point(4, 18);
            this.overtimeLabel27.Name = "overtimeLabel27";
            this.overtimeLabel27.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel27.TabIndex = 3;
            this.overtimeLabel27.Text = "3.5";
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel20.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel20.BorderWidth = 1F;
            this.panel20.Controls.Add(this.lunarLabel20);
            this.panel20.Controls.Add(this.dateLabel20);
            this.panel20.Controls.Add(this.holidayLabel20);
            this.panel20.Controls.Add(this.overtimeLabel20);
            this.panel20.Location = new System.Drawing.Point(476, 312);
            this.panel20.Name = "panel20";
            this.panel20.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel20.Size = new System.Drawing.Size(85, 89);
            this.panel20.TabIndex = 3;
            this.panel20.Text = "panel1";
            this.panel20.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel20.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel20.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel20
            // 
            this.lunarLabel20.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel20.Location = new System.Drawing.Point(4, 63);
            this.lunarLabel20.Name = "lunarLabel20";
            this.lunarLabel20.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel20.TabIndex = 1;
            this.lunarLabel20.Text = "十一月二八";
            // 
            // dateLabel20
            // 
            this.dateLabel20.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel20.Location = new System.Drawing.Point(32, 4);
            this.dateLabel20.Name = "dateLabel20";
            this.dateLabel20.Size = new System.Drawing.Size(26, 26);
            this.dateLabel20.TabIndex = 0;
            this.dateLabel20.Text = "30";
            this.dateLabel20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel20
            // 
            this.holidayLabel20.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel20.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel20.Name = "holidayLabel20";
            this.holidayLabel20.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel20.TabIndex = 2;
            this.holidayLabel20.Text = "国庆节";
            // 
            // overtimeLabel20
            // 
            this.overtimeLabel20.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel20.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel20.Location = new System.Drawing.Point(4, 20);
            this.overtimeLabel20.Name = "overtimeLabel20";
            this.overtimeLabel20.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel20.TabIndex = 3;
            this.overtimeLabel20.Text = "3.5";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel13.BorderWidth = 1F;
            this.panel13.Controls.Add(this.lunarLabel13);
            this.panel13.Controls.Add(this.dateLabel13);
            this.panel13.Controls.Add(this.holidayLabel13);
            this.panel13.Controls.Add(this.overtimeLabel13);
            this.panel13.Location = new System.Drawing.Point(476, 217);
            this.panel13.Name = "panel13";
            this.panel13.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel13.Size = new System.Drawing.Size(85, 89);
            this.panel13.TabIndex = 3;
            this.panel13.Text = "panel1";
            this.panel13.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel13.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel13.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel13
            // 
            this.lunarLabel13.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel13.Location = new System.Drawing.Point(4, 61);
            this.lunarLabel13.Name = "lunarLabel13";
            this.lunarLabel13.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel13.TabIndex = 1;
            this.lunarLabel13.Text = "十一月二八";
            // 
            // dateLabel13
            // 
            this.dateLabel13.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel13.Location = new System.Drawing.Point(32, 4);
            this.dateLabel13.Name = "dateLabel13";
            this.dateLabel13.Size = new System.Drawing.Size(26, 26);
            this.dateLabel13.TabIndex = 0;
            this.dateLabel13.Text = "30";
            this.dateLabel13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel13
            // 
            this.holidayLabel13.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel13.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel13.Name = "holidayLabel13";
            this.holidayLabel13.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel13.TabIndex = 2;
            this.holidayLabel13.Text = "国庆节";
            // 
            // overtimeLabel13
            // 
            this.overtimeLabel13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel13.Location = new System.Drawing.Point(4, 14);
            this.overtimeLabel13.Name = "overtimeLabel13";
            this.overtimeLabel13.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel13.TabIndex = 3;
            this.overtimeLabel13.Text = "3.5";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(235)))), ((int)(((byte)(87)))));
            this.panel6.BorderWidth = 1F;
            this.panel6.Controls.Add(this.lunarLabel6);
            this.panel6.Controls.Add(this.dateLabel6);
            this.panel6.Controls.Add(this.holidayLabel6);
            this.panel6.Controls.Add(this.overtimeLabel6);
            this.panel6.Location = new System.Drawing.Point(476, 122);
            this.panel6.Name = "panel6";
            this.panel6.padding = new System.Windows.Forms.Padding(1);
            this.panel6.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel6.Size = new System.Drawing.Size(85, 89);
            this.panel6.TabIndex = 3;
            this.panel6.Text = "panel1";
            this.panel6.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel6.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel6.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel6
            // 
            this.lunarLabel6.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel6.Location = new System.Drawing.Point(4, 61);
            this.lunarLabel6.Name = "lunarLabel6";
            this.lunarLabel6.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel6.TabIndex = 1;
            this.lunarLabel6.Text = "十一月二八";
            // 
            // dateLabel6
            // 
            this.dateLabel6.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dateLabel6.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel6.Location = new System.Drawing.Point(32, 4);
            this.dateLabel6.Name = "dateLabel6";
            this.dateLabel6.Size = new System.Drawing.Size(26, 26);
            this.dateLabel6.TabIndex = 0;
            this.dateLabel6.Text = "30";
            this.dateLabel6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel6
            // 
            this.holidayLabel6.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel6.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel6.Name = "holidayLabel6";
            this.holidayLabel6.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel6.TabIndex = 2;
            this.holidayLabel6.Text = "国庆节";
            // 
            // overtimeLabel6
            // 
            this.overtimeLabel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel6.Location = new System.Drawing.Point(4, 14);
            this.overtimeLabel6.Name = "overtimeLabel6";
            this.overtimeLabel6.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel6.TabIndex = 3;
            this.overtimeLabel6.Text = "3.5";
            // 
            // panel40
            // 
            this.panel40.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel40.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel40.BorderWidth = 1F;
            this.panel40.Controls.Add(this.lunarLabel40);
            this.panel40.Controls.Add(this.dateLabel40);
            this.panel40.Controls.Add(this.holidayLabel40);
            this.panel40.Controls.Add(this.overtimeLabel40);
            this.panel40.Location = new System.Drawing.Point(385, 597);
            this.panel40.Name = "panel40";
            this.panel40.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel40.Size = new System.Drawing.Size(85, 89);
            this.panel40.TabIndex = 3;
            this.panel40.Text = "panel1";
            this.panel40.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel40.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel40.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel40
            // 
            this.lunarLabel40.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel40.Location = new System.Drawing.Point(4, 63);
            this.lunarLabel40.Name = "lunarLabel40";
            this.lunarLabel40.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel40.TabIndex = 1;
            this.lunarLabel40.Text = "十一月二八";
            // 
            // dateLabel40
            // 
            this.dateLabel40.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel40.Location = new System.Drawing.Point(32, 4);
            this.dateLabel40.Name = "dateLabel40";
            this.dateLabel40.Size = new System.Drawing.Size(26, 26);
            this.dateLabel40.TabIndex = 0;
            this.dateLabel40.Text = "30";
            this.dateLabel40.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel40
            // 
            this.holidayLabel40.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel40.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel40.Name = "holidayLabel40";
            this.holidayLabel40.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel40.TabIndex = 2;
            this.holidayLabel40.Text = "国庆节";
            // 
            // overtimeLabel40
            // 
            this.overtimeLabel40.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel40.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel40.Location = new System.Drawing.Point(4, 18);
            this.overtimeLabel40.Name = "overtimeLabel40";
            this.overtimeLabel40.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel40.TabIndex = 3;
            this.overtimeLabel40.Text = "3.5";
            // 
            // panel33
            // 
            this.panel33.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel33.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel33.BorderWidth = 1F;
            this.panel33.Controls.Add(this.lunarLabel33);
            this.panel33.Controls.Add(this.dateLabel33);
            this.panel33.Controls.Add(this.holidayLabel33);
            this.panel33.Controls.Add(this.overtimeLabel33);
            this.panel33.Location = new System.Drawing.Point(385, 502);
            this.panel33.Name = "panel33";
            this.panel33.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel33.Size = new System.Drawing.Size(85, 89);
            this.panel33.TabIndex = 3;
            this.panel33.Text = "panel1";
            this.panel33.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel33.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel33.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel33
            // 
            this.lunarLabel33.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel33.Location = new System.Drawing.Point(4, 63);
            this.lunarLabel33.Name = "lunarLabel33";
            this.lunarLabel33.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel33.TabIndex = 1;
            this.lunarLabel33.Text = "十一月二八";
            // 
            // dateLabel33
            // 
            this.dateLabel33.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel33.Location = new System.Drawing.Point(32, 4);
            this.dateLabel33.Name = "dateLabel33";
            this.dateLabel33.Size = new System.Drawing.Size(26, 26);
            this.dateLabel33.TabIndex = 0;
            this.dateLabel33.Text = "30";
            this.dateLabel33.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel33
            // 
            this.holidayLabel33.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel33.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel33.Name = "holidayLabel33";
            this.holidayLabel33.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel33.TabIndex = 2;
            this.holidayLabel33.Text = "国庆节";
            // 
            // overtimeLabel33
            // 
            this.overtimeLabel33.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel33.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel33.Location = new System.Drawing.Point(4, 19);
            this.overtimeLabel33.Name = "overtimeLabel33";
            this.overtimeLabel33.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel33.TabIndex = 3;
            this.overtimeLabel33.Text = "3.5";
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel26.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel26.BorderWidth = 1F;
            this.panel26.Controls.Add(this.lunarLabel26);
            this.panel26.Controls.Add(this.dateLabel26);
            this.panel26.Controls.Add(this.holidayLabel26);
            this.panel26.Controls.Add(this.overtimeLabel26);
            this.panel26.Location = new System.Drawing.Point(385, 407);
            this.panel26.Name = "panel26";
            this.panel26.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel26.Size = new System.Drawing.Size(85, 89);
            this.panel26.TabIndex = 3;
            this.panel26.Text = "panel1";
            this.panel26.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel26.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel26.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel26
            // 
            this.lunarLabel26.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel26.Location = new System.Drawing.Point(4, 63);
            this.lunarLabel26.Name = "lunarLabel26";
            this.lunarLabel26.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel26.TabIndex = 1;
            this.lunarLabel26.Text = "十一月二八";
            // 
            // dateLabel26
            // 
            this.dateLabel26.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel26.Location = new System.Drawing.Point(32, 4);
            this.dateLabel26.Name = "dateLabel26";
            this.dateLabel26.Size = new System.Drawing.Size(26, 26);
            this.dateLabel26.TabIndex = 0;
            this.dateLabel26.Text = "30";
            this.dateLabel26.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel26
            // 
            this.holidayLabel26.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel26.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel26.Name = "holidayLabel26";
            this.holidayLabel26.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel26.TabIndex = 2;
            this.holidayLabel26.Text = "国庆节";
            // 
            // overtimeLabel26
            // 
            this.overtimeLabel26.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel26.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel26.Location = new System.Drawing.Point(4, 18);
            this.overtimeLabel26.Name = "overtimeLabel26";
            this.overtimeLabel26.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel26.TabIndex = 3;
            this.overtimeLabel26.Text = "3.5";
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel19.BorderWidth = 1F;
            this.panel19.Controls.Add(this.lunarLabel19);
            this.panel19.Controls.Add(this.dateLabel19);
            this.panel19.Controls.Add(this.holidayLabel19);
            this.panel19.Controls.Add(this.overtimeLabel19);
            this.panel19.Location = new System.Drawing.Point(385, 312);
            this.panel19.Name = "panel19";
            this.panel19.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel19.Size = new System.Drawing.Size(85, 89);
            this.panel19.TabIndex = 3;
            this.panel19.Text = "panel1";
            this.panel19.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel19.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel19.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel19
            // 
            this.lunarLabel19.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel19.Location = new System.Drawing.Point(4, 63);
            this.lunarLabel19.Name = "lunarLabel19";
            this.lunarLabel19.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel19.TabIndex = 1;
            this.lunarLabel19.Text = "十一月二八";
            // 
            // dateLabel19
            // 
            this.dateLabel19.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel19.Location = new System.Drawing.Point(32, 4);
            this.dateLabel19.Name = "dateLabel19";
            this.dateLabel19.Size = new System.Drawing.Size(26, 26);
            this.dateLabel19.TabIndex = 0;
            this.dateLabel19.Text = "30";
            this.dateLabel19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel19
            // 
            this.holidayLabel19.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel19.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel19.Name = "holidayLabel19";
            this.holidayLabel19.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel19.TabIndex = 2;
            this.holidayLabel19.Text = "国庆节";
            // 
            // overtimeLabel19
            // 
            this.overtimeLabel19.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel19.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel19.Location = new System.Drawing.Point(4, 20);
            this.overtimeLabel19.Name = "overtimeLabel19";
            this.overtimeLabel19.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel19.TabIndex = 3;
            this.overtimeLabel19.Text = "3.5";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel12.BorderWidth = 1F;
            this.panel12.Controls.Add(this.lunarLabel12);
            this.panel12.Controls.Add(this.dateLabel12);
            this.panel12.Controls.Add(this.holidayLabel12);
            this.panel12.Controls.Add(this.overtimeLabel12);
            this.panel12.Location = new System.Drawing.Point(385, 217);
            this.panel12.Name = "panel12";
            this.panel12.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel12.Size = new System.Drawing.Size(85, 89);
            this.panel12.TabIndex = 3;
            this.panel12.Text = "panel1";
            this.panel12.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel12.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel12.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel12
            // 
            this.lunarLabel12.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel12.Location = new System.Drawing.Point(4, 61);
            this.lunarLabel12.Name = "lunarLabel12";
            this.lunarLabel12.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel12.TabIndex = 1;
            this.lunarLabel12.Text = "十一月二八";
            // 
            // dateLabel12
            // 
            this.dateLabel12.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel12.Location = new System.Drawing.Point(32, 4);
            this.dateLabel12.Name = "dateLabel12";
            this.dateLabel12.Size = new System.Drawing.Size(26, 26);
            this.dateLabel12.TabIndex = 0;
            this.dateLabel12.Text = "30";
            this.dateLabel12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel12
            // 
            this.holidayLabel12.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel12.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel12.Name = "holidayLabel12";
            this.holidayLabel12.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel12.TabIndex = 2;
            this.holidayLabel12.Text = "国庆节";
            // 
            // overtimeLabel12
            // 
            this.overtimeLabel12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel12.Location = new System.Drawing.Point(4, 14);
            this.overtimeLabel12.Name = "overtimeLabel12";
            this.overtimeLabel12.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel12.TabIndex = 3;
            this.overtimeLabel12.Text = "3.5";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel5.BorderWidth = 1F;
            this.panel5.Controls.Add(this.lunarLabel5);
            this.panel5.Controls.Add(this.dateLabel5);
            this.panel5.Controls.Add(this.holidayLabel5);
            this.panel5.Controls.Add(this.overtimeLabel5);
            this.panel5.Location = new System.Drawing.Point(385, 122);
            this.panel5.Name = "panel5";
            this.panel5.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Size = new System.Drawing.Size(85, 89);
            this.panel5.TabIndex = 3;
            this.panel5.Text = "panel1";
            this.panel5.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel5.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel5.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel5
            // 
            this.lunarLabel5.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel5.Location = new System.Drawing.Point(4, 61);
            this.lunarLabel5.Name = "lunarLabel5";
            this.lunarLabel5.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel5.TabIndex = 1;
            this.lunarLabel5.Text = "十一月二八";
            // 
            // dateLabel5
            // 
            this.dateLabel5.Enabled = false;
            this.dateLabel5.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel5.Location = new System.Drawing.Point(32, 4);
            this.dateLabel5.Name = "dateLabel5";
            this.dateLabel5.Size = new System.Drawing.Size(26, 26);
            this.dateLabel5.TabIndex = 0;
            this.dateLabel5.Text = "30";
            this.dateLabel5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel5
            // 
            this.holidayLabel5.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel5.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel5.Name = "holidayLabel5";
            this.holidayLabel5.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel5.TabIndex = 2;
            this.holidayLabel5.Text = "国庆节";
            // 
            // overtimeLabel5
            // 
            this.overtimeLabel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel5.Enabled = false;
            this.overtimeLabel5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel5.Location = new System.Drawing.Point(4, 14);
            this.overtimeLabel5.Name = "overtimeLabel5";
            this.overtimeLabel5.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel5.TabIndex = 3;
            this.overtimeLabel5.Text = "3.5";
            // 
            // panel39
            // 
            this.panel39.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel39.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel39.BorderWidth = 1F;
            this.panel39.Controls.Add(this.lunarLabel39);
            this.panel39.Controls.Add(this.dateLabel39);
            this.panel39.Controls.Add(this.holidayLabel39);
            this.panel39.Controls.Add(this.overtimeLabel39);
            this.panel39.Location = new System.Drawing.Point(294, 597);
            this.panel39.Name = "panel39";
            this.panel39.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel39.Size = new System.Drawing.Size(85, 89);
            this.panel39.TabIndex = 3;
            this.panel39.Text = "panel1";
            this.panel39.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel39.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel39.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel39
            // 
            this.lunarLabel39.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel39.Location = new System.Drawing.Point(4, 61);
            this.lunarLabel39.Name = "lunarLabel39";
            this.lunarLabel39.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel39.TabIndex = 1;
            this.lunarLabel39.Text = "十一月二八";
            // 
            // dateLabel39
            // 
            this.dateLabel39.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel39.Location = new System.Drawing.Point(32, 4);
            this.dateLabel39.Name = "dateLabel39";
            this.dateLabel39.Size = new System.Drawing.Size(26, 26);
            this.dateLabel39.TabIndex = 0;
            this.dateLabel39.Text = "30";
            this.dateLabel39.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel39
            // 
            this.holidayLabel39.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel39.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel39.Name = "holidayLabel39";
            this.holidayLabel39.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel39.TabIndex = 2;
            this.holidayLabel39.Text = "国庆节";
            // 
            // overtimeLabel39
            // 
            this.overtimeLabel39.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel39.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel39.Location = new System.Drawing.Point(4, 18);
            this.overtimeLabel39.Name = "overtimeLabel39";
            this.overtimeLabel39.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel39.TabIndex = 3;
            this.overtimeLabel39.Text = "3.5";
            // 
            // panel32
            // 
            this.panel32.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel32.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel32.BorderWidth = 1F;
            this.panel32.Controls.Add(this.lunarLabel32);
            this.panel32.Controls.Add(this.dateLabel32);
            this.panel32.Controls.Add(this.holidayLabel32);
            this.panel32.Controls.Add(this.overtimeLabel32);
            this.panel32.Location = new System.Drawing.Point(294, 502);
            this.panel32.Name = "panel32";
            this.panel32.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel32.Size = new System.Drawing.Size(85, 89);
            this.panel32.TabIndex = 3;
            this.panel32.Text = "panel1";
            this.panel32.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel32.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel32.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel32
            // 
            this.lunarLabel32.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel32.Location = new System.Drawing.Point(4, 63);
            this.lunarLabel32.Name = "lunarLabel32";
            this.lunarLabel32.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel32.TabIndex = 1;
            this.lunarLabel32.Text = "十一月二八";
            // 
            // dateLabel32
            // 
            this.dateLabel32.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel32.Location = new System.Drawing.Point(32, 4);
            this.dateLabel32.Name = "dateLabel32";
            this.dateLabel32.Size = new System.Drawing.Size(26, 26);
            this.dateLabel32.TabIndex = 0;
            this.dateLabel32.Text = "30";
            this.dateLabel32.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel32
            // 
            this.holidayLabel32.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel32.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel32.Name = "holidayLabel32";
            this.holidayLabel32.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel32.TabIndex = 2;
            this.holidayLabel32.Text = "国庆节";
            // 
            // overtimeLabel32
            // 
            this.overtimeLabel32.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel32.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel32.Location = new System.Drawing.Point(5, 19);
            this.overtimeLabel32.Name = "overtimeLabel32";
            this.overtimeLabel32.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel32.TabIndex = 3;
            this.overtimeLabel32.Text = "3.5";
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel25.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel25.BorderWidth = 1F;
            this.panel25.Controls.Add(this.lunarLabel25);
            this.panel25.Controls.Add(this.dateLabel25);
            this.panel25.Controls.Add(this.holidayLabel25);
            this.panel25.Controls.Add(this.overtimeLabel25);
            this.panel25.Location = new System.Drawing.Point(294, 407);
            this.panel25.Name = "panel25";
            this.panel25.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel25.Size = new System.Drawing.Size(85, 89);
            this.panel25.TabIndex = 3;
            this.panel25.Text = "panel1";
            this.panel25.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel25.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel25.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel25
            // 
            this.lunarLabel25.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel25.Location = new System.Drawing.Point(5, 63);
            this.lunarLabel25.Name = "lunarLabel25";
            this.lunarLabel25.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel25.TabIndex = 1;
            this.lunarLabel25.Text = "十一月二八";
            // 
            // dateLabel25
            // 
            this.dateLabel25.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel25.Location = new System.Drawing.Point(32, 4);
            this.dateLabel25.Name = "dateLabel25";
            this.dateLabel25.Size = new System.Drawing.Size(26, 26);
            this.dateLabel25.TabIndex = 0;
            this.dateLabel25.Text = "30";
            this.dateLabel25.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel25
            // 
            this.holidayLabel25.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel25.Location = new System.Drawing.Point(5, 41);
            this.holidayLabel25.Name = "holidayLabel25";
            this.holidayLabel25.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel25.TabIndex = 2;
            this.holidayLabel25.Text = "国庆节";
            // 
            // overtimeLabel25
            // 
            this.overtimeLabel25.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel25.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel25.Location = new System.Drawing.Point(5, 18);
            this.overtimeLabel25.Name = "overtimeLabel25";
            this.overtimeLabel25.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel25.TabIndex = 3;
            this.overtimeLabel25.Text = "3.5";
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel18.BorderWidth = 1F;
            this.panel18.Controls.Add(this.lunarLabel18);
            this.panel18.Controls.Add(this.dateLabel18);
            this.panel18.Controls.Add(this.holidayLabel18);
            this.panel18.Controls.Add(this.overtimeLabel18);
            this.panel18.Location = new System.Drawing.Point(294, 312);
            this.panel18.Name = "panel18";
            this.panel18.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel18.Size = new System.Drawing.Size(85, 89);
            this.panel18.TabIndex = 3;
            this.panel18.Text = "panel1";
            this.panel18.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel18.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel18.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel18
            // 
            this.lunarLabel18.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel18.Location = new System.Drawing.Point(4, 63);
            this.lunarLabel18.Name = "lunarLabel18";
            this.lunarLabel18.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel18.TabIndex = 1;
            this.lunarLabel18.Text = "十一月二八";
            // 
            // dateLabel18
            // 
            this.dateLabel18.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel18.Location = new System.Drawing.Point(32, 4);
            this.dateLabel18.Name = "dateLabel18";
            this.dateLabel18.Size = new System.Drawing.Size(26, 26);
            this.dateLabel18.TabIndex = 0;
            this.dateLabel18.Text = "30";
            this.dateLabel18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel18
            // 
            this.holidayLabel18.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel18.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel18.Name = "holidayLabel18";
            this.holidayLabel18.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel18.TabIndex = 2;
            this.holidayLabel18.Text = "国庆节";
            // 
            // overtimeLabel18
            // 
            this.overtimeLabel18.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel18.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel18.Location = new System.Drawing.Point(5, 20);
            this.overtimeLabel18.Name = "overtimeLabel18";
            this.overtimeLabel18.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel18.TabIndex = 3;
            this.overtimeLabel18.Text = "3.5";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel11.BorderWidth = 1F;
            this.panel11.Controls.Add(this.lunarLabel11);
            this.panel11.Controls.Add(this.dateLabel11);
            this.panel11.Controls.Add(this.holidayLabel11);
            this.panel11.Controls.Add(this.overtimeLabel11);
            this.panel11.Location = new System.Drawing.Point(294, 217);
            this.panel11.Name = "panel11";
            this.panel11.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel11.Size = new System.Drawing.Size(85, 89);
            this.panel11.TabIndex = 3;
            this.panel11.Text = "panel1";
            this.panel11.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel11.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel11.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel11
            // 
            this.lunarLabel11.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel11.Location = new System.Drawing.Point(4, 61);
            this.lunarLabel11.Name = "lunarLabel11";
            this.lunarLabel11.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel11.TabIndex = 1;
            this.lunarLabel11.Text = "十一月二八";
            // 
            // dateLabel11
            // 
            this.dateLabel11.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel11.Location = new System.Drawing.Point(32, 4);
            this.dateLabel11.Name = "dateLabel11";
            this.dateLabel11.Size = new System.Drawing.Size(26, 26);
            this.dateLabel11.TabIndex = 0;
            this.dateLabel11.Text = "30";
            this.dateLabel11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel11
            // 
            this.holidayLabel11.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel11.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel11.Name = "holidayLabel11";
            this.holidayLabel11.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel11.TabIndex = 2;
            this.holidayLabel11.Text = "国庆节";
            // 
            // overtimeLabel11
            // 
            this.overtimeLabel11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel11.Location = new System.Drawing.Point(4, 14);
            this.overtimeLabel11.Name = "overtimeLabel11";
            this.overtimeLabel11.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel11.TabIndex = 3;
            this.overtimeLabel11.Text = "3.5";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BadgeSize = 1F;
            this.panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel4.BorderWidth = 1F;
            this.panel4.Controls.Add(this.lunarLabel4);
            this.panel4.Controls.Add(this.dateLabel4);
            this.panel4.Controls.Add(this.holidayLabel4);
            this.panel4.Controls.Add(this.overtimeLabel4);
            this.panel4.Location = new System.Drawing.Point(294, 122);
            this.panel4.Name = "panel4";
            this.panel4.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Size = new System.Drawing.Size(85, 89);
            this.panel4.TabIndex = 3;
            this.panel4.Text = "panel1";
            this.panel4.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel4.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel4.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel4
            // 
            this.lunarLabel4.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel4.Location = new System.Drawing.Point(4, 61);
            this.lunarLabel4.Name = "lunarLabel4";
            this.lunarLabel4.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel4.TabIndex = 1;
            this.lunarLabel4.Text = "十一月二八";
            // 
            // dateLabel4
            // 
            this.dateLabel4.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel4.Location = new System.Drawing.Point(37, 4);
            this.dateLabel4.Name = "dateLabel4";
            this.dateLabel4.Size = new System.Drawing.Size(21, 15);
            this.dateLabel4.TabIndex = 0;
            this.dateLabel4.Text = "30";
            this.dateLabel4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel4
            // 
            this.holidayLabel4.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel4.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel4.Name = "holidayLabel4";
            this.holidayLabel4.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel4.TabIndex = 2;
            this.holidayLabel4.Text = "国庆节";
            // 
            // overtimeLabel4
            // 
            this.overtimeLabel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel4.Location = new System.Drawing.Point(4, 14);
            this.overtimeLabel4.Name = "overtimeLabel4";
            this.overtimeLabel4.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel4.TabIndex = 3;
            this.overtimeLabel4.Text = "3.5";
            // 
            // panel38
            // 
            this.panel38.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel38.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel38.BorderWidth = 1F;
            this.panel38.Controls.Add(this.lunarLabel38);
            this.panel38.Controls.Add(this.dateLabel38);
            this.panel38.Controls.Add(this.holidayLabel38);
            this.panel38.Controls.Add(this.overtimeLabel38);
            this.panel38.Location = new System.Drawing.Point(203, 597);
            this.panel38.Name = "panel38";
            this.panel38.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel38.Size = new System.Drawing.Size(85, 89);
            this.panel38.TabIndex = 3;
            this.panel38.Text = "panel1";
            this.panel38.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel38.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel38.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel38
            // 
            this.lunarLabel38.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel38.Location = new System.Drawing.Point(4, 61);
            this.lunarLabel38.Name = "lunarLabel38";
            this.lunarLabel38.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel38.TabIndex = 1;
            this.lunarLabel38.Text = "十一月二八";
            // 
            // dateLabel38
            // 
            this.dateLabel38.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel38.Location = new System.Drawing.Point(32, 4);
            this.dateLabel38.Name = "dateLabel38";
            this.dateLabel38.Size = new System.Drawing.Size(26, 26);
            this.dateLabel38.TabIndex = 0;
            this.dateLabel38.Text = "30";
            this.dateLabel38.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel38
            // 
            this.holidayLabel38.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel38.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel38.Name = "holidayLabel38";
            this.holidayLabel38.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel38.TabIndex = 2;
            this.holidayLabel38.Text = "国庆节";
            // 
            // overtimeLabel38
            // 
            this.overtimeLabel38.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel38.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel38.Location = new System.Drawing.Point(4, 18);
            this.overtimeLabel38.Name = "overtimeLabel38";
            this.overtimeLabel38.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel38.TabIndex = 3;
            this.overtimeLabel38.Text = "3.5";
            // 
            // panel31
            // 
            this.panel31.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel31.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel31.BorderWidth = 1F;
            this.panel31.Controls.Add(this.lunarLabel31);
            this.panel31.Controls.Add(this.dateLabel31);
            this.panel31.Controls.Add(this.holidayLabel31);
            this.panel31.Controls.Add(this.overtimeLabel31);
            this.panel31.Location = new System.Drawing.Point(203, 502);
            this.panel31.Name = "panel31";
            this.panel31.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel31.Size = new System.Drawing.Size(85, 89);
            this.panel31.TabIndex = 3;
            this.panel31.Text = "panel1";
            this.panel31.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel31.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel31.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel31
            // 
            this.lunarLabel31.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel31.Location = new System.Drawing.Point(4, 63);
            this.lunarLabel31.Name = "lunarLabel31";
            this.lunarLabel31.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel31.TabIndex = 1;
            this.lunarLabel31.Text = "十一月二八";
            // 
            // dateLabel31
            // 
            this.dateLabel31.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel31.Location = new System.Drawing.Point(32, 4);
            this.dateLabel31.Name = "dateLabel31";
            this.dateLabel31.Size = new System.Drawing.Size(26, 26);
            this.dateLabel31.TabIndex = 0;
            this.dateLabel31.Text = "30";
            this.dateLabel31.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel31
            // 
            this.holidayLabel31.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel31.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel31.Name = "holidayLabel31";
            this.holidayLabel31.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel31.TabIndex = 2;
            this.holidayLabel31.Text = "国庆节";
            // 
            // overtimeLabel31
            // 
            this.overtimeLabel31.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel31.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel31.Location = new System.Drawing.Point(4, 19);
            this.overtimeLabel31.Name = "overtimeLabel31";
            this.overtimeLabel31.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel31.TabIndex = 3;
            this.overtimeLabel31.Text = "3.5";
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel24.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel24.BorderWidth = 1F;
            this.panel24.Controls.Add(this.lunarLabel24);
            this.panel24.Controls.Add(this.dateLabel24);
            this.panel24.Controls.Add(this.holidayLabel24);
            this.panel24.Controls.Add(this.overtimeLabel24);
            this.panel24.Location = new System.Drawing.Point(203, 407);
            this.panel24.Name = "panel24";
            this.panel24.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel24.Size = new System.Drawing.Size(85, 89);
            this.panel24.TabIndex = 3;
            this.panel24.Text = "panel1";
            this.panel24.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel24.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel24.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel24
            // 
            this.lunarLabel24.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel24.Location = new System.Drawing.Point(4, 63);
            this.lunarLabel24.Name = "lunarLabel24";
            this.lunarLabel24.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel24.TabIndex = 1;
            this.lunarLabel24.Text = "十一月二八";
            // 
            // dateLabel24
            // 
            this.dateLabel24.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel24.Location = new System.Drawing.Point(32, 4);
            this.dateLabel24.Name = "dateLabel24";
            this.dateLabel24.Size = new System.Drawing.Size(26, 26);
            this.dateLabel24.TabIndex = 0;
            this.dateLabel24.Text = "30";
            this.dateLabel24.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel24
            // 
            this.holidayLabel24.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel24.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel24.Name = "holidayLabel24";
            this.holidayLabel24.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel24.TabIndex = 2;
            this.holidayLabel24.Text = "国庆节";
            // 
            // overtimeLabel24
            // 
            this.overtimeLabel24.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel24.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel24.Location = new System.Drawing.Point(4, 18);
            this.overtimeLabel24.Name = "overtimeLabel24";
            this.overtimeLabel24.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel24.TabIndex = 3;
            this.overtimeLabel24.Text = "3.5";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel17.BorderWidth = 1F;
            this.panel17.Controls.Add(this.lunarLabel17);
            this.panel17.Controls.Add(this.dateLabel17);
            this.panel17.Controls.Add(this.holidayLabel17);
            this.panel17.Controls.Add(this.overtimeLabel17);
            this.panel17.Location = new System.Drawing.Point(203, 312);
            this.panel17.Name = "panel17";
            this.panel17.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel17.Size = new System.Drawing.Size(85, 89);
            this.panel17.TabIndex = 3;
            this.panel17.Text = "panel1";
            this.panel17.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel17.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel17.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel17
            // 
            this.lunarLabel17.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel17.Location = new System.Drawing.Point(4, 63);
            this.lunarLabel17.Name = "lunarLabel17";
            this.lunarLabel17.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel17.TabIndex = 1;
            this.lunarLabel17.Text = "十一月二八";
            // 
            // dateLabel17
            // 
            this.dateLabel17.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel17.Location = new System.Drawing.Point(32, 4);
            this.dateLabel17.Name = "dateLabel17";
            this.dateLabel17.Size = new System.Drawing.Size(26, 26);
            this.dateLabel17.TabIndex = 0;
            this.dateLabel17.Text = "30";
            this.dateLabel17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel17
            // 
            this.holidayLabel17.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel17.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel17.Name = "holidayLabel17";
            this.holidayLabel17.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel17.TabIndex = 2;
            this.holidayLabel17.Text = "国庆节";
            // 
            // overtimeLabel17
            // 
            this.overtimeLabel17.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel17.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel17.Location = new System.Drawing.Point(4, 20);
            this.overtimeLabel17.Name = "overtimeLabel17";
            this.overtimeLabel17.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel17.TabIndex = 3;
            this.overtimeLabel17.Text = "3.5";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel10.BorderWidth = 1F;
            this.panel10.Controls.Add(this.lunarLabel10);
            this.panel10.Controls.Add(this.dateLabel10);
            this.panel10.Controls.Add(this.holidayLabel10);
            this.panel10.Controls.Add(this.overtimeLabel10);
            this.panel10.Location = new System.Drawing.Point(203, 217);
            this.panel10.Name = "panel10";
            this.panel10.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel10.Size = new System.Drawing.Size(85, 89);
            this.panel10.TabIndex = 3;
            this.panel10.Text = "panel1";
            this.panel10.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel10.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel10.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel10
            // 
            this.lunarLabel10.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel10.Location = new System.Drawing.Point(4, 61);
            this.lunarLabel10.Name = "lunarLabel10";
            this.lunarLabel10.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel10.TabIndex = 1;
            this.lunarLabel10.Text = "十一月二八";
            // 
            // dateLabel10
            // 
            this.dateLabel10.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel10.Location = new System.Drawing.Point(32, 4);
            this.dateLabel10.Name = "dateLabel10";
            this.dateLabel10.Size = new System.Drawing.Size(26, 26);
            this.dateLabel10.TabIndex = 0;
            this.dateLabel10.Text = "30";
            this.dateLabel10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel10
            // 
            this.holidayLabel10.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel10.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel10.Name = "holidayLabel10";
            this.holidayLabel10.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel10.TabIndex = 2;
            this.holidayLabel10.Text = "国庆节";
            // 
            // overtimeLabel10
            // 
            this.overtimeLabel10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel10.Location = new System.Drawing.Point(4, 14);
            this.overtimeLabel10.Name = "overtimeLabel10";
            this.overtimeLabel10.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel10.TabIndex = 3;
            this.overtimeLabel10.Text = "3.5";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel3.BorderWidth = 1F;
            this.panel3.Controls.Add(this.lunarLabel3);
            this.panel3.Controls.Add(this.holidayLabel3);
            this.panel3.Controls.Add(this.overtimeLabel3);
            this.panel3.Controls.Add(this.dateLabel3);
            this.panel3.Location = new System.Drawing.Point(203, 122);
            this.panel3.Name = "panel3";
            this.panel3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Size = new System.Drawing.Size(85, 89);
            this.panel3.TabIndex = 3;
            this.panel3.Text = "panel1";
            this.panel3.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel3.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel3.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel3
            // 
            this.lunarLabel3.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel3.Location = new System.Drawing.Point(8, 61);
            this.lunarLabel3.Name = "lunarLabel3";
            this.lunarLabel3.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel3.TabIndex = 1;
            this.lunarLabel3.Text = "十一月二八";
            // 
            // holidayLabel3
            // 
            this.holidayLabel3.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel3.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel3.Name = "holidayLabel3";
            this.holidayLabel3.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel3.TabIndex = 2;
            this.holidayLabel3.Text = "国庆节";
            // 
            // overtimeLabel3
            // 
            this.overtimeLabel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel3.Location = new System.Drawing.Point(4, 14);
            this.overtimeLabel3.Name = "overtimeLabel3";
            this.overtimeLabel3.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel3.TabIndex = 3;
            this.overtimeLabel3.Text = "3.5";
            // 
            // dateLabel3
            // 
            this.dateLabel3.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel3.Location = new System.Drawing.Point(32, 4);
            this.dateLabel3.Name = "dateLabel3";
            this.dateLabel3.Size = new System.Drawing.Size(26, 26);
            this.dateLabel3.TabIndex = 0;
            this.dateLabel3.Text = "30";
            this.dateLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel37
            // 
            this.panel37.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel37.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel37.BorderWidth = 1F;
            this.panel37.Controls.Add(this.lunarLabel37);
            this.panel37.Controls.Add(this.dateLabel37);
            this.panel37.Controls.Add(this.holidayLabel37);
            this.panel37.Controls.Add(this.overtimeLabel37);
            this.panel37.Location = new System.Drawing.Point(112, 597);
            this.panel37.Name = "panel37";
            this.panel37.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel37.Size = new System.Drawing.Size(85, 89);
            this.panel37.TabIndex = 3;
            this.panel37.Text = "panel1";
            this.panel37.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel37.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel37.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel37
            // 
            this.lunarLabel37.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel37.Location = new System.Drawing.Point(4, 61);
            this.lunarLabel37.Name = "lunarLabel37";
            this.lunarLabel37.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel37.TabIndex = 1;
            this.lunarLabel37.Text = "十一月二八";
            // 
            // dateLabel37
            // 
            this.dateLabel37.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel37.Location = new System.Drawing.Point(32, 4);
            this.dateLabel37.Name = "dateLabel37";
            this.dateLabel37.Size = new System.Drawing.Size(26, 26);
            this.dateLabel37.TabIndex = 0;
            this.dateLabel37.Text = "30";
            this.dateLabel37.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel37
            // 
            this.holidayLabel37.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel37.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel37.Name = "holidayLabel37";
            this.holidayLabel37.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel37.TabIndex = 2;
            this.holidayLabel37.Text = "国庆节";
            // 
            // overtimeLabel37
            // 
            this.overtimeLabel37.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel37.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel37.Location = new System.Drawing.Point(4, 18);
            this.overtimeLabel37.Name = "overtimeLabel37";
            this.overtimeLabel37.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel37.TabIndex = 3;
            this.overtimeLabel37.Text = "3.5";
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel30.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel30.BorderWidth = 1F;
            this.panel30.Controls.Add(this.lunarLabel30);
            this.panel30.Controls.Add(this.dateLabel30);
            this.panel30.Controls.Add(this.holidayLabel30);
            this.panel30.Controls.Add(this.overtimeLabel30);
            this.panel30.Location = new System.Drawing.Point(112, 502);
            this.panel30.Name = "panel30";
            this.panel30.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel30.Size = new System.Drawing.Size(85, 89);
            this.panel30.TabIndex = 3;
            this.panel30.Text = "panel1";
            this.panel30.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel30.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel30.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel30
            // 
            this.lunarLabel30.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel30.Location = new System.Drawing.Point(4, 63);
            this.lunarLabel30.Name = "lunarLabel30";
            this.lunarLabel30.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel30.TabIndex = 1;
            this.lunarLabel30.Text = "十一月二八";
            // 
            // dateLabel30
            // 
            this.dateLabel30.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel30.Location = new System.Drawing.Point(32, 4);
            this.dateLabel30.Name = "dateLabel30";
            this.dateLabel30.Size = new System.Drawing.Size(26, 26);
            this.dateLabel30.TabIndex = 0;
            this.dateLabel30.Text = "30";
            this.dateLabel30.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel30
            // 
            this.holidayLabel30.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel30.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel30.Name = "holidayLabel30";
            this.holidayLabel30.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel30.TabIndex = 2;
            this.holidayLabel30.Text = "国庆节";
            // 
            // overtimeLabel30
            // 
            this.overtimeLabel30.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel30.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel30.Location = new System.Drawing.Point(4, 19);
            this.overtimeLabel30.Name = "overtimeLabel30";
            this.overtimeLabel30.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel30.TabIndex = 3;
            this.overtimeLabel30.Text = "3.5";
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel23.BorderWidth = 1F;
            this.panel23.Controls.Add(this.lunarLabel23);
            this.panel23.Controls.Add(this.dateLabel23);
            this.panel23.Controls.Add(this.holidayLabel23);
            this.panel23.Controls.Add(this.overtimeLabel23);
            this.panel23.Location = new System.Drawing.Point(112, 407);
            this.panel23.Name = "panel23";
            this.panel23.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel23.Size = new System.Drawing.Size(85, 89);
            this.panel23.TabIndex = 3;
            this.panel23.Text = "panel1";
            this.panel23.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel23.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel23.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel23
            // 
            this.lunarLabel23.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel23.Location = new System.Drawing.Point(4, 63);
            this.lunarLabel23.Name = "lunarLabel23";
            this.lunarLabel23.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel23.TabIndex = 1;
            this.lunarLabel23.Text = "十一月二八";
            // 
            // dateLabel23
            // 
            this.dateLabel23.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel23.Location = new System.Drawing.Point(32, 4);
            this.dateLabel23.Name = "dateLabel23";
            this.dateLabel23.Size = new System.Drawing.Size(26, 26);
            this.dateLabel23.TabIndex = 0;
            this.dateLabel23.Text = "30";
            this.dateLabel23.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel23
            // 
            this.holidayLabel23.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel23.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel23.Name = "holidayLabel23";
            this.holidayLabel23.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel23.TabIndex = 2;
            this.holidayLabel23.Text = "国庆节";
            // 
            // overtimeLabel23
            // 
            this.overtimeLabel23.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel23.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel23.Location = new System.Drawing.Point(4, 18);
            this.overtimeLabel23.Name = "overtimeLabel23";
            this.overtimeLabel23.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel23.TabIndex = 3;
            this.overtimeLabel23.Text = "3.5";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel16.BorderWidth = 1F;
            this.panel16.Controls.Add(this.lunarLabel16);
            this.panel16.Controls.Add(this.dateLabel16);
            this.panel16.Controls.Add(this.holidayLabel16);
            this.panel16.Controls.Add(this.overtimeLabel16);
            this.panel16.Location = new System.Drawing.Point(112, 312);
            this.panel16.Name = "panel16";
            this.panel16.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel16.Size = new System.Drawing.Size(85, 89);
            this.panel16.TabIndex = 3;
            this.panel16.Text = "panel1";
            this.panel16.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel16.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel16.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel16
            // 
            this.lunarLabel16.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel16.Location = new System.Drawing.Point(4, 63);
            this.lunarLabel16.Name = "lunarLabel16";
            this.lunarLabel16.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel16.TabIndex = 1;
            this.lunarLabel16.Text = "十一月二八";
            // 
            // dateLabel16
            // 
            this.dateLabel16.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel16.Location = new System.Drawing.Point(32, 4);
            this.dateLabel16.Name = "dateLabel16";
            this.dateLabel16.Size = new System.Drawing.Size(26, 26);
            this.dateLabel16.TabIndex = 0;
            this.dateLabel16.Text = "30";
            this.dateLabel16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel16
            // 
            this.holidayLabel16.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel16.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel16.Name = "holidayLabel16";
            this.holidayLabel16.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel16.TabIndex = 2;
            this.holidayLabel16.Text = "国庆节";
            // 
            // overtimeLabel16
            // 
            this.overtimeLabel16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel16.Location = new System.Drawing.Point(4, 20);
            this.overtimeLabel16.Name = "overtimeLabel16";
            this.overtimeLabel16.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel16.TabIndex = 3;
            this.overtimeLabel16.Text = "3.5";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel9.BorderWidth = 1F;
            this.panel9.Controls.Add(this.lunarLabel9);
            this.panel9.Controls.Add(this.dateLabel9);
            this.panel9.Controls.Add(this.holidayLabel9);
            this.panel9.Controls.Add(this.overtimeLabel9);
            this.panel9.Location = new System.Drawing.Point(112, 217);
            this.panel9.Name = "panel9";
            this.panel9.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel9.Size = new System.Drawing.Size(85, 89);
            this.panel9.TabIndex = 3;
            this.panel9.Text = "panel1";
            this.panel9.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel9.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel9.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel9
            // 
            this.lunarLabel9.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel9.Location = new System.Drawing.Point(4, 61);
            this.lunarLabel9.Name = "lunarLabel9";
            this.lunarLabel9.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel9.TabIndex = 1;
            this.lunarLabel9.Text = "十一月二八";
            // 
            // dateLabel9
            // 
            this.dateLabel9.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel9.Location = new System.Drawing.Point(32, 4);
            this.dateLabel9.Name = "dateLabel9";
            this.dateLabel9.Size = new System.Drawing.Size(26, 26);
            this.dateLabel9.TabIndex = 0;
            this.dateLabel9.Text = "30";
            this.dateLabel9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel9
            // 
            this.holidayLabel9.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel9.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel9.Name = "holidayLabel9";
            this.holidayLabel9.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel9.TabIndex = 2;
            this.holidayLabel9.Text = "国庆节";
            // 
            // overtimeLabel9
            // 
            this.overtimeLabel9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel9.Location = new System.Drawing.Point(4, 14);
            this.overtimeLabel9.Name = "overtimeLabel9";
            this.overtimeLabel9.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel9.TabIndex = 3;
            this.overtimeLabel9.Text = "3.5";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Badge = "  ";
            this.panel2.BadgeBack = System.Drawing.Color.Red;
            this.panel2.BadgeOffsetX = -1;
            this.panel2.BadgeOffsetY = -1;
            this.panel2.BadgeSize = 1F;
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel2.BorderWidth = 1F;
            this.panel2.Controls.Add(this.overtimeLabel2);
            this.panel2.Controls.Add(this.holidayLabel2);
            this.panel2.Controls.Add(this.lunarLabel2);
            this.panel2.Controls.Add(this.dateLabel2);
            this.panel2.Location = new System.Drawing.Point(112, 122);
            this.panel2.Name = "panel2";
            this.panel2.padding = new System.Windows.Forms.Padding(1);
            this.panel2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Size = new System.Drawing.Size(83, 89);
            this.panel2.TabIndex = 3;
            this.panel2.Text = "panel1";
            this.panel2.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel2.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // overtimeLabel2
            // 
            this.overtimeLabel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel2.Location = new System.Drawing.Point(4, 14);
            this.overtimeLabel2.Name = "overtimeLabel2";
            this.overtimeLabel2.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel2.TabIndex = 3;
            this.overtimeLabel2.Text = "3.5";
            // 
            // holidayLabel2
            // 
            this.holidayLabel2.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel2.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel2.Name = "holidayLabel2";
            this.holidayLabel2.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel2.TabIndex = 2;
            this.holidayLabel2.Text = "国庆节";
            // 
            // lunarLabel2
            // 
            this.lunarLabel2.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel2.Location = new System.Drawing.Point(4, 61);
            this.lunarLabel2.Name = "lunarLabel2";
            this.lunarLabel2.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel2.TabIndex = 1;
            this.lunarLabel2.Text = "十一月二八";
            // 
            // dateLabel2
            // 
            this.dateLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateLabel2.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dateLabel2.HandCursor = System.Windows.Forms.Cursors.Default;
            this.dateLabel2.Location = new System.Drawing.Point(32, 4);
            this.dateLabel2.Name = "dateLabel2";
            this.dateLabel2.Size = new System.Drawing.Size(26, 26);
            this.dateLabel2.TabIndex = 0;
            this.dateLabel2.Text = "30";
            this.dateLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel36
            // 
            this.panel36.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel36.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel36.BorderWidth = 1F;
            this.panel36.Controls.Add(this.lunarLabel36);
            this.panel36.Controls.Add(this.dateLabel36);
            this.panel36.Controls.Add(this.holidayLabel36);
            this.panel36.Controls.Add(this.overtimeLabel36);
            this.panel36.Location = new System.Drawing.Point(21, 597);
            this.panel36.Name = "panel36";
            this.panel36.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel36.Size = new System.Drawing.Size(85, 89);
            this.panel36.TabIndex = 3;
            this.panel36.Text = "panel1";
            this.panel36.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel36.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel36.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel36
            // 
            this.lunarLabel36.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel36.Location = new System.Drawing.Point(3, 61);
            this.lunarLabel36.Name = "lunarLabel36";
            this.lunarLabel36.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel36.TabIndex = 1;
            this.lunarLabel36.Text = "十一月二八";
            // 
            // dateLabel36
            // 
            this.dateLabel36.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel36.Location = new System.Drawing.Point(32, 4);
            this.dateLabel36.Name = "dateLabel36";
            this.dateLabel36.Size = new System.Drawing.Size(26, 26);
            this.dateLabel36.TabIndex = 0;
            this.dateLabel36.Text = "30";
            this.dateLabel36.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel36
            // 
            this.holidayLabel36.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel36.Location = new System.Drawing.Point(3, 41);
            this.holidayLabel36.Name = "holidayLabel36";
            this.holidayLabel36.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel36.TabIndex = 2;
            this.holidayLabel36.Text = "国庆节";
            // 
            // overtimeLabel36
            // 
            this.overtimeLabel36.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel36.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel36.Location = new System.Drawing.Point(4, 18);
            this.overtimeLabel36.Name = "overtimeLabel36";
            this.overtimeLabel36.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel36.TabIndex = 3;
            this.overtimeLabel36.Text = "3.5";
            // 
            // panel29
            // 
            this.panel29.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel29.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel29.BorderWidth = 1F;
            this.panel29.Controls.Add(this.lunarLabel29);
            this.panel29.Controls.Add(this.dateLabel29);
            this.panel29.Controls.Add(this.holidayLabel29);
            this.panel29.Controls.Add(this.overtimeLabel29);
            this.panel29.Location = new System.Drawing.Point(21, 502);
            this.panel29.Name = "panel29";
            this.panel29.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel29.Size = new System.Drawing.Size(85, 89);
            this.panel29.TabIndex = 3;
            this.panel29.Text = "panel1";
            this.panel29.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel29.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel29.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel29
            // 
            this.lunarLabel29.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel29.Location = new System.Drawing.Point(3, 63);
            this.lunarLabel29.Name = "lunarLabel29";
            this.lunarLabel29.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel29.TabIndex = 1;
            this.lunarLabel29.Text = "十一月二八";
            // 
            // dateLabel29
            // 
            this.dateLabel29.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel29.Location = new System.Drawing.Point(30, 4);
            this.dateLabel29.Name = "dateLabel29";
            this.dateLabel29.Size = new System.Drawing.Size(26, 26);
            this.dateLabel29.TabIndex = 0;
            this.dateLabel29.Text = "30";
            this.dateLabel29.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel29
            // 
            this.holidayLabel29.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel29.Location = new System.Drawing.Point(3, 41);
            this.holidayLabel29.Name = "holidayLabel29";
            this.holidayLabel29.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel29.TabIndex = 2;
            this.holidayLabel29.Text = "国庆节";
            // 
            // overtimeLabel29
            // 
            this.overtimeLabel29.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel29.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel29.Location = new System.Drawing.Point(4, 19);
            this.overtimeLabel29.Name = "overtimeLabel29";
            this.overtimeLabel29.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel29.TabIndex = 3;
            this.overtimeLabel29.Text = "3.5";
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel22.BorderWidth = 1F;
            this.panel22.Controls.Add(this.lunarLabel22);
            this.panel22.Controls.Add(this.dateLabel22);
            this.panel22.Controls.Add(this.holidayLabel22);
            this.panel22.Controls.Add(this.overtimeLabel22);
            this.panel22.Location = new System.Drawing.Point(21, 407);
            this.panel22.Name = "panel22";
            this.panel22.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel22.Size = new System.Drawing.Size(85, 89);
            this.panel22.TabIndex = 3;
            this.panel22.Text = "panel1";
            this.panel22.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel22.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel22.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel22
            // 
            this.lunarLabel22.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel22.Location = new System.Drawing.Point(4, 61);
            this.lunarLabel22.Name = "lunarLabel22";
            this.lunarLabel22.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel22.TabIndex = 1;
            this.lunarLabel22.Text = "十一月二八";
            // 
            // dateLabel22
            // 
            this.dateLabel22.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel22.Location = new System.Drawing.Point(32, 4);
            this.dateLabel22.Name = "dateLabel22";
            this.dateLabel22.Size = new System.Drawing.Size(26, 26);
            this.dateLabel22.TabIndex = 0;
            this.dateLabel22.Text = "30";
            this.dateLabel22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel22
            // 
            this.holidayLabel22.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel22.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel22.Name = "holidayLabel22";
            this.holidayLabel22.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel22.TabIndex = 2;
            this.holidayLabel22.Text = "国庆节";
            // 
            // overtimeLabel22
            // 
            this.overtimeLabel22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel22.Location = new System.Drawing.Point(4, 18);
            this.overtimeLabel22.Name = "overtimeLabel22";
            this.overtimeLabel22.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel22.TabIndex = 3;
            this.overtimeLabel22.Text = "3.5";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel15.BorderWidth = 1F;
            this.panel15.Controls.Add(this.lunarLabel15);
            this.panel15.Controls.Add(this.dateLabel15);
            this.panel15.Controls.Add(this.holidayLabel15);
            this.panel15.Controls.Add(this.overtimeLabel15);
            this.panel15.Location = new System.Drawing.Point(21, 312);
            this.panel15.Name = "panel15";
            this.panel15.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel15.Size = new System.Drawing.Size(85, 89);
            this.panel15.TabIndex = 3;
            this.panel15.Text = "panel1";
            this.panel15.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel15.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel15.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel15
            // 
            this.lunarLabel15.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel15.Location = new System.Drawing.Point(4, 63);
            this.lunarLabel15.Name = "lunarLabel15";
            this.lunarLabel15.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel15.TabIndex = 1;
            this.lunarLabel15.Text = "十一月二八";
            // 
            // dateLabel15
            // 
            this.dateLabel15.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel15.Location = new System.Drawing.Point(31, 4);
            this.dateLabel15.Name = "dateLabel15";
            this.dateLabel15.Size = new System.Drawing.Size(26, 26);
            this.dateLabel15.TabIndex = 0;
            this.dateLabel15.Text = "30";
            this.dateLabel15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel15
            // 
            this.holidayLabel15.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel15.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel15.Name = "holidayLabel15";
            this.holidayLabel15.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel15.TabIndex = 2;
            this.holidayLabel15.Text = "国庆节";
            // 
            // overtimeLabel15
            // 
            this.overtimeLabel15.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel15.Location = new System.Drawing.Point(4, 20);
            this.overtimeLabel15.Name = "overtimeLabel15";
            this.overtimeLabel15.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel15.TabIndex = 3;
            this.overtimeLabel15.Text = "3.5";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel8.BorderWidth = 1F;
            this.panel8.Controls.Add(this.lunarLabel8);
            this.panel8.Controls.Add(this.dateLabel8);
            this.panel8.Controls.Add(this.holidayLabel8);
            this.panel8.Controls.Add(this.overtimeLabel8);
            this.panel8.Location = new System.Drawing.Point(21, 217);
            this.panel8.Name = "panel8";
            this.panel8.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel8.Size = new System.Drawing.Size(85, 89);
            this.panel8.TabIndex = 3;
            this.panel8.Text = "panel1";
            this.panel8.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel8.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel8.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lunarLabel8
            // 
            this.lunarLabel8.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel8.Location = new System.Drawing.Point(3, 61);
            this.lunarLabel8.Name = "lunarLabel8";
            this.lunarLabel8.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel8.TabIndex = 1;
            this.lunarLabel8.Text = "十一月二八";
            // 
            // dateLabel8
            // 
            this.dateLabel8.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel8.Location = new System.Drawing.Point(31, 4);
            this.dateLabel8.Name = "dateLabel8";
            this.dateLabel8.Size = new System.Drawing.Size(26, 26);
            this.dateLabel8.TabIndex = 0;
            this.dateLabel8.Text = "30";
            this.dateLabel8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // holidayLabel8
            // 
            this.holidayLabel8.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel8.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel8.Name = "holidayLabel8";
            this.holidayLabel8.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel8.TabIndex = 2;
            this.holidayLabel8.Text = "国庆节";
            // 
            // overtimeLabel8
            // 
            this.overtimeLabel8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel8.Location = new System.Drawing.Point(4, 14);
            this.overtimeLabel8.Name = "overtimeLabel8";
            this.overtimeLabel8.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel8.TabIndex = 3;
            this.overtimeLabel8.Text = "3.5";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Badge = "10";
            this.panel1.BadgeBack = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BadgeMode = true;
            this.panel1.BadgeOffsetX = 2;
            this.panel1.BadgeOffsetY = 2;
            this.panel1.BadgeSize = 5F;
            this.panel1.BadgeSvg = "";
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel1.BorderWidth = 1F;
            this.panel1.Controls.Add(this.overtimeLabel1);
            this.panel1.Controls.Add(this.holidayLabel1);
            this.panel1.Controls.Add(this.dateLabel1);
            this.panel1.Controls.Add(this.lunarLabel1);
            this.panel1.Location = new System.Drawing.Point(19, 122);
            this.panel1.Name = "panel1";
            this.panel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Size = new System.Drawing.Size(87, 89);
            this.panel1.TabIndex = 3;
            this.panel1.Text = "panel1";
            this.panel1.Click += new System.EventHandler(this.DatePanel_Click);
            this.panel1.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // overtimeLabel1
            // 
            this.overtimeLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.overtimeLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeLabel1.Location = new System.Drawing.Point(4, 14);
            this.overtimeLabel1.Name = "overtimeLabel1";
            this.overtimeLabel1.Size = new System.Drawing.Size(31, 26);
            this.overtimeLabel1.TabIndex = 3;
            this.overtimeLabel1.Text = "3.5";
            // 
            // holidayLabel1
            // 
            this.holidayLabel1.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.holidayLabel1.Location = new System.Drawing.Point(4, 41);
            this.holidayLabel1.Name = "holidayLabel1";
            this.holidayLabel1.Size = new System.Drawing.Size(54, 21);
            this.holidayLabel1.TabIndex = 2;
            this.holidayLabel1.Text = "国庆节";
            // 
            // dateLabel1
            // 
            this.dateLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateLabel1.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dateLabel1.Location = new System.Drawing.Point(34, 4);
            this.dateLabel1.Name = "dateLabel1";
            this.dateLabel1.Size = new System.Drawing.Size(26, 26);
            this.dateLabel1.TabIndex = 0;
            this.dateLabel1.Text = "30";
            this.dateLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lunarLabel1
            // 
            this.lunarLabel1.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lunarLabel1.Location = new System.Drawing.Point(4, 61);
            this.lunarLabel1.Name = "lunarLabel1";
            this.lunarLabel1.Size = new System.Drawing.Size(63, 24);
            this.lunarLabel1.TabIndex = 1;
            this.lunarLabel1.Text = "十一月二八";
            // 
            // sunLabel
            // 
            this.sunLabel.Location = new System.Drawing.Point(565, 85);
            this.sunLabel.Name = "sunLabel";
            this.sunLabel.Size = new System.Drawing.Size(85, 23);
            this.sunLabel.TabIndex = 2;
            this.sunLabel.Text = "日";
            this.sunLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // satLabel
            // 
            this.satLabel.Location = new System.Drawing.Point(474, 85);
            this.satLabel.Name = "satLabel";
            this.satLabel.Size = new System.Drawing.Size(85, 23);
            this.satLabel.TabIndex = 2;
            this.satLabel.Text = "六";
            this.satLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // friLabel
            // 
            this.friLabel.Location = new System.Drawing.Point(383, 85);
            this.friLabel.Name = "friLabel";
            this.friLabel.Size = new System.Drawing.Size(85, 23);
            this.friLabel.TabIndex = 2;
            this.friLabel.Text = "五";
            this.friLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thurLabel
            // 
            this.thurLabel.Location = new System.Drawing.Point(292, 84);
            this.thurLabel.Name = "thurLabel";
            this.thurLabel.Size = new System.Drawing.Size(85, 23);
            this.thurLabel.TabIndex = 2;
            this.thurLabel.Text = "四";
            this.thurLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wedLabel
            // 
            this.wedLabel.Location = new System.Drawing.Point(201, 85);
            this.wedLabel.Name = "wedLabel";
            this.wedLabel.Size = new System.Drawing.Size(85, 23);
            this.wedLabel.TabIndex = 2;
            this.wedLabel.Text = "三";
            this.wedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tuesLabel
            // 
            this.tuesLabel.Location = new System.Drawing.Point(110, 85);
            this.tuesLabel.Name = "tuesLabel";
            this.tuesLabel.Size = new System.Drawing.Size(85, 23);
            this.tuesLabel.TabIndex = 2;
            this.tuesLabel.Text = "二";
            this.tuesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monLabel
            // 
            this.monLabel.Location = new System.Drawing.Point(19, 84);
            this.monLabel.Name = "monLabel";
            this.monLabel.Size = new System.Drawing.Size(85, 23);
            this.monLabel.TabIndex = 2;
            this.monLabel.Text = "一";
            this.monLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // overtimeInput
            // 
            this.overtimeInput.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.overtimeInput.Location = new System.Drawing.Point(416, 35);
            this.overtimeInput.Name = "overtimeInput";
            this.overtimeInput.Size = new System.Drawing.Size(100, 46);
            this.overtimeInput.TabIndex = 30;
            this.overtimeInput.Text = "0";
            this.overtimeInput.ValueChanged += new AntdUI.DecimalEventHandler(this.overtimeInput_ValueChanged);
            // 
            // 计算加班时间
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(742, 856);
            this.Controls.Add(this.overtimeInput);
            this.Controls.Add(this.backgroundpanel);
            this.Controls.Add(this.windowBar1);
            this.Controls.Add(this.sumHoursLabel);
            this.Controls.Add(this.needOvertimeLabel);
            this.Controls.Add(this.overtime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "计算加班时间";
            this.Text = "计算加班时间";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.backgroundpanel.ResumeLayout(false);
            this.panel42.ResumeLayout(false);
            this.panel35.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel41.ResumeLayout(false);
            this.panel34.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel40.ResumeLayout(false);
            this.panel33.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel39.ResumeLayout(false);
            this.panel32.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel38.ResumeLayout(false);
            this.panel31.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel37.ResumeLayout(false);
            this.panel30.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel36.ResumeLayout(false);
            this.panel29.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label overtime;
        private System.Windows.Forms.Label needOvertimeLabel;
        private System.Windows.Forms.Label sumHoursLabel;
        private AntdUI.WindowBar windowBar1;
        private AntdUI.Panel backgroundpanel;
        private AntdUI.Label sunLabel;
        private AntdUI.Label satLabel;
        private AntdUI.Label friLabel;
        private AntdUI.Label thurLabel;
        private AntdUI.Label wedLabel;
        private AntdUI.Label tuesLabel;
        private AntdUI.Label monLabel;
        private AntdUI.Panel panel1;
        private AntdUI.Panel panel42;
        private AntdUI.Label dateLabel42;
        private AntdUI.Panel panel35;
        private AntdUI.Label dateLabel35;
        private AntdUI.Panel panel28;
        private AntdUI.Label dateLabel28;
        private AntdUI.Panel panel21;
        private AntdUI.Label dateLabel21;
        private AntdUI.Panel panel14;
        private AntdUI.Label dateLabel14;
        private AntdUI.Panel panel7;
        private AntdUI.Label dateLabel7;
        private AntdUI.Panel panel41;
        private AntdUI.Label dateLabel41;
        private AntdUI.Panel panel34;
        private AntdUI.Label dateLabel34;
        private AntdUI.Panel panel27;
        private AntdUI.Label dateLabel27;
        private AntdUI.Panel panel20;
        private AntdUI.Label dateLabel20;
        private AntdUI.Panel panel13;
        private AntdUI.Label dateLabel13;
        private AntdUI.Panel panel6;
        private AntdUI.Label dateLabel6;
        private AntdUI.Panel panel40;
        private AntdUI.Label dateLabel40;
        private AntdUI.Panel panel33;
        private AntdUI.Label dateLabel33;
        private AntdUI.Panel panel26;
        private AntdUI.Label dateLabel26;
        private AntdUI.Panel panel19;
        private AntdUI.Label dateLabel19;
        private AntdUI.Panel panel12;
        private AntdUI.Label dateLabel12;
        private AntdUI.Panel panel5;
        private AntdUI.Label dateLabel5;
        private AntdUI.Panel panel39;
        private AntdUI.Label dateLabel39;
        private AntdUI.Panel panel32;
        private AntdUI.Label dateLabel32;
        private AntdUI.Panel panel25;
        private AntdUI.Label dateLabel25;
        private AntdUI.Panel panel18;
        private AntdUI.Label dateLabel18;
        private AntdUI.Panel panel11;
        private AntdUI.Label dateLabel11;
        private AntdUI.Panel panel4;
        private AntdUI.Label dateLabel4;
        private AntdUI.Panel panel38;
        private AntdUI.Label dateLabel38;
        private AntdUI.Panel panel31;
        private AntdUI.Label dateLabel31;
        private AntdUI.Panel panel24;
        private AntdUI.Label dateLabel24;
        private AntdUI.Panel panel17;
        private AntdUI.Label dateLabel17;
        private AntdUI.Panel panel10;
        private AntdUI.Label dateLabel10;
        private AntdUI.Panel panel3;
        private AntdUI.Label dateLabel3;
        private AntdUI.Panel panel37;
        private AntdUI.Label dateLabel37;
        private AntdUI.Panel panel30;
        private AntdUI.Label dateLabel30;
        private AntdUI.Panel panel23;
        private AntdUI.Label dateLabel23;
        private AntdUI.Panel panel16;
        private AntdUI.Label dateLabel16;
        private AntdUI.Panel panel9;
        private AntdUI.Label dateLabel9;
        private AntdUI.Panel panel2;
        private AntdUI.Label dateLabel2;
        private AntdUI.Panel panel36;
        private AntdUI.Label dateLabel36;
        private AntdUI.Panel panel29;
        private AntdUI.Label dateLabel29;
        private AntdUI.Panel panel22;
        private AntdUI.Label dateLabel22;
        private AntdUI.Panel panel15;
        private AntdUI.Label dateLabel15;
        private AntdUI.Panel panel8;
        private AntdUI.Label dateLabel8;
        private AntdUI.Label overtimeLabel2;
        private AntdUI.Label holidayLabel2;
        private AntdUI.Label lunarLabel2;
        private AntdUI.Label overtimeLabel3;
        private AntdUI.Label holidayLabel3;
        private AntdUI.Label lunarLabel3;
        private AntdUI.Label lunarLabel4;
        private AntdUI.Label holidayLabel4;
        private AntdUI.Label overtimeLabel4;
        private AntdUI.Label lunarLabel42;
        private AntdUI.Label holidayLabel42;
        private AntdUI.Label overtimeLabel42;
        private AntdUI.Label lunarLabel35;
        private AntdUI.Label holidayLabel35;
        private AntdUI.Label overtimeLabel35;
        private AntdUI.Label lunarLabel28;
        private AntdUI.Label holidayLabel28;
        private AntdUI.Label overtimeLabel28;
        private AntdUI.Label lunarLabel21;
        private AntdUI.Label holidayLabel21;
        private AntdUI.Label overtimeLabel21;
        private AntdUI.Label lunarLabel14;
        private AntdUI.Label holidayLabel14;
        private AntdUI.Label overtimeLabel14;
        private AntdUI.Label lunarLabel7;
        private AntdUI.Label holidayLabel7;
        private AntdUI.Label overtimeLabel7;
        private AntdUI.Label lunarLabel41;
        private AntdUI.Label holidayLabel41;
        private AntdUI.Label overtimeLabel41;
        private AntdUI.Label lunarLabel34;
        private AntdUI.Label holidayLabel34;
        private AntdUI.Label overtimeLabel34;
        private AntdUI.Label lunarLabel27;
        private AntdUI.Label holidayLabel27;
        private AntdUI.Label overtimeLabel27;
        private AntdUI.Label lunarLabel20;
        private AntdUI.Label holidayLabel20;
        private AntdUI.Label overtimeLabel20;
        private AntdUI.Label lunarLabel13;
        private AntdUI.Label holidayLabel13;
        private AntdUI.Label overtimeLabel13;
        private AntdUI.Label lunarLabel6;
        private AntdUI.Label holidayLabel6;
        private AntdUI.Label overtimeLabel6;
        private AntdUI.Label lunarLabel40;
        private AntdUI.Label holidayLabel40;
        private AntdUI.Label overtimeLabel40;
        private AntdUI.Label lunarLabel33;
        private AntdUI.Label holidayLabel33;
        private AntdUI.Label overtimeLabel33;
        private AntdUI.Label lunarLabel26;
        private AntdUI.Label holidayLabel26;
        private AntdUI.Label overtimeLabel26;
        private AntdUI.Label lunarLabel19;
        private AntdUI.Label holidayLabel19;
        private AntdUI.Label overtimeLabel19;
        private AntdUI.Label lunarLabel12;
        private AntdUI.Label holidayLabel12;
        private AntdUI.Label overtimeLabel12;
        private AntdUI.Label lunarLabel5;
        private AntdUI.Label holidayLabel5;
        private AntdUI.Label overtimeLabel5;
        private AntdUI.Label lunarLabel39;
        private AntdUI.Label holidayLabel39;
        private AntdUI.Label overtimeLabel39;
        private AntdUI.Label lunarLabel32;
        private AntdUI.Label holidayLabel32;
        private AntdUI.Label overtimeLabel32;
        private AntdUI.Label lunarLabel25;
        private AntdUI.Label holidayLabel25;
        private AntdUI.Label overtimeLabel25;
        private AntdUI.Label lunarLabel18;
        private AntdUI.Label holidayLabel18;
        private AntdUI.Label overtimeLabel18;
        private AntdUI.Label lunarLabel11;
        private AntdUI.Label holidayLabel11;
        private AntdUI.Label overtimeLabel11;
        private AntdUI.Label lunarLabel38;
        private AntdUI.Label holidayLabel38;
        private AntdUI.Label overtimeLabel38;
        private AntdUI.Label lunarLabel31;
        private AntdUI.Label holidayLabel31;
        private AntdUI.Label overtimeLabel31;
        private AntdUI.Label lunarLabel24;
        private AntdUI.Label holidayLabel24;
        private AntdUI.Label overtimeLabel24;
        private AntdUI.Label lunarLabel17;
        private AntdUI.Label holidayLabel17;
        private AntdUI.Label overtimeLabel17;
        private AntdUI.Label lunarLabel10;
        private AntdUI.Label holidayLabel10;
        private AntdUI.Label overtimeLabel10;
        private AntdUI.Label lunarLabel37;
        private AntdUI.Label holidayLabel37;
        private AntdUI.Label overtimeLabel37;
        private AntdUI.Label lunarLabel30;
        private AntdUI.Label holidayLabel30;
        private AntdUI.Label overtimeLabel30;
        private AntdUI.Label lunarLabel23;
        private AntdUI.Label holidayLabel23;
        private AntdUI.Label overtimeLabel23;
        private AntdUI.Label lunarLabel16;
        private AntdUI.Label holidayLabel16;
        private AntdUI.Label overtimeLabel16;
        private AntdUI.Label lunarLabel9;
        private AntdUI.Label holidayLabel9;
        private AntdUI.Label overtimeLabel9;
        private AntdUI.Label lunarLabel36;
        private AntdUI.Label holidayLabel36;
        private AntdUI.Label overtimeLabel36;
        private AntdUI.Label lunarLabel29;
        private AntdUI.Label holidayLabel29;
        private AntdUI.Label overtimeLabel29;
        private AntdUI.Label lunarLabel22;
        private AntdUI.Label holidayLabel22;
        private AntdUI.Label overtimeLabel22;
        private AntdUI.Label lunarLabel15;
        private AntdUI.Label holidayLabel15;
        private AntdUI.Label overtimeLabel15;
        private AntdUI.Label lunarLabel8;
        private AntdUI.Label holidayLabel8;
        private AntdUI.Label overtimeLabel8;
        private AntdUI.Label overtimeLabel1;
        private AntdUI.Label holidayLabel1;
        private AntdUI.Label dateLabel1;
        private AntdUI.Label lunarLabel1;
        private AntdUI.Select yearSelect;
        private AntdUI.Select monthSelect;
        private AntdUI.InputNumber overtimeInput;
    }
}

