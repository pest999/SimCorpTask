using System;
using System.Collections.Generic;
using System.IO;

namespace SimCorp
{
    internal class Program
    {

        static Dictionary<string, int> objdict;

        static void Main(string[] args)
        {
        string fileName = "TestFile.txt";
        string destinationFolder = AppDomain.CurrentDomain.BaseDirectory;
        string pathToFile = Path.Combine(destinationFolder, fileName);

        Open(pathToFile);
        }

        static void Open(string pathToFile)
        {

            using (StreamReader reader = new StreamReader(pathToFile))
            {
                string text = reader.ReadToEnd();
                CountingWord(text);
                ShowCountingResult();
            }
        }

        static void ShowCountingResult()
        {
            foreach (var temp in objdict)
            {
                Console.WriteLine("{0}:{1}", temp.Value, temp.Key);
            }
        }

        static void CountingWord(string input)
        {
            objdict = new Dictionary<string, int>();
            foreach (var j in input.Split(" "))
            {
                if (objdict.ContainsKey(j))
                {
                    objdict[j] = objdict[j] + 1;
                }
                else
                {
                    objdict.Add(j, 1);
                }
            }
        }
    }
}
