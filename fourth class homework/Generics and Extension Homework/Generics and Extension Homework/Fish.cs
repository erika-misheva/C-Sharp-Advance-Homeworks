using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_and_Extension_Homework
{
    public class Fish : Pet
    {
        public Fish(string color, int size,string name, string type, int age) : base(name, type, age)
        {
            Color = color;
            Size = size;
        }

        public string Color { get; set; }

        public int Size { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"The pet is a {Type}. It's name is {Name} and is {Age} years old." +
                $" It's color is {Color} and it's size is {Size}");
        }

        
    }
}
