using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rock.Repository;

namespace ConsoleGame.cs
{
    public class UserInterface
    {
        Repository _repo = new Repository();
        //wrapping the choices to enter in this while loop powered by a bool will keep our players from being able to enter anything other than Rock, Paper, Scissors
        public void RockPaperScissors()
        {
            // string[] options = {"rock", "paper", "scissors"};
            // Random optionsIndex = new Random();
            bool isRunning = true;
            // int computer = Random.Next(1, 3);

            int computer = _repo.computerChoice();
            // int player = 0;

            while (isRunning)
            {
                // string answer = "";

                Console.WriteLine("Please enter the number for your choice: \n 1. Rock  \n 2. Paper \n  3. Scissors");

                int player = Convert.ToInt32(Console.ReadLine());
                while (player != 1 && player != 2 && player != 3)
                {
                    Console.WriteLine("Please enter the number for your choice: \n 1. Rock  \n 2. Paper \n 3. Scissors");

                    //string[] computer = options[optionsIndex.Next(options.Length)];
                }
                //  Console.WriteLine(player);
                // Console.WriteLine(computer);

                // switch (computer)
                // {
                //     case "rock":
                //         computer = "rock";
                //         break;
                //     case "paper": 
                //         computer = "paper";
                //         break;
                //     case "scissors":
                //         computer = "scissors";
                //         break;
                // }
                // Console.WriteLine("Computer chose " + computer);
                // Console.WriteLine("Player chose " + player);


                //store returned int in variable
                //reference variable in switch case
                int computerSelect = _repo.computerChoice();

                switch (computerSelect)
                {
                    case 1:
                        if (player == 2)
                        {
                            Console.Write("Computer played " + computer);
                            Console.WriteLine("You Win!!!");
                        }
                        else if (player == 3)
                        {
                            Console.Write("Computer played " + computer);
                            Console.WriteLine("You Lose Bitch!!!!");
                        }
                        else if (player == 1)
                        {
                            Console.Write("Computer played " + computer);
                            Console.WriteLine("It's A Tie!!!");
                        }
                        break;

                    case 2:

                        if (player == 1)
                        {
                            Console.Write("Computer played " + computer);
                            Console.WriteLine("You Lose!!!");
                        }
                        else if (player == 3)
                        {
                            Console.Write("Computer played " + computer);
                            Console.WriteLine("You Win!!!");
                        }
                        else if (player == 2)
                        {
                            Console.Write("Computer played " + computer);
                            Console.WriteLine("It's A Tie!!!");
                        }
                        break;



                    case 3:

                        if (player == 1)
                        {
                            Console.Write("Computer played " + computer);
                            Console.WriteLine("You Win!!!");
                        }
                        else if (player == 2)
                        {
                            Console.Write("Computer played " + computer);
                            Console.WriteLine("You Lose!!!");
                        }
                        else if (player == 3)
                        {
                            Console.Write("Computer played " + computer);
                            Console.WriteLine("It's a Tie!!!");
                        }
                        break;
                }
            }
        }
    }
}



// default: 
// Console.WriteLine("Invalid entry");





