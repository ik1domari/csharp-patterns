using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Entities
{
    internal class Computer
    {
        public string CPU;
        public string RAM;
        public string Storage;
        public string? GraphicsCard;
        public string? OperatingSystem;

        public void DisplayConfiguration()
        {
            string configuration = 
                $"CPU: {CPU}\n" +
                $"RAM: {RAM}\n" +
                $"Storage: {Storage}\n" +
                (GraphicsCard != null ? $"Graphics card: {GraphicsCard}\n" : "") +
                (OperatingSystem != null ? $"Operating System: {OperatingSystem}\n" : "");

            Console.WriteLine(configuration);
        }
    }
}
