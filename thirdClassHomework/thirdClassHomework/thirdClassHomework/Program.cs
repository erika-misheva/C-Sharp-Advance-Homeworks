using System;
using System.Collections.Generic;

namespace thirdClassHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog jenny = new Dog()
            {
                Name = "Jenny",
                Id = 1,
                Color = "Black"
            };
            Dog sparky = new Dog()
            {
                Id = 2,
                Name = "Sparky",
                Color = "White"
            };
            Dog reks = new Dog()
            {
                Id = 3,
                Color = "Gray",
                Name = "Reks"
            };
            Dog.Validate(jenny);
            Dog.Validate(reks);
            Dog.Validate(sparky);
            
            DogShelter.Dogs = new List<Dog>()
            {
                jenny,
                sparky,
                reks
            };

            DogShelter.PrintAll(DogShelter.Dogs);
            
        }
    }
}
