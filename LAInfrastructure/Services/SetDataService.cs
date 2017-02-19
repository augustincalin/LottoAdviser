using LACore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using LACore.Model;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections;

namespace LAInfrastructure.Services
{
    public class SetDataServiceOptions
    {
        public string MissingUrl { get; set; }
        public string OccurenciesUrl { get; set; }
        public string MissingRegex { get; set; }
        public string OccurenciesRegex { get; set; }
    }
    public class SetDataService : ISetDataService
    {
        private SetDataServiceOptions _options;
        private HttpWebRequest _webRequest;
        public SetDataService(SetDataServiceOptions options)
        {
            _options = options;
        }


        public void SetMissing(IList<Number> numbers)
        {
            int dayOfWeek = (int)DateTime.Now.DayOfWeek;
            int drawingDay = 0 <= dayOfWeek && dayOfWeek < 4 ? 1 : 0;

            ProcessMissing(numbers, _options.MissingUrl, drawingDay, true);
            ProcessMissing(numbers, _options.MissingUrl, 1 - drawingDay, false);
        }

        private void ProcessMissing(IList<Number> numbers, string url, int drawingDay, bool isClosest)
        {
            string page = GetPageAsync(url, "POST", $"drawingday={drawingDay}").Result;
            Regex r = new Regex(_options.MissingRegex, RegexOptions.Singleline);
            int i = 0;
            foreach (Match m in r.Matches(page))
            {
                string val = m.Groups[2].Value.Replace(" ", "").Replace("x", "").Replace("Aktuell", "0");
                int valueToInsert = Convert.ToInt32(val);
                if (isClosest)
                {
                    numbers[i].NotSeen = valueToInsert;
                } else
                {
                    int closestValue = numbers[i].NotSeen.Value;
                    if(valueToInsert < closestValue)
                    {
                        numbers[i].NotSeen = (valueToInsert + 1) * 2 - 1;
                    } else
                    {
                        numbers[i].NotSeen = 2 * closestValue;
                    }
                }
                i++;
            }
        }

        public void SetOccurences(IList<Number> numbers)
        {
            string page = GetPageAsync(_options.OccurenciesUrl, "GET", null).Result;
            Regex r = new Regex(_options.OccurenciesRegex, RegexOptions.Singleline);
            MatchCollection matches = r.Matches(page);
            int i = 0;
            foreach (Match m in matches)
            {
                numbers[i].Occurencies = Convert.ToInt32(m.Groups[2].Value);
                i++;
            }
        }

        private async Task<string> GetPageAsync(string url, string method, string content)
        {
            string result = null;
            WebRequest request = WebRequest.Create(url);
            request.Method = method;
            if (!string.IsNullOrEmpty(content))
            {
                byte[] data = Encoding.UTF8.GetBytes(content);
                request.ContentType = "application/x-www-form-urlencoded";
                Stream dataStream = await request.GetRequestStreamAsync();
                dataStream.Write(data, 0, data.Length);
            }
            request.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.79 Safari/537.36 Edge/14.14393";
            using (WebResponse response = await request.GetResponseAsync())
            {
                Stream dataStream = response.GetResponseStream();
                using (StreamReader reader = new StreamReader(dataStream))
                {
                    result = reader.ReadToEnd();
                }
            }

            return result;
        }
    }
}
