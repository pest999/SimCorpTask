using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        // a.	“asd234www22”, 2     =>2,4
        // b.  “ww21as46”,3         =>6
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }

        static int[] SelectValue(string inputString, int value)
        {
            if(String.IsNullOrEmpty(inputString))
            {
                Console.WriteLine("fignya");
            }
            List<int> listValue= new();
            foreach (char c in inputString)
            {
                if(Char.IsNumber(c))
                {
                    if(c%value==0)
                    {
                        listValue.Add(c);
                    }
                }
            }
            var newArr = listValue.ToArray();

            return newArr;
        }
    }
}
