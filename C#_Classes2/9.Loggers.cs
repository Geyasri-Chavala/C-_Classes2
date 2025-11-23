using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpClasses_Step2
{
    static class Logger
    {
        // Fields
        static string _logFile = "application1.txt";
        static string _logDesc = "You logged in on Mar-05-2025 at 1:00 PM";

        // Property
        static string LogFile { get; set; }

        // Static Constructor
        static Logger()
        {
            LogFile = _logFile;
        }

        // Logging Methods
        static void Log(string level, string message)
        {
            Console.WriteLine($"{DateTime.Now} : {level} : {message}");
        }

        static void Info(string message) => Log("INFO", message);
        static void Warn(string message) => Log("WARN", message);
        static void Error(string message) => Log("ERROR", message);

        // Main Method
        static void Main()
        {
            Console.WriteLine($"Log file field: {_logFile}");
            Console.WriteLine($"Log description: {_logDesc}");
            Console.WriteLine($"Log file property: {LogFile}");

            Info("Application Started");
            Warn("Wrong password! One more attempt will lock the account.");
            Error("Something went wrong. Please check.");
            Info("Application Stopped");
        }
    }
}