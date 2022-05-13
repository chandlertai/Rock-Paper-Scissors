using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleGame.cs
{
    public class Repository
    {
        //wrapping the choices to enter in this while loop powered by a bool will keep our players from being able to enter anything other than Rock, Paper, Scissors
    public string 
     while (isRunning)
     {
         player = "";
         computer = "";
         while(player != "Rock" && player != "Paper" && player != "Scissors") {
             Console.WriteLine("Please choose either Rock, Paper, or Scissors");
             player = Console.ReadLine();
         }
         Console.WriteLine(player);

         
     }
    }
}