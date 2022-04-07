using Animal.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.classes
{
    public class Pinguin : Animal
    {
        public bool hasWings { get; set; }
        string favFood { get; set; }

        public Pinguin(int numberOfLegs, bool hasTail, string colorFur, double weight, double height, int lengthOfLife, foodChain eat) :
            base(numberOfLegs, hasTail, colorFur, weight, height, lengthOfLife, eat)
        {
        
            hasTail = true;
            hasWings = true;
            favFood = "Fish";
        }

        public override void Cry()
        {
            Console.WriteLine("The pinguing growls");
        }
        public override void Eats()
        {
            Console.WriteLine($"The pinguin is eating his favorite food {favFood}");
            Console.WriteLine($"The pinguin is {Eat}");
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("The pinguin has wings, but can not fly");
            Console.WriteLine($"The avarage life length of one pinguin is {LengthOfLife} years");
            Console.WriteLine("The pingin loves water and can swim");
        }


    }
}
