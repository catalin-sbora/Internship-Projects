using PersonsList.Abstractions;

namespace PersonsList.DefaultImplementation
{
    public class ConsoleDisplayDevice : IDisplayDevice
    {
        public void DisplayText(string textToDisplay)
        {
            Console.WriteLine(textToDisplay);
        }
    }
}