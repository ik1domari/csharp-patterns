using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Loggers
{
    internal enum LogLevel
    {
        INFO, WARNING, ERROR
    }
    internal class ThirdPartyLogger
    {
        public ThirdPartyLogger() { }
        public void LogMessage(string message, LogLevel level)
        {
            Console.WriteLine($"Log level: {level}, message: {message}");
        }
    }
}
