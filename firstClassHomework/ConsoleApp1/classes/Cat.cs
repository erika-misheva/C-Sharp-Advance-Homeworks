using Animal.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.classes
{
    public class Cat : Animal
    {
        public string Name { get; set; }

        public string Adress { get; set; }

        public bool WantsToPlay { get; set; }


        public Cat (string name, string adress,bool wantsToPlay, int numberOfLegs, bool hasTail, string colorFur, double weight, double height, int lengthOfLife, foodChain eat):
            base(numberOfLegs, hasTail, colorFur, weight, height, lengthOfLife, eat)

        {
            WantsToPlay = wantsToPlay;
            Name = name;
            Adress = adress;
        }

        public override void Cry()
        {
            Console.WriteLine("The cat miaows");
        }
        public void Hunt()
        {
            Console.WriteLine($"The cat {Name} is hunting");
        }
        public override void Eats()
        {
            base.Eats();
            Console.WriteLine($"The animal is {Eat}.");
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"The Cat's name is {Name} and adress is {Adress}");
            Console.WriteLine($"The avarage life length of one cat is {LengthOfLife} years");
        }
    }
}
