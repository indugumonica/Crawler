using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Threading;
using System.IO;
using System.ComponentModel;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Crawler
{
    class FileParser
    {
        public string Parsing(string urlstring)
        {
            WebClient client = new WebClient();
            string str;
            string s="star";
            using (Stream stream = client.OpenRead(urlstring))
            using (StreamReader reader = new StreamReader(stream))
            {
                Newtonsoft.Json.JsonSerializer ser = new Newtonsoft.Json.JsonSerializer();
                Result result = ser.Deserialize<Result>(new JsonTextReader(reader));

                foreach (Page page in result.query.pages.Values)
                {
                    str = page.extract;
                    var match = Regex.Match(str, "History ==[\\s\\S]*Corporate affairs ==");
                    s= match.Groups[0].Value;
                }



               

            }
            return s;

            
        }
        

        

    }


}
