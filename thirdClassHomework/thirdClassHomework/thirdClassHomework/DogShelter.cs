using System;
using System.Collections.Generic;

namespace thirdClassHomework
{
    public static class DogShelter
    {
        public static List<Dog> Dogs { get; set; }
        public static void PrintAll(List<Dog> shelterDogs)
        {
            foreach(Dog dog in shelterDogs)
            {
                Console.WriteLine(dog.ToString());
            }
         
        }
    }
}
