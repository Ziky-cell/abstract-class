using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Mammal : Animal
    {
        public override void Growth()
        {
            Console.WriteLine("Mammal - Drowth");
        }
        public override void InternalStructure()
        {
            Console.WriteLine("Mammal - InternalStructur");
        }

        public void WarmBlooded()
        {
            Console.WriteLine("Mammal - WarmBlooded");
        }



    }
}
