using Animal.classes;
using System;

namespace ConsoleApp1.classes
{
    public class Dog : Animal
    {
        public bool WantsToPlay { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public Dog(string name, string adress, int numberOfLegs, bool hasTail, string colorFur, double weight, double height, int lengthOfLife, foodChain eat) :
            base(numberOfLegs, hasTail, colorFur, weight, height, lengthOfLife, eat)
        {
            Name = name;
            Adress = adress;
            WantsToPlay = true;
        }

        public override void Cry()
        {
            Console.WriteLine($"The dog {Name} is barking");
        }
        public override void Eats()
        {
            base.Eats();
            Console.WriteLine($"The animal {Eat}");
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"The dog's name is {Name} and adress is {Adress}.");
        }

    }
}


