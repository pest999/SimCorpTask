using System;
using System.Collections.Generic;
using WordCounting.Abstractions;

namespace WordCounting.BL
{
    public class CountingLogic : ICounter
    {
        public IReadOnlyDictionary<string, int> WordCountLogic(string input)
        {
            var dic = new Dictionary<string, int>();

            if(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Data from file is empty");
            }

            foreach (var j in input.Split(" "))
            {
                if (dic.ContainsKey(j))
                {
                    dic[j] = dic[j] + 1;
                }
                else
                {
                    dic.Add(j, 1);
                }
            }

            return dic;
        }
    }
}
