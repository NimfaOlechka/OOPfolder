using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDag4
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Lion> lions = new List<Lion>();
            lions.Add(new Lion("Georg"));
            lions.Add(new Lion("Max"));
            lions.Add(new Lion("Rex"));
            lions.Add(new Lion("Alex"));

            lions.Sort();

            foreach (Lion lion in lions)
                Console.WriteLine(lion.Description());

            List<Monkey> monkeys = new List<Monkey>();
            monkeys.Add(new Monkey("Georg"));
            monkeys.Add(new Monkey("Chika"));
            monkeys.Add(new Monkey("Raa"));

            foreach (Monkey monkey in monkeys)
                Console.WriteLine(monkey.Description());

            List<IAnimals> animals = new List<IAnimals>();
            animals.Add(new Lion("Alex"));
            animals.Add(new Monkey("Alex"));
            int count = 0;

            foreach (IAnimals animal in animals)
            {
                if (animal.Name == "Alex")
                {
                    count ++;
                    Console.WriteLine(animal.Description());

                }
               
                
            }

            Console.Write("there are {0} Alex in our Zoo.", count);
            Console.ReadKey();
        }
    }
}
