using Adapter.Interfaces;
using Adapter.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adapter
{
    internal class ThirdPartyLoggerAdapter : IMyLogger
    {
        ThirdPartyLogger logger = new ThirdPartyLogger();
        public ThirdPartyLoggerAdapter() { }
        public void Log(string message)
        {
            logger.LogMessage(message, LogLevel.INFO);
        }
    }
}
