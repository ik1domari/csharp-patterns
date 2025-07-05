using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.UI
{
    internal class MacOSButton : IButton
    {
        public MacOSButton() { }
        public void Render()
        {
            Console.WriteLine("Rendering a macOS button");
        }
    }
}
