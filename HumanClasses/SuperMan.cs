using Interface_hw_0208.SuperHeroInterfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_hw_0208.HumanClasses
{
    class SuperMan : Human, IFly
    {
        public int Speed { get; private set; }
        public override string Name { get; set; }

        public SuperMan(int age, string name, int Speed):base(name, age)
        {
            this.Speed = Speed;
            this.Name = name;
        }
        public void ActivateSuperPower()
        {
            Fly();
        }

        public void Fly()
        {
            Console.WriteLine("Fly");
        }

        public override string ToString()
        {
            return $"Speed: {this.Speed}";
        }
    }
}
