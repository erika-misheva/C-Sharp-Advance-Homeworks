using System;
using System.IO;

namespace HomeworkClass09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirectory);

            string appPath = @"..\..\..\";

            string exerciseFolder = appPath + @"\Exercise";
            if (Directory.Exists(exerciseFolder))
            {
                Directory.Delete(exerciseFolder, true);
            }

            Directory.CreateDirectory(exerciseFolder);
            Console.WriteLine("We have created folder : Exercise");


            if (!File.Exists(exerciseFolder + @"\calculations.txt"))
            {
                File.Create(exerciseFolder + @"\calculations.txt").Close();
                Console.WriteLine("We have created text file : calculations.txt");
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter two numbers");
                int.TryParse(Console.ReadLine(), out int firstIntigerInput);
                int.TryParse(Console.ReadLine(), out int secondIntigerInput);

                string result = (sumOfTwoNumbers(firstIntigerInput, secondIntigerInput));
                Console.WriteLine(result);

                if (File.Exists(exerciseFolder + @"\calculations.txt"))
                {
                    File.AppendAllText(exerciseFolder + @"\calculations.txt", $" { result} //Time:{DateTime.Now}\n");
                }
            }

        }
        static string sumOfTwoNumbers(int num1, int num2)
        {
            int sum = 0;
            sum = num1 + num2;
            return $"{num1} + {num2} = {sum}";
        }
    }
}
