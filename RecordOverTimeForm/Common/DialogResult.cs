﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordOverTimeForm.Common
{
    public class Popup
    {
        /// <summary>
        /// 弹窗提示
        /// </summary>
        /// <param name="errorInfo">错误信息</param>
        /// <param name="title">标题</param>
        /// <param name="popUpType">弹窗类型</param>
        /// <returns></returns>
        public static DialogResult Tips(string errorInfo, string title = "信息提示", PopUpType popUpType = PopUpType.Info)
        {
            DialogResult dialogResult = default;
            switch (popUpType)
            {
                case PopUpType.Error:
                    dialogResult = MessageBox.Show(errorInfo, title, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    break;
                case PopUpType.Info:
                    dialogResult = MessageBox.Show(errorInfo, title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    break;
                case PopUpType.question:
                    dialogResult = MessageBox.Show(errorInfo, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    break;
                default:
                    break;
            }
            return dialogResult;
        }


        //弹窗类型
        public enum PopUpType
        {
            //错误
            Error,
            //信息
            Info,
            //问题
            question,
        }

    }
}

