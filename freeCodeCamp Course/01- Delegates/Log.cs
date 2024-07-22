using System;
using System.IO;

namespace DelegateExample
{
    public class Log
    {
        public void LogTextToScreen(string message)
        {
            Console.WriteLine($"{DateTime.Now}: {message}");
        }

        public void LogTextToFile(string message)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
            {
                sw.WriteLine($"{DateTime.Now}: {message}");
            }
        }
    }
}