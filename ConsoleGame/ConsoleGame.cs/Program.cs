using ConsoleGame;
Random optionsIndex = new Random();
bool isRunning = true;

// this variable of userInput will store whatever option the user types into the console

string[] options = {"rock", "paper", "scissors"};

string player = "";
string computer = options[optionsIndex.Next(options.Length)];


while (isRunning)
{
Console.WriteLine("Choose Rock, Paper or Scissors");

string userInput = Console.ReadLine();

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
