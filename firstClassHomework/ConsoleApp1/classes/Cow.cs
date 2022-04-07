using Animal.classes;
using System;

namespace ConsoleApp1.classes
{
    public class Cow : Animal
    {
        public Cow(int numberOfLegs, bool hasTail, string colorFur, double weight, double height, int lengthOfLife, foodChain eat) : 
            base(numberOfLegs, hasTail, colorFur, weight, height, lengthOfLife, eat)
        {
        }

        public override void Cry()
        {
            Console.WriteLine("The cow is mooing");
        }
        public override void Eats()
        {
            base.Eats();
            Console.WriteLine($"The cow is {Eat} and eats grass");
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("The cow gives milk");
        }
        
    }
}
