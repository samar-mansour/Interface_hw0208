using Interface_hw_0208.SuperHeroInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_hw_0208.HumanClasses
{
    class SpiderMan : Human, IClimb
    {
        public int WebLeft { get; private set; }
        public override string Name { get; set; }

        public SpiderMan(string name, int age, int webLeft):base(name, age)
        {
            this.WebLeft = webLeft;
        }

        public void ActivateSuperPower()
        {
            Climb();
        }

        public void Climb()
        {
            Console.WriteLine("Climb");
        }

        public override string ToString()
        {
            return $"Web Left: {this.WebLeft}";
        }
    }
}
