
using Interface_hw_0208.HumanClasses;
using Interface_hw_0208.SuperHeroInterfaces;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_hw_0208
{
    class Program
    {
        static void ActivateHero(ISuperHero superHero)
        {
            superHero.ActivateSuperPower();
        }

        static void IdentifyHero(ISuperHero hero)
        {
            if (hero is Flash)
            {
                Console.WriteLine("Flsh detected");
            }
            else if (hero is SuperMan)
            {
                Console.WriteLine("Superman detected");
            }
            else if (hero is SpiderMan)
            {
                Console.WriteLine("Spiderman detected");
            }
            else
            {
                Console.WriteLine($"There's no super power such, {hero.GetType()}");
            }
        }

        static void GetMoreHeroData(ISuperHero super)
        {
            Flash flash = super as Flash;
            if (flash != null)
            {
                Console.WriteLine(flash.Voltage);
            }
            else
            {
                SpiderMan spider = super as SpiderMan;
                if (spider != null)
                {
                    Console.WriteLine(spider.WebLeft);
                }
                else
                {
                    SuperMan superMan = super as SuperMan;
                    if (superMan != null)
                    {
                        Console.WriteLine(superMan.Speed);
                    }
                    else
                    {
                        Console.WriteLine($"No Such as {super} power");
                    }
                }
            }
        }

        static ISuperHero CreatHero(string word)
        {
            switch (word)
            {
                case "Flash":
                    return new Flash("Fydee",6000, 18);
           
                case "SuperMan":
                    return new SuperMan(25, "Ernesto", 300);
                case "SpiderMan":
                    return new SpiderMan("Tim", 35, 45);
                default:
                    return null;
            }
        }
        static void Main(string[] args)
        {
            SuperMan superMan = new SuperMan(25, "Ernesto", 300);
            SpiderMan spiderMan = new SpiderMan("Tim", 35, 45);
            Flash flash = new Flash("Fydee",6000, 18);
            
            ISuperHero[] superHeroes = new ISuperHero[3]
            {
                superMan, spiderMan, flash
            };

            foreach (ISuperHero item in superHeroes)
            {
                ActivateHero(item);
            }

            Console.WriteLine(CreatHero("Bam"));

            GetMoreHeroData(superMan);
            IdentifyHero(spiderMan);
        }
    }
}
