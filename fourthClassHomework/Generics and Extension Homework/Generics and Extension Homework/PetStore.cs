using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics_and_Extension_Homework
{
    public class PetStore<T> where T : Pet
    {
        public List<T> PetList = new List<T>();

        public void PrintPets()
        {
            foreach (T item in PetList)
            {
                item.PrintInfo();
            }
        }

        public  void BuyPet(string name)
        {
            var foundPetName = PetList.FirstOrDefault(p => p.Name == name);
            if (foundPetName == null)
            {
                Console.WriteLine("There is no such pet");
            } else
            {
                PetList.Remove(foundPetName);
                Console.WriteLine($"You have found your pet, Its name is {name}");
            }
        }

    }
}
