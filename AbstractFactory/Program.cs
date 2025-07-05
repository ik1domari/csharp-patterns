using AbstractFactory.ConcreteFactories;
using AbstractFactory.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var os = Environment.OSVersion;
            if (os.ToString().Contains("Windows"))
            {
                WindowsGUIFactory factory = new WindowsGUIFactory();
                Application app = new Application(factory);
                app.CreateUI();
                app.RenderUI();
            }
            else
            {
                MacOSGUIFactory factory = new MacOSGUIFactory();
                Application app = new Application(factory);
                app.CreateUI();
                app.RenderUI();
            }
        }
    }
}
