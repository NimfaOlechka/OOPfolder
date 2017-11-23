using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            /* make an array for animals and subscribe them to 
             * different subclasses via main class and print greeting*/
            Animal [] animalArray = new Animal [4];
            animalArray[0] = new WildAnimal("Lion");
            animalArray[1] = new WildAnimal("Tiger");
            animalArray[2] = new Herbivores("Elephant");
            animalArray[3] = new Herbivores("Tur");


           for (int i=0; i <animalArray.Length; i++)
            {
               
                   animalArray[i].Greet();
                
                
            }
   

           


            Console.ReadKey();

        }
    }

    
    //main class
    class Animal
    {
        protected string animalType = "unknown";
        protected string food = "something";



        public string GetAnimalType()
        {
            return animalType;
        }
        public void SetAnimalType(string type)
        {
            this.animalType = type;
        }

        public string GetAnimalFood()
        {
            return food;
        }

        public void SetAnimalFood (string food)
        {
            this.food = food;
        }

        public virtual void Greet()
        {
            Console.WriteLine("I'm so perfect!");
        }
    }

    //sub class
    class WildAnimal : Animal
    {
        private string name;

        public WildAnimal(string name)
        {
            animalType = "Wild Animal";
            food = "meat";
            this.name = name;

        }


        public override void Greet()
        {
            base.Greet();
            Console.WriteLine("{0} is a {1} and it likes {2}", name, animalType, food);

        }
        
    }

    

    //sub class
    class Herbivores : Animal
    {
        private string name;

        public Herbivores(string name)
        {
            animalType = "herbivores";
            food = "grass";
            this.name = name;
        }

        public override void Greet()
        {
            base.Greet();
            Console.WriteLine("{0} is a {1} and it likes {2}", name, animalType, food);

        }


    }

        
    
}
