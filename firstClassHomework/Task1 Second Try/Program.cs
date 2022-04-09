using System;
using System.Collections.Generic;
using System.Linq;


namespace Task1_Second_Try
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfInputNames = new List<string>();
            for (; ; )
            {
                Console.WriteLine("Please enter names. Enter x or X to end.");
                string input = Console.ReadLine();

                if (input == "X" || input == "x" || string.IsNullOrEmpty(input))
                {
                    break;
                }

                listOfInputNames.Add(input);
            }
            Console.WriteLine("Please enter an sentence");

            string sentence = Console.ReadLine();

            List<string> listOfTheWordsInTheSentence = new List<string>();

            foreach (var item in sentence.Split(' '))
            {

                listOfTheWordsInTheSentence.Add(item);

            }
            foreach (var name in listOfInputNames)
            {
                var trimedName = name.Trim();
                var matches = listOfTheWordsInTheSentence.Where(word => word.Contains(trimedName)).ToList();
                Console.WriteLine($"For the item {trimedName} there were {matches.Count}");
            }





        }
    }
}
