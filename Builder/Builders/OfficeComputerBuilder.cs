using Builder.Entities;
using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    internal class OfficeComputerBuilder : IComputerBuilder
    {
        Computer computer = new();
        public OfficeComputerBuilder() { }
        public void BuildCPU()
        {
            this.computer.CPU = "Intel Core i3";
        }

        public void BuildGraphicsCard()
        {
            this.computer.GraphicsCard = null;
        }

        public void BuildOperatingSystem()
        {
            this.computer.OperatingSystem = "Debian";
        }

        public void BuildRAM()
        {
            this.computer.RAM = "4GB";
        }

        public void BuildStorage()
        {
            this.computer.Storage = "256 GB";
        }

        public Computer GetComputer()
        {
            return this.computer;
        }
    }
}
