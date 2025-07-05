using Adapter.Adapter;
using Adapter.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThirdPartyLoggerAdapter adapter = new ThirdPartyLoggerAdapter();
            MyApplication app = new MyApplication(adapter);
            app.Logger.Log("Logging some shit from Program.cs");
        }
    }
}
