using System;
using System.Collections.Generic;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<DateTime> Holidays = new List<DateTime>()
                {
                    new DateTime(2000,01,01),
                    new DateTime(2000,01,07),
                    new DateTime(2000,04,20),
                    new DateTime(2000,05,01),
                    new DateTime(2000,05,25),
                    new DateTime(2000,08,03),
                    new DateTime(2000,10,12),
                    new DateTime(2000,12,08)
                };

            Console.WriteLine("Please enter an date, you should enter first the day, than the month and the year");


            while (true)
            {
                string dateString = Console.ReadLine();
                if (dateString == "no" || dateString == "No")
                {
                    break;
                }
                if (!string.IsNullOrEmpty(dateString))
                {
                    bool succes = DateTime.TryParse(dateString, out DateTime date);
                    if (succes)
                    {
                        Console.WriteLine(date);

                        bool chekingIfItIsWeekend = workingDayOrNot(date);
                        bool checkingIfItIsHoliday = isHoliday(date, Holidays);

                        if (chekingIfItIsWeekend == true || checkingIfItIsHoliday == true)
                        {
                            Console.WriteLine("It is not working day");
                            Console.WriteLine("Would you like to enter another date ? Enter no to stop");
                        }
                        else
                        {
                            Console.WriteLine("It is a working day");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You haven't entered a valid date!");
                        Console.WriteLine("Would you like to enter another date ? Enter no to stop");
                    }
                }
                else
                {
                    Console.WriteLine("You have entered an empty imput");
                    Console.WriteLine("Would you like to enter another date ? Enter no to stop");
                }
            }
        }
        static bool workingDayOrNot(DateTime dateInput)
        {
            bool isWeekend = false;
            if (dateInput != null)
            {
                switch (dateInput.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        isWeekend = true;
                        break;
                    case DayOfWeek.Monday:
                        isWeekend = false;
                        break;
                    case DayOfWeek.Tuesday:
                        isWeekend = false;
                        break;
                    case DayOfWeek.Wednesday:
                        isWeekend = false;
                        break;
                    case DayOfWeek.Thursday:
                        isWeekend = false;
                        break;
                    case DayOfWeek.Friday:
                        isWeekend = false;
                        break;
                    case DayOfWeek.Saturday:
                        isWeekend = true;
                        break;
                    default:
                        Console.WriteLine("You have entered an invalid input");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            return isWeekend;


        }

        static bool isHoliday(DateTime dateInput, List<DateTime> holidays)
        {
            bool isHoliday = false;
            if (dateInput != null)
            {
                foreach (DateTime holiday in holidays)
                {
                    if (holiday.Day == dateInput.Day && holiday.Month == dateInput.Month)
                    {
                        isHoliday = true;
                        break;
                    }
                }
            }
            return isHoliday;
        }

    }
}
