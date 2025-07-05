using AbstractFactory.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    internal interface IGUIFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
