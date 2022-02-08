using System;
using System.Collections.Generic;
using System.Text;

namespace Crawler
{
    public class Crawler
    {

        
        public List<KeyValuePair<string,int>> Crawl(string urlstring, int FirstLargestOccurances, HashSet<string> WordsToExclude)
        {

            
            
            var urldata = new FileParser().Parsing(urlstring);

            Dictionary<string, int> output = new Dictionary<string, int>();
            List<KeyValuePair<string, int>> result = new List<KeyValuePair<string, int>>();
            output = new BuildDictionary().WordFrequency(urldata, WordsToExclude);

            int index = FirstLargestOccurances;
            foreach (var word in output)
            {
                result.Add(word);
                index--;
                if (index == 0)
                {
                    break;
                }
            }
            return result;
        }
    }
}
