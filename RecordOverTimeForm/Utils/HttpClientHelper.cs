using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RecordOverTimeForm.Utils
{
    public class HttpClientHelper
    {

        /// <summary>
        /// get
        /// </summary>
        /// <param name="url"></param>
        /// <param name="content">query 参数</param>
        /// <param name="requestHeaders">请求头可以为null</param> 
        /// <returns></returns>
        public string Get(string url, Dictionary<string, string> content = null, Dictionary<string, string> requestHeaders = null)
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                var client = HttpClientBuilder.GetClient();
                var allUrl = FormatUrl(url, content);
                HttpRequestMessage httpRequestMessage = new HttpRequestMessage
                {
                    RequestUri = new Uri(allUrl),
                    Method = HttpMethod.Get
                };
                AddHeaders(httpRequestMessage, requestHeaders);
                var response = client.SendAsync(httpRequestMessage).Result;
                var data = response.Content.ReadAsStringAsync().Result;

                if (stopwatch.ElapsedMilliseconds >= 500)
                {
                    //Log4NetHelper.WarnFormat("对外请求操过500ms,请求时长:{0}ms,url:{1},requestHeaders:{2},返回结果:{3}",
                    //                stopwatch.ElapsedMilliseconds, allUrl, JsonConvert.SerializeObject(requestHeaders), data);
                } 

                return data;
            }
            catch (Exception ex)
            {
                //Log4NetHelper.ErrorLog($"Get 请求出错,errormsg:{ex.Message},url:{FormatUrl(url, content)},requestHeaders:{JsonConvert.SerializeObject(requestHeaders)}", ex);
                throw;
            }
        }

        /// <summary>
        /// post
        /// </summary>
        /// <param name="url"></param>
        /// <param name="httpContent"></param>
        /// <param name="requestHeaders">请求头可以为null</param>
        /// <returns></returns>
        public string Post(string url, HttpContent httpContent, Dictionary<string, string> requestHeaders = null)
        {
            var httpContentResult = httpContent.ReadAsStringAsync().Result;
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                var client = HttpClientBuilder.GetClient();
                HttpRequestMessage httpRequestMessage = new HttpRequestMessage
                {
                    RequestUri = new Uri(url),
                    Method = HttpMethod.Post,
                    Content = httpContent
                };
                AddHeaders(httpRequestMessage, requestHeaders);
                var response = client.SendAsync(httpRequestMessage).Result;
                var result = response.Content.ReadAsStringAsync().Result;

                if (stopwatch.ElapsedMilliseconds >= 500 && !IgnoreLog(url))
                {
                   // Log4NetHelper.WarnFormat("对外请求操过500ms,请求时长:{0}ms,url:{1},请求参数:{2},requestHeaders:{3},返回结果:{4}",
                    //    stopwatch.ElapsedMilliseconds, url, httpContentResult, JsonConvert.SerializeObject(requestHeaders), result);
                }
                return result;
            }
            catch (Exception ex)
            {
                //Log4NetHelper.ErrorLog($"Post 请求出错,errormsg:{ex.Message},url:{url},httpContent:{httpContentResult},requestHeaders:{JsonConvert.SerializeObject(requestHeaders)}", ex);
                throw;
            }
        }

        public void DownLoad(string url, string resultPath)
        {
            try
            {
                var client = HttpClientBuilder.GetClient();
                HttpRequestMessage httpRequestMessage = new HttpRequestMessage
                {
                    RequestUri = new Uri(url),
                    Method = HttpMethod.Get
                };
                var response = client.SendAsync(httpRequestMessage).Result;
                if (response.StatusCode != HttpStatusCode.OK) throw new HttpRequestException($"{JsonConvert.SerializeObject(response)}");

                var content = response.Content.ReadAsByteArrayAsync().Result;
                using (var file = new FileStream(resultPath, FileMode.CreateNew))
                    file.Write(content, 0, content.Length);

            }
            catch (Exception ex)
            {
                //Log4NetHelper.ErrorLog($"DownLoad 请求出错,errormsg:{ex.Message},url:{url}", ex);
                throw;
            }
        }

        /// <summary>
        /// 将get请求的参数附加到url
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private string FormatUrl(string url, Dictionary<string, string> content)
        {
            StringBuilder fmtUrl = new StringBuilder(url);
            if (content != null && content.Count > 0)
            {
                fmtUrl.Append("?");
                foreach (var item in content)
                {
                    fmtUrl.Append(item.Key + "=" + item.Value + "&");
                }
                return fmtUrl.ToString().TrimEnd('&');
            }
            return fmtUrl.ToString();
        }

        /// <summary>
        /// 添加请求头
        /// </summary>
        private void AddHeaders(HttpRequestMessage httpRequestMessage, Dictionary<string, string> requestHeaders)
        {
            httpRequestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (requestHeaders != null && requestHeaders.Count > 0)
            {
                foreach (var item in requestHeaders)
                {
                    httpRequestMessage.Headers.Add(item.Key, item.Value);
                }
            }
        }

        private bool IgnoreLog(string url)
        {
            var makepaper = "/Api/IntelligentExamination/GetItem";
            var replace = "/Api/IntelligentExamination/ReplaceItem";
            var ignoreurl = new List<string>() { makepaper, replace };
            foreach (var item in ignoreurl)
            {
                if (url.Contains(item))
                {
                    return true;
                }
            }
            return false;
        }
    }


    internal class HttpClientBuilder
    {
        private static HttpClient httpClient;

        private static readonly object locker = new object();

        private HttpClientBuilder() { }

        public static HttpClient GetClient()
        {
            if (httpClient == null)
            {
                lock (locker)
                {
                    if (httpClient == null)
                    {
                        var handler = new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate };
                        httpClient = new HttpClient(handler)
                        {
                            Timeout = System.TimeSpan.FromMinutes(10)
                        };
                    }
                }
            }
            return httpClient;
        }
    }
}
