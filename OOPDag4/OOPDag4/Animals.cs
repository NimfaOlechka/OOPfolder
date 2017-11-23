using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDag4
{
    interface IAnimals
    {
        string Description();
        //string OtherDescription();

        string Name { get; set;}
    }

    class Lion : IAnimals, IComparable
    {
        private string name;

        public Lion(string name)
        {
            this.name = name;
        }

        public string Description()
        {
            return " I am a Lion and i like meat! My name is " + this.name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int CompareTo(object obj)
        {
            if (obj is IAnimals)
                return this.Name.CompareTo((obj as IAnimals).Name);
            return 0;
        }
    }

    class Monkey: IAnimals
    {
        private string name;

        public Monkey(string name)
        {
            this.name = name;
        }

        public string Description()
        {
            return "i am a monkey and I like banana! My name is " + this.name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //public int CompareTo(object obj)
        //{
        //    if (obj is IAnimals)
        //        return this.Name.CompareTo((obj as IAnimals).Name);
        //    return 0;
        //}

    }
}
