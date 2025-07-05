using AbstractFactory.Interfaces;
using AbstractFactory.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteFactories
{
    internal class MacOSGUIFactory : IGUIFactory
    {
        public MacOSGUIFactory() { }
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public ITextBox CreateTextBox()
        {
            return new MacOSTextBox();
        }
    }
}
