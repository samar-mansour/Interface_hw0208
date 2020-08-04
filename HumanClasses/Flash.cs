using Interface_hw_0208.SuperHeroInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_hw_0208.HumanClasses
{
    class Flash : Human, IFlash
    {
        public int Voltage { get; private set; }
        public override string Name { get; set; }

        public Flash(string name,int volt, int age):base(name, age)
        {
            Voltage = volt;
        }

        public void ActivateSuperPower()
        {
            FireLightnings();
        }

        public void FireLightnings()
        {
            Console.WriteLine("Fire Lightning");
        }

        public override string ToString()
        {
            return $"Volt age: {this.Voltage}";
        }
    }
}
