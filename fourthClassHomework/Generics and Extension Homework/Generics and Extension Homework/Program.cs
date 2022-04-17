using System;

namespace Generics_and_Extension_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog jenny = new Dog(true, "Meat", "Jenny", "Dog", 2);
            Dog sparky = new Dog(true, "Wet food", "Sparky", "German Sheperd", 4);

            PetStore<Dog> dogPetStore = new PetStore<Dog>();
            dogPetStore.PetList.Add(jenny);
            dogPetStore.PetList.Add(sparky);

            Cat morgana = new Cat(false, 7, "Morgana", "Cat", 6);
            Cat stella = new Cat(false, 9, "Stella", "Cat", 1);

            PetStore<Cat> catPetStore = new PetStore<Cat>();
            catPetStore.PetList.Add(stella);
            catPetStore.PetList.Add(morgana);

            Fish bob = new Fish("orange", 10, "Bob", "Fish", 6);
            Fish ted = new Fish("purple", 12, "Ted", "Fish", 2);

            PetStore<Fish> fishPetStore = new PetStore<Fish>();
            fishPetStore.PetList.Add(bob);
            fishPetStore.PetList.Add(ted);

            Console.WriteLine("Befor buying pets:\n");

            Console.WriteLine("Fish Store\n");
            fishPetStore.PrintPets();

            Console.WriteLine("\nCat Store\n");
            catPetStore.PrintPets();

            Console.WriteLine("\nDog Store\n");
            dogPetStore.PrintPets();

            Console.WriteLine("After buying pets:\n");

            catPetStore.BuyPet("Stella");
            dogPetStore.BuyPet("Jenny");

            Console.WriteLine("\nFish Store\n");
            fishPetStore.PrintPets();

            Console.WriteLine("\nCat Store\n");
            catPetStore.PrintPets();

            Console.WriteLine("\nDog Store\n");
            dogPetStore.PrintPets();

        }
    }
}
