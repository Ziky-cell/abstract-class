using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artiodactyl artiodactyl = new Artiodactyl();    
            Mammal mammal = new Mammal();
            Bird bird = new Bird();

            mammal.Growth();
            mammal.WarmBlooded();
            mammal.InternalStructure();


            artiodactyl.InternalStructure();
            artiodactyl.Growth();
            artiodactyl.HerbivorousOmnivores();
            artiodactyl.HornsMissing()

            ;
            bird.InternalStructure();
            bird.Growth();
            bird.beak();
            bird.Feathers();
            bird.fly();

            Console.ReadKey();

        }
    }
}
