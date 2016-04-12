using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Animals;


namespace Zoolandia
{ 
    class Zoolandia
    {
        static void Main(string[] args)
        {
            Animal firstAnimal = new Animal(args[0]);
            firstAnimal.species = new UrsusAmericanus();

            Console.WriteLine("{0} the {1}", firstAnimal.name, firstAnimal.species.commonName);
        }
    }

}