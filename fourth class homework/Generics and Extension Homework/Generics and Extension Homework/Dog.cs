using System;

namespace Generics_and_Extension_Homework
{
    public class Dog : Pet
    {
        public Dog(bool isgoodboi, string favoritefood,string name, string type, int age) : base(name, type, age)
        {
            isGoodBoi = isgoodboi;
            FavoriteFood = favoritefood;
        }

        public bool isGoodBoi { get; set; }
        public string FavoriteFood { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"The pet is a {Type}. It's name is {Name} and is {Age} years old");
            if (isGoodBoi == true)
            {
                Console.WriteLine("This dog is a good boy");
            }
            else
            {
                Console.WriteLine("This dog is bad dog");
            }
            Console.WriteLine($"It's favorite food is {FavoriteFood}");
        }
     
        
    }
}
