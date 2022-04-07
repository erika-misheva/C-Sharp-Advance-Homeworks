using Animal.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.classes
{
    public class Animal
    {
        public int NumberOfLegs { get; set; }
        public bool HasTail { get; set; }
        public string ColorFur { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int LengthOfLife { get; set; }
        public foodChain Eat { get; set; }
        public void Moves()
        {
            Console.WriteLine("The animal is moving");
        }
        public virtual void Eats()
        {
            Console.WriteLine("The animal is eating");
        }
        public void Sleeps(int hoursOfSleeping)
        {
            Console.WriteLine($"The animal is sleeping {hoursOfSleeping} hours a day");
        }
        public virtual void Cry()
        {
            Console.WriteLine("The animal is making noices");
        
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"The animal's weight is {Weight} kg and height is {Height} cm. It has {NumberOfLegs} legs.");

        }

        public Animal(int numberOfLegs, bool hasTail, string colorFur, double weight, double height, int lengthOfLife, foodChain eat)
        {
            NumberOfLegs = numberOfLegs;
            HasTail = hasTail;
            ColorFur = colorFur;
            Weight = weight;
            Height = height;
            LengthOfLife = lengthOfLife;
            Eat = eat;
        }


    }
}
