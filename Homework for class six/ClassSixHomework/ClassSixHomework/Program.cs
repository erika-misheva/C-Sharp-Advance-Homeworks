﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassSixHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>()
             {
              new Dog("Charlie", "Black", 3, Race.Collie), // 0
	          new Dog("Buddy", "Brown", 1, Race.Doberman),
              new Dog("Max", "Olive", 1, Race.Plott),
              new Dog("Archie", "Black", 2, Race.Mutt),
              new Dog("Oscar", "White", 1, Race.Mudi),
              new Dog("Toby", "Maroon", 3, Race.Bulldog), // 5
	          new Dog("Ollie", "Silver", 4, Race.Dalmatian),
              new Dog("Bailey", "White", 4, Race.Pointer),
              new Dog("Frankie", "Gray", 2, Race.Pug),
              new Dog("Jack", "Black", 5, Race.Dalmatian),
              new Dog("Chanel", "Black", 1, Race.Pug), // 10
	          new Dog("Henry", "White", 7, Race.Plott),
              new Dog("Bo", "Maroon", 1, Race.Boxer),
              new Dog("Scout", "Olive", 2, Race.Boxer),
              new Dog("Ellie", "Brown", 6, Race.Doberman),
              new Dog("Hank", "Silver", 2, Race.Collie), // 15
	          new Dog("Shadow", "Silver", 3, Race.Mudi),
              new Dog("Diesel", "Brown", 4, Race.Bulldog),
              new Dog("Abby", "Black", 1, Race.Dalmatian),
              new Dog("Trixie", "White", 8, Race.Pointer), // 19
             };

            List<Person> people = new List<Person>()
            {
              new Person("Nathanael", "Holt", 20, Job.Choreographer),
              new Person("Rick", "Chapman", 35, Job.Dentist),
              new Person("Oswaldo", "Wilson", 19, Job.Developer),
              new Person("Kody", "Walton", 43, Job.Sculptor),
              new Person("Andreas", "Weeks", 17, Job.Developer),
              new Person("Kayla", "Douglas", 28, Job.Developer),
              new Person("Richie", "Campbell", 19, Job.Waiter),
              new Person("Soren", "Velasquez", 33, Job.Interpreter),
              new Person("August", "Rubio", 21, Job.Developer),
              new Person("Rocky", "Mcgee", 57, Job.Barber),
              new Person("Emerson", "Rollins", 42, Job.Choreographer),
              new Person("Everett", "Parks", 39, Job.Sculptor),
              new Person("Amelia", "Moody", 24, Job.Waiter)
              { Dogs = new List<Dog>() {dogs[16], dogs[18] } },
              new Person("Emilie", "Horn", 16, Job.Waiter),
              new Person("Leroy", "Baker", 44, Job.Interpreter),
              new Person("Nathen", "Higgins", 60, Job.Archivist)
              { Dogs = new List<Dog>(){dogs[6], dogs[0] } },
              new Person("Erin", "Rocha", 37, Job.Developer)
              { Dogs = new List<Dog>() {dogs[2], dogs[3], dogs[19] } },
              new Person("Freddy", "Gordon", 26, Job.Sculptor)
              { Dogs = new List<Dog>() {dogs[4], dogs[5], dogs[10], dogs[12], dogs[13] } },
              new Person("Valeria", "Reynolds", 26, Job.Dentist),
              new Person("Cristofer", "Stanley", 28, Job.Dentist)
              { Dogs = new List<Dog>() {dogs[9], dogs[14], dogs[15] } }
             };

            //Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER

            Console.WriteLine("All people with names starting with R and in descending order by age\n");

            IEnumerable<Person> peopleWhoseFirstNameStartsWithR = people.Where(x => x.FirstName.StartsWith('R'))
                .OrderByDescending(x => x.Age);

            foreach (Person person in peopleWhoseFirstNameStartsWithR)
            {
                Console.Write($"First name: {person.FirstName}, age {person.Age}\n");
            }

            //● Find and print all brown dogs names and ages older than 3 years,ordered by Age - ASCENDING ORDER

            Console.WriteLine();
            Console.WriteLine("All brown dogs,that are older than 3 years\n");

            IEnumerable<Dog> brownDogsOlderThan3 = dogs.Where(x => x.Color == "Brown" && x.Age > 3)
                .OrderBy(x => x.Age);

            foreach (Dog dog in brownDogsOlderThan3)
            {
                Console.Write($"First name: {dog.Name}, age {dog.Age}, color {dog.Color}\n");
            }

            //● Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER

            IEnumerable<Person> allPersonsWithMoreThan2Dogs = people.Where(x => x.Dogs.Count > 2)
                .OrderByDescending(x => x.FirstName);

            Console.WriteLine();
            Console.WriteLine("People with more than 2 dogs, descending order by name\n");

            foreach (Person person in allPersonsWithMoreThan2Dogs)
            {
                Console.WriteLine($"{person.FirstName} has {person.Dogs.Count} dogs");
            }

            //● Find and print all Freddy`s dogs names older than 1 year

            Console.WriteLine();
            Console.WriteLine("The dogs of Freddy that are older than 1 year\n");

            Person freddy = people.FirstOrDefault(x => x.FirstName == "Freddy");

            var dogsOfFreddy = freddy.Dogs;
            IEnumerable<Dog> freddyDogsOlderThan1 = dogsOfFreddy.Where(x => x.Age > 1);

            foreach (Dog dog in freddyDogsOlderThan1)
            {
                Console.WriteLine($"{dog.Name} is {dog.Age} years old");
            }

            Console.WriteLine();
            Console.WriteLine("Second way\n");
            IEnumerable<Dog> freddyDogsOlderThanOneYear = people.FirstOrDefault(person => person.FirstName == "Freddy")
                .Dogs.Where(dog => dog.Age > 1).ToList();

            foreach(Dog dog in freddyDogsOlderThanOneYear)
            {
                Console.WriteLine(dog.Name);
            }

            //● Find and print Nathen`s first dog

            Console.WriteLine();
            Console.WriteLine("The first dog of Nathen is");

            Person nathen = people.FirstOrDefault(x => x.FirstName == "Nathen");

            Dog firstNathensDog = nathen.Dogs.FirstOrDefault();
            Console.WriteLine($"{firstNathensDog.Name }\n");

            //● Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER
            Console.WriteLine("The names of the white dogs from Cristofer, Freddy, Erin and Amelia are\n");
            List<Person> peopleList = people.Where(x => x.FirstName == "Cristofer" || x.FirstName == "Freddy"
            || x.FirstName == "Erin" || x.FirstName == "Amelia").ToList();

            List<Dog> whiteDogsOfPeopleList = new List<Dog>();

            foreach (Person person in peopleList)
            {
                var whiteDog = person.Dogs.Where(dog => dog.Color == "White").ToList();
                whiteDogsOfPeopleList.AddRange(whiteDog);
            }
            foreach (Dog dog in whiteDogsOfPeopleList.OrderBy(dog => dog.Name))
            {
                Console.WriteLine(dog.Name);
            }

            IEnumerable<Dog> whiteDogs = people.Where(person => person.FirstName == "Cristofer" 
            || person.FirstName == "Freddy"
            || person.FirstName == "Erin" 
            || person.FirstName == "Amelia")
                .Where(person => person.Dogs.Where(dog => dog.Color =="White").Count() > 0)
                .SelectMany(person => person.Dogs);

           

        }
    }
}




