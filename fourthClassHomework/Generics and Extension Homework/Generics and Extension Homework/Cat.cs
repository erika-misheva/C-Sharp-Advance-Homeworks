using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_and_Extension_Homework
{
    public class Cat : Pet
    {
        public Cat(bool lazy, int livesleft, string name, string type, int age) : base(name, type, age)
        {
            Lazy = lazy;
            LivesLeft = livesleft;
        }
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"The pet is a {Type}. It's name is {Name} and is {Age} years old." +
                $" He/She has {LivesLeft} lives left");
            if (Lazy == true)
            {
                Console.WriteLine("This cat is very lazy");
            } else
            {
                Console.WriteLine("This cat is not at all lazy");
            }
        
        }
    }
}
