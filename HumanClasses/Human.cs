using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_hw_0208.HumanClasses
{
    abstract class Human
    {
        public abstract string Name { get; set;}
        private int age;

        public int GetAge()
        {
            return this.age;
        }

        protected Human(string name, int age)
        {
            Name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name} Age: {this.GetAge()}";
        }
    }
}
