using System;
using System.IO;
using System.Net;
using System.Text.Json;
using static Crawler.FileParser;
using System.Linq;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Crawler
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> excludewordlist = new HashSet<string>();
            excludewordlist.Add("a");
            excludewordlist.Add("or");
            excludewordlist.Add("an");
            excludewordlist.Add("is");
            string urlstring = "https://en.wikipedia.org/w/api.php?format=json&action=query&prop=extracts&explaintext=1&titles=Microsoft";
            int topRequiredWords = 10;
            var result = new Crawler().Crawl(urlstring, topRequiredWords,excludewordlist);
            foreach(var word in result)
            {
                Console.WriteLine(word);
            }







        }
    }

}
