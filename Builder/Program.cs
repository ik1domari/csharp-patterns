using Builder.Assembler;
using Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ComputerAssembler assembler = new();
                Console.WriteLine(
                    "Choose computer type: \n" +
                    "1. Home computer\n" +
                    "2. Gaming computer\n" +
                    "3. Office computer\n" +
                    "4. Quit\n"
                    );

                int.TryParse(Console.ReadLine(), out int choice);

                if (choice == 1)
                {
                    var builder = new HomeComputerBuilder();
                    assembler.AssembleComputer(builder);
                    builder.GetComputer().DisplayConfiguration();
                }
                else if (choice == 2)
                {
                    var builder = new GamingComputerBuilder();
                    assembler.AssembleComputer(builder);
                    builder.GetComputer().DisplayConfiguration();
                }
                else if (choice == 3)
                {
                    var builder = new OfficeComputerBuilder();
                    assembler.AssembleComputer(builder);
                    builder.GetComputer().DisplayConfiguration();
                }
                else if (choice == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                }
            }
         }
     }
}
