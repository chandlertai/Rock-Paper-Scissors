using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rock.Repository
{
    public class Repository
    {
        public int computerChoice()
        {
            Random kickRocks = new Random();
            int computerRandom = kickRocks.Next(1, 3);

            return computerRandom;
        }
    }


        // public bool playAgain()
        // {
        //     bool play = true;
        //     Console.WriteLine("Play Again? Select Y or N.");
        //     string answer = Console.ReadLine().ToUpper();
        //     if (answer == "Y")
        //     {
        //         play = true;
        //     }
        //     else { play = false;}
        //     return play;
        // }












}
       