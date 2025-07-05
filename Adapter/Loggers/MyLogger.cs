using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Loggers
{
    internal class MyLogger : IMyLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"MyLogger message: {message}");
        }
    }
}
