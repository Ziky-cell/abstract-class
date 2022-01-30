using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Bird : Animal
    {
        public override void Growth()
        {
            Console.WriteLine("Bird - Drowth");
        }
        public override void InternalStructure()
        {
            Console.WriteLine("Bird - InternalStructur");
        }
        public void beak()
        {
            Console.WriteLine("Bird - beak");
        }

        public void Feathers()
        {
            Console.WriteLine("Bird - Feathers");
        }

        public void fly()
        {
            Console.WriteLine("Bird - fly");
        }
    }
}
