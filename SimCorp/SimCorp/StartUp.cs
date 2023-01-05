using System;
using System.IO;
using WordCounting.Abstractions;

namespace SimCorp
{
    public class StartUp
    {
        private readonly ICounter _counter;
        private readonly IDisplay _display;
        private readonly IReader _reader;

        static string fileName = "TestFile.txt";
        static string destinationFolder = AppDomain.CurrentDomain.BaseDirectory;
        readonly string pathToFile = Path.Combine(destinationFolder, fileName);

        public StartUp(ICounter counter, IDisplay display, IReader reader)
        {
            _counter = counter;
            _display = display; 
            _reader = reader;
        }

        public void StartCountAppFromFileToConsole()
        {
            var data = _reader.Read(pathToFile);
            var sortedData = _counter.WordCountLogic(data);
            _display.Show(sortedData);
        }
    }
}
