using Builder.Entities;
using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    internal class GamingComputerBuilder : IComputerBuilder
    {
        Computer computer = new();
        public GamingComputerBuilder() { }
        public void BuildCPU()
        {
            this.computer.CPU = "Intel Core i7";
        }

        public void BuildGraphicsCard()
        {
            this.computer.GraphicsCard = "Nvidia Geforce RTX 3060";
        }

        public void BuildOperatingSystem()
        {
            this.computer.OperatingSystem = "Windows";
        }

        public void BuildRAM()
        {
            this.computer.RAM = "16GB";
        }

        public void BuildStorage()
        {
            this.computer.Storage = "SSD + HDD";
        }

        public Computer GetComputer()
        {
            return this.computer;
        }
    }
}
