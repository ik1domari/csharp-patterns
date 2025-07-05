using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.UI
{
    internal class Application
    {
        public IGUIFactory factory;
        public IButton button = null;
        public ITextBox textBox = null;
        public Application(IGUIFactory factory)
        {
            this.factory = factory;
        }

        public void CreateUI()
        {
            this.button = this.factory.CreateButton();
            this.textBox = this.factory.CreateTextBox();
        }

        public void RenderUI()
        {
            this.button.Render();
            this.textBox.Render();
        }
    }
}
