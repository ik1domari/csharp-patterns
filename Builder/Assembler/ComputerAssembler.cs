using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Assembler
{
    internal class ComputerAssembler
    {
        public ComputerAssembler() { }
        public void AssembleComputer(IComputerBuilder builder)
        {
            builder.BuildCPU();
            builder.BuildRAM();
            builder.BuildStorage();
            builder.BuildGraphicsCard();
            builder.BuildOperatingSystem();
        }
    }
}
