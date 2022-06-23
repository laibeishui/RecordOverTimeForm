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

        /// <summary>
        /// 创建文件
        /// </summary>
        /// <param name="filePath"></param>
        public static void CrateFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                FileStream newText = File.Create(filePath);
                newText.Close();
            }
        }


        /// <summary>
        ///  创建文件夹
        /// </summary>
        /// <param name="path"></param>
        public static void CreateDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
