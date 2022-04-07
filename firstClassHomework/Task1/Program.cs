using System;
using System.Collections.Generic;


namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfInputNames = new List<string>();
            for (; ;)
            {
                Console.WriteLine("Please enter names. Enter x or X to end.");
                string input = Console.ReadLine();

                if (input == "X" || input == "x")
                {
                    break;
                }

                listOfInputNames.Add(input);
            }
            Console.WriteLine("Please enter an sentence");

            string secondInput = Console.ReadLine();
            string[] secondInputArray = secondInput.Split(' ');

            if (listOfInputNames.Count != 0 || !String.IsNullOrEmpty(secondInput))
            {
                foreach (string name in listOfInputNames)
                {
                    int namesCounter = 0;
                    foreach (string word in secondInputArray)
                    {
                        if (name.ToLower() == word.ToLower())
                        {
                            namesCounter++;
                        }
                    }
                    Console.WriteLine($"For the name {name} there were {namesCounter} matches");
                }
            }
            else
            {
                Console.WriteLine("You haven't enterd names or a sentence");
            }
        }
    }
}
