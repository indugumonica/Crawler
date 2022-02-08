using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Crawler
{
    class BuildDictionary
    {
        public Dictionary<string, int> WordFrequency(string input, HashSet<string> ignorewords)
        {
            Dictionary<string, int> WordOccurances = new Dictionary<string, int>();
            Regex rgx = new Regex("a-zA-Z");
            input = rgx.Replace(input, " ").ToLower();

            string[] words = input.Split(" ");
            foreach(string word in words)
            {
                if (ignorewords.Contains(word))
                {
                    continue;
                }
                if (!WordOccurances.ContainsKey(word))
                {
                    WordOccurances.Add(word, 1);
                }
                else
                {
                    WordOccurances[word]++;
                }
                
            }
            var ordered = WordOccurances.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            return ordered;
        }
    }
}
