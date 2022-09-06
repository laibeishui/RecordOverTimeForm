using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RecordOverTimeForm.Utils
{
    public static class RegexHelper
    {
        /// <summary>
        /// 通过正则获取两个字符串中间得字符串，之后要移动一个正则表达式帮助类中
        /// </summary>
        /// <param name="sourse"></param>
        /// <param name="startStr"></param>
        /// <param name="endStr"></param>
        /// <returns></returns>
        public static string GetMidStr(this string sourse, string startStr, string endStr)
        {
            Regex rg = new Regex("(?<=(" + startStr + "))[.\\s\\S]*?(?=(" + endStr + "))", RegexOptions.Multiline | RegexOptions.Singleline);
            return rg.Match(sourse).Value;
        }
    }
}
