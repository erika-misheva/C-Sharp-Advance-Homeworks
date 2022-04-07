using Animal.classes;
using ConsoleApp1.classes;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Cat-----");
            Cat Stella = new Cat("Stella", "Skopje,Gjorce Petrov", true, 4, true, "black",
                2.5, 23, 13, foodChain.carnivor);

            Stella.PrintInfo();
            Stella.Eats();
            Stella.Cry();
            Stella.Hunt();
            Stella.Sleeps(12);

            Console.WriteLine("----Pinguin----");
            Pinguin pinguin = new Pinguin( 2, true, "black and white",
                25, 110, 20, foodChain.carnivor);

            pinguin.PrintInfo();
            pinguin.Eats();
            pinguin.Cry();
            pinguin.Sleeps(8);

            Console.WriteLine("----Cow----");

            Cow Milka = new Cow(4, true, "black and white", 1500, 135, 15, foodChain.herbivor);
            Milka.PrintInfo();
            Milka.Cry();
            Milka.Eats();
            Milka.Sleeps(6);

            Console.WriteLine("----Dog----");
            Dog Jenny = new Dog("Jenny", "Skopje, Gjorce Petrov", 4, true,
                "Black", 5, 40, 15, foodChain.omnivor);
            Jenny.PrintInfo();
            Jenny.Cry();
            Jenny.Eats();
            Jenny.Sleeps(7);
        }
    }
}
