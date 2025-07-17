using Command.Entities;
using Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class InsertTextCommand : ICommand
    {
        TextEditor editor;
        string text;
        public InsertTextCommand(TextEditor editor, string text) {
            this.editor = editor;
            this.text = text;
        }
        public void Execute()
        {
            editor.InsertText(text);
        }

        public void Undo()
        {
            
        }
    }
}
