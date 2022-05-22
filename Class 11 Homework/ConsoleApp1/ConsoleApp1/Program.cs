using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog jenny = CreateDog();

            string currentDirectory = Directory.GetCurrentDirectory();
            string appPath = @"..\..\..\";

            string memoryFolder = appPath + "/memoryFolder";
            if (!Directory.Exists(memoryFolder))
            {
                Directory.CreateDirectory(memoryFolder);
            }

            string dogFile = memoryFolder + "/dogFile";
            if (!File.Exists(dogFile))
            {
                File.Create(dogFile).Close();
            }

            File.WriteAllText(dogFile, SerilazeDog(jenny));
            string jsonDog = File.ReadAllText(dogFile);

            Dog deserilazedDog = DeserilazeDog(jsonDog);

            DisplayDog(deserilazedDog);

        }

        private static Dog CreateDog()
        {
            Console.WriteLine("Let's make an object Dog. Please input the name, color and the age");
            Dog dog = new Dog();
            dog.Name = Console.ReadLine().Trim();
            dog.Color = Console.ReadLine().Trim();
            int.TryParse(Console.ReadLine(), out int age);
            dog.Age = age;

            Console.WriteLine("Huray, we have created an dog!");
            Console.WriteLine($"The dog's name is {dog.Name}, it is {dog.Color} and has {dog.Age} years");

            return dog;

        }
        private static string SerilazeDog(Dog dog)
        {
            string json = "{";
            json += $"\"Name\" : {dog.Name} , ";
            json += $"\"Color\" : {dog.Color} , ";
            json += $"\"Age\" : {dog.Age} ";
            json += "}";
            return json;

        }

        private static Dog DeserilazeDog(string serilazedDog)
        {
           string serilazedDogSaved =   serilazedDog.
                Substring(serilazedDog.IndexOf("{") + 1, serilazedDog.IndexOf("}") - 1)
                .Replace("\r", "")
                .Replace("\n", "")
                .Replace("\"", "");

                 string[] properties = serilazedDogSaved.Split(',');

            Dictionary<string, string> propertiesDictionary =
            new Dictionary<string, string>();
            foreach (string property in properties)
            {
                string[] pair = property.Split(':');
                propertiesDictionary.Add(pair[0].Trim(), pair[1].Trim());
            }

            Dog dog = new Dog();
            dog.Name = propertiesDictionary["Name"];
            dog.Color = propertiesDictionary["Color"];
            dog.Age = int.Parse(propertiesDictionary["Age"]);

            return dog;

        }
        private static void DisplayDog(Dog dog)
        {
            Console.WriteLine($"Name : {dog.Name}");
            Console.WriteLine($"Color : {dog.Color}");
            Console.WriteLine($"Age : {dog.Age}");
        }
    }

}
