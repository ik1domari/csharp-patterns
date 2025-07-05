using Adapter.Adapter;
using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Application
{
    internal class MyApplication
    {
        public IMyLogger Logger { get; set; }
        public MyApplication(ThirdPartyLoggerAdapter adapter) {
            this.Logger = adapter;
        }
    }
}
