using System.IO;
using WordCounting.Abstractions;

namespace WordCounting.BL
{
    public class ReadDataFromFile : IReader
    {
        public string Read(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}
