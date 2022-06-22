using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordOverTimeForm.Utils
{
    public class FileHelper
    {
        public static void CrateFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                FileStream newText = File.Create(filePath);
                newText.Close();
            }
        }

        public static void CreateDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }


        /// <summary>
        /// 遍历 rootdir目录下的所有文件
        /// </summary>
        /// <param name="rootdir">目录名称</param>
        /// <returns>该目录下的所有文件</returns>
        public StringCollection GetAllFiles(string rootdir)
        {
            StringCollection result = new StringCollection();
            GetAllFiles(rootdir, result);
            return result;
        }

        /// <summary>
        /// 作为遍历文件函数的子函数
        /// </summary>
        /// <param name="parentDir">目录名称</param>
        /// <param name="result">该目录下的所有文件</param>
        public void GetAllFiles(string parentDir, StringCollection result)
        {
            StringBuilder sbstr01 = new StringBuilder();//第一级

            //获取目录parentDir下的所有的子文件夹
            string[] dir = Directory.GetDirectories(parentDir);
            for (int i = 0; i < dir.Length; i++)
            {
                //sbstr01.Append(" 一级文件夹：</br>" + dir[i] + "</br>");
                //Common.CreateWebLog("", " 一级文件夹：</br>" + dir[i] + "</br>");//输入内容到文本文件里
                GetAllFiles(dir[i], result);
            }

            //获取目录parentDir下的所有的文件，并过滤得到所有的文本文件
            string[] file = Directory.GetFiles(parentDir, "*");

            for (int i = 0; i < file.Length; i++)
            {
                FileInfo fi = new FileInfo(file[i]);
                //if (fi.Extension.ToLower() == ".htm" || fi.Extension.ToLower() == ".html" || fi.Extension.ToLower() == ".asp" || fi.Extension.ToLower() == ".aspx")
                //{
                //    result.Add(file[i]);
                //}
                sbstr01.Append(" 二级文件夹：</br>" + file[i] + "</br>");

                StreamReader sr = new StreamReader(file[i], System.Text.Encoding.Default);
                string input = sr.ReadToEnd();
                sr.Close();
                string strout = input;
                sbstr01.Append(" 三级文件：</br>" + strout + "</br>");
                result.Add(file[i]);
            }
            //Common.CreateWebLog("", sbstr01.ToString());
            //string str1172 = "";

        }
    }
}
