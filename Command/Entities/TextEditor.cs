using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Entities
{
    internal class TextEditor
    {
        private string text;

        public void InsertText(string text)
        {
            this.text = text;
        }

        public void DeleteLastCharacter() { 
            this.text = this.text.Remove(this.text.Length - 1);
        }

        public string GetText()
        {
            return this.text;
        }
    }
}
