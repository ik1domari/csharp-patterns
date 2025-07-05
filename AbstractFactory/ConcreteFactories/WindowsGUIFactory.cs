using AbstractFactory.Interfaces;
using AbstractFactory.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteFactories
{
    internal class WindowsGUIFactory : IGUIFactory
    {
        public WindowsGUIFactory() { }

        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ITextBox CreateTextBox()
        {
            return new WindowsTextBox();
        }
    }
}
