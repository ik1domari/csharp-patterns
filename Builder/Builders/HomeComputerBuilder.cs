using Builder.Entities;
using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    internal class HomeComputerBuilder : IComputerBuilder
    {
        Computer computer = new();
        public HomeComputerBuilder() { }
        public void BuildCPU()
        {
            this.computer.CPU = "Intel Core i5";
        }

        public void BuildGraphicsCard()
        {
            this.computer.GraphicsCard = "Nvidia Geforce GTX 1050";
        }

        public void BuildOperatingSystem()
        {
            this.computer.OperatingSystem = "Windows";
        }

        public void BuildRAM()
        {
            this.computer.RAM = "8GB";
        }

        public void BuildStorage()
        {
            this.computer.Storage = "500GB";
        }

        public Computer GetComputer()
        {
            return this.computer;
        }
    }
}
