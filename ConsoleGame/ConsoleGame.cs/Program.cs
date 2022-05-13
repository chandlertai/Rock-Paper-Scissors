
using ConsoleGame.cs;

Repository _rps = new Repository();

Random optionsIndex = new Random();



// this variable of userInput will store whatever option the user types into the console

string[] options = {"rock", "paper", "scissors"};

_rps.RockPaperScissors();
// string player = "";
// _rps.options[optionsIndex.Next(options.Length)]();

string computer = options[optionsIndex.Next()];
// while (isRunning)
// {
// Console.WriteLine("Choose Rock, Paper or Scissors");

// string userInput = Console.ReadLine();


<<<<<<< HEAD
while (isRunning)
{
Console.WriteLine("Choose Rock, Paper or Scissors");
=======
>>>>>>> eb974f6e5995b332245d33336a346cef2ff69dea


<<<<<<< HEAD
switch (computer)
{
    case 1: "rock";
    if (player == "paper")
    {
        Console.WriteLine("You Win!!!");
    }
    else if (player == "scissors")
    {
        Console.WriteLine("You Lose Bitch!!!!");
    } else if (player == "rock")
    {
        Console.WriteLine("It's A Tie!!!");
    }
    break;

    case: "paper"
    if (player == "rock")
    {
        Console.WriteLine("You Lose!!!");
    }
    else if (player == "Scissors")
    {
        Console.WriteLine("You Win!!!");
    }
    else if (player == "paper")
    {
        Console.WriteLine("It's A Tie!!!");
    }
    break;

    case: "Scissors"
    if (player == "rock")
    {
        Console.WriteLine("You Win!!!");
    }
    else if (player == "Paper")
    {
        Console.WriteLine("You Lose!!!");
    }
    else if (player == "scissors")
    {
        Console.WriteLine("It's a Tie!!!");
    }
}

}
=======
>>>>>>> eb974f6e5995b332245d33336a346cef2ff69dea
