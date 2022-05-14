
using ConsoleGame.cs;

Repository _rps = new Repository();

Random optionsIndex = new Random();



// this variable of userInput will store whatever option the user types into the console

string[] options = {"rock", "paper", "scissors"};

_rps.RockPaperScissors();
// string player = "";
// _rps.options[optionsIndex.Next(options.Length)]();

string computer = options[optionsIndex.Next(options.Length)];
// while (isRunning)
// {
// Console.WriteLine("Choose Rock, Paper or Scissors");

// string userInput = Console.ReadLine();




