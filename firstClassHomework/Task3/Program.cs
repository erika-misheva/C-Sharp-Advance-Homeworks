using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Game : 'rock - paper - scissors' ");
            Console.WriteLine("Please enter play to start the game, stats to see how many games have you won," +
                " and exit to stop");

            string option = Console.ReadLine();
            Menu(option);
        }
        static void Menu(string input)
        {
            int userWins = 0;
            int computerWins = 0;
            double gamesPlayed = 0;
            string secondInput = null;

            while (true)
            {
                Console.WriteLine("Please enter the word enter to continue, exit to stop or stats to see the result");
                secondInput = Console.ReadLine();

                if (secondInput == "enter")
                {
                    input = "play";
                }
                else
                {
                    input = secondInput;
                }
                {
                    switch (input.ToLower())
                    {
                        case "play":
                            gamesPlayed++;

                            Console.WriteLine($"The number of round is : {gamesPlayed}" );
                            Console.WriteLine("Plese enter rock or paper or scissors");
                            string userPlays = Console.ReadLine().ToLower();

                            string[] computerPlaysArray = new string[] { "rock", "paper", "scissors" };
                            Random rnd = new Random();
                            int index = rnd.Next(computerPlaysArray.Length);
                            string computerPlays = computerPlaysArray[index];

                            Console.WriteLine($"You picked {userPlays} the computer picked {computerPlays}");

                            if (userPlays == computerPlays)
                            {
                                Console.WriteLine("There is no winner");
                                break;
                            }
                            else if (computerPlays == "rock" && userPlays == "scissors")
                            {
                                computerWins++;
                                Console.WriteLine($"The computer won the results are {userWins} : {computerWins}");
                                break;
                            }
                            else if (computerPlays == "scissors" && userPlays == "rock")
                            {
                                userWins++;
                                Console.WriteLine($"You won the results are {userWins} : {computerWins}");
                                break;
                            }
                            else if (computerPlays == "paper" && userPlays == "rock")
                            {
                                computerWins++;
                                Console.WriteLine($"The computer won the results are {userWins} : {computerWins}");
                                break;
                            }
                            else if (computerPlays == "rock" && userPlays == "paper")
                            {
                                userWins++;
                                Console.WriteLine($"You won the results are {userWins} : {computerWins}");
                                break;
                            }
                            else if (computerPlays == "scissors" && userPlays == "paper")
                            {
                                computerWins++;
                                Console.WriteLine($"The computer won the results are {userWins} : {computerWins}");
                                break;
                            }
                            else if (computerPlays == "paper" && userPlays == "scissors")
                            {
                                userWins++;
                                Console.WriteLine($"You won the results are {userWins} : {computerWins}");
                                break;
                            }
                            else
                            {
                                gamesPlayed--;
                                Console.WriteLine("Something went wrong, invalid input, you mus enter rock or paper or sissors");
                                break;
                            }

                        case "exit":
                            Console.WriteLine("Thank you for playing. The app will be closed");
                            break;

                        case "stats":
                            Console.WriteLine($"The results are You:{userWins} : Computer:{computerWins}");
                            double userWinInPercentage = (userWins / gamesPlayed) * 100;
                            double computerWinInPercentage = (computerWins / gamesPlayed) * 100;
                            Console.WriteLine($"The result is {userWinInPercentage} : {computerWinInPercentage}");
                            break;

                        default:
                            Console.WriteLine("Something went wrong invalid input");
                            break;
                    };
                    if(input == "exit")
                    {
                        break;
                    }
                }
            }

        }
    }
}
