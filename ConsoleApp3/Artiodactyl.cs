using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Artiodactyl : Animal
    {
        public override void Growth()
        {
            Console.WriteLine("Artiodactyl - Drowth");
        }
        public override void InternalStructure()
        {
            Console.WriteLine("Artiodactyl - InternalStructur");
        }
        public  void HerbivorousOmnivores()
        {
            Console.WriteLine("Artiodactyl - HerbivorousOmnivores");
        }
        
        public void HornsMissing()
        {
            Console.WriteLine("Artiodactyl - horns are missing");
        }

    }
}
