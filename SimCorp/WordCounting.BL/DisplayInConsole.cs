using System;
using System.Collections.Generic;
using WordCounting.Abstractions;

namespace WordCounting.BL
{
    public class DisplayInConsole : IDisplay
    {
        public void Show(IReadOnlyDictionary<string, int> wordCounting)
        {
            foreach (var temp in wordCounting)
            {
                Console.WriteLine("{0}:{1}", temp.Value, temp.Key);
            }
        }
    }
}
