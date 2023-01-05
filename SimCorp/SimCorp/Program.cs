using WordCounting.BL;

namespace SimCorp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReadDataFromFile readDataFromFile = new ();
            CountingLogic countingLogic = new ();
            DisplayInConsole inConsole = new ();

            StartUp startUp = new StartUp(countingLogic, inConsole , readDataFromFile);
            startUp.StartCountAppFromFileToConsole();
        }
    }
}
