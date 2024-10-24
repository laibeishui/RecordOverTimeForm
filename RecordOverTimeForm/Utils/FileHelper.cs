using System.IO;

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
