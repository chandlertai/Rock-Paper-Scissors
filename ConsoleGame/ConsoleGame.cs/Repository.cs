using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleGame.cs
{
    public class Repository
    {
        //wrapping the choises to enter in this while loop powered by a bool will keep our players from being able to enter anything other than Rock, Paper, Scissors
    public void RockPaperScissors()
    {
    // string[] options = {"rock", "paper", "scissors"};
    // Random optionsIndex = new Random();
    bool isRunning = true;
    // int computer = Random.Next(1, 3);
    string computer = "";

     while (isRunning)
     {
    string player = "";
    // string answer = "";

         while(player != "rock" && player != "paper" && player != "scissors")
          {
             Console.WriteLine("Please choose either Rock, Paper, or Scissors");
            player = Console.ReadLine();

            // string computer = options[optionsIndex.Next(options.Length)];
          }
        //  Console.WriteLine(player);
        // Console.WriteLine(computer);
        
    switch (computer)
    {
        case "rock":
            computer = "rock";
            break;
        case "paper": 
            computer = "paper";
            break;
        case "scissors":
            computer = "scissors";
            break;
    }
    Console.WriteLine("Computer chose " + computer);
    Console.WriteLine("Player chose " + player);
    
     

    
    switch (player)
     
    {
    case "rock":
        if (computer == "paper")
    {
        Console.Write("Computer played" + computer);
        Console.WriteLine("You Win!!!");
    } 
        else if (computer == "scissors")
    {
        Console.Write("Computer played" + computer);
        Console.WriteLine("You Lose Bitch!!!!");
    } 
        else if (computer == "rock")
    {
        Console.Write("Computer played" + computer);
        Console.WriteLine("It's A Tie!!!");
    }
    break;

    case "paper":
    
        if (computer == "rock")
    {
        Console.Write("Computer played" + computer);
        Console.WriteLine("You Lose!!!");
    }
        else if (computer == "Scissors")
    {
        Console.Write("Computer played" + computer);
        Console.WriteLine("You Win!!!");
    }
        else if (computer == "paper")
    {
        Console.Write("Computer played" + computer);
        Console.WriteLine("It's A Tie!!!");
    }
    break;
    
    
    
    case "scissors":
    
        if (computer == "rock")
    {
        Console.Write("Computer played" + computer);
        Console.WriteLine("You Win!!!");
    }
        else if (computer == "Paper")
    {
        Console.Write("Computer played" + computer);
        Console.WriteLine("You Lose!!!");
    }
        else if (computer == "scissors")
    {
        Console.Write("Computer played" + computer);
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
    
    
    
     
    
