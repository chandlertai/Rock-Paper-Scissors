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
            
            bool isRunning = true;
           

            while (isRunning)
            {
                

                Console.WriteLine("Please enter the number for your choice: \n 1. Rock  \n 2. Paper \n 3. Scissors");

                int player = Convert.ToInt32(Console.ReadLine());
                while (player != 1 && player != 2 && player != 3)
                {
                    Console.WriteLine("Please enter the number for your choice: \n 1. Rock  \n 2. Paper \n 3. Scissors");

                }
               

                // switch (computerSelect)
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

                int computerSelect = _repo.computerChoice();

                switch (computerSelect)
                {
                    case 1:
                        if (player == 2)
                        {
                            Console.Write("Computer played Rock, ");
                            Console.WriteLine("You Win!!!");
                        }
                        else if (player == 3)
                        {
                            Console.Write("Computer played Rock, ");
                            Console.WriteLine("You Lose Bitch!!!!");
                        }
                        else if (player == 1)
                        {
                            Console.Write("Computer played Rock, ");
                            Console.WriteLine("It's A Tie!!!");
                        }
                        break;

                    case 2:

                        if (player == 1)
                        {
                            Console.Write("Computer played Paper, ");
                            Console.WriteLine("You Lose!!!");
                        }
                        else if (player == 3)
                        {
                            Console.Write("Computer played Paper, ");
                            Console.WriteLine("You Win!!!");
                        }
                        else if (player == 2)
                        {
                            Console.Write("Computer played Paper, ");
                            Console.WriteLine("It's A Tie!!!");
                        }
                        break;



                    case 3:

                        if (player == 1)
                        {
                            Console.Write("Computer played Scissors, ");
                            Console.WriteLine("You Win!!!");
                        }
                        else if (player == 2)
                        {
                            Console.Write("Computer played Scissors, ");
                            Console.WriteLine("You Lose!!!");
                        }
                        else if (player == 3)
                        {
                            Console.Write("Computer played Scissors, ");
                            Console.WriteLine("It's a Tie!!!");
                        }
                        break;
                }
            }
        }
    }
}









