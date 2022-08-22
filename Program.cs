using System;

int secretNumber = new Random().Next(1, 101);

Console.Write("Choose difficulty level (e, m, or h): ");
string difficulty = Console.ReadLine().ToLower();

int attempts = 0;

switch(difficulty)
{
    case "e":
    attempts = 8;
    break;

    case "m":
    attempts = 6;
    break;

    case "h":
    attempts = 4;
    break;

}

while (attempts > 0) 
{
    Console.Write("Guess a secret number: ");
    attempts--;
    int guessedNumber = int.Parse(Console.ReadLine());

    string highOrLow = (guessedNumber > secretNumber) 
    ? "Too high" : "Too low";
    string onWrong = (attempts != 0) ? $"{highOrLow}, you have {attempts} tries left" : $"All out of attempts\nThe number was {secretNumber}";

    bool correct = guessedNumber == secretNumber;

    string result = (correct) ? "You got the secret number!!" : onWrong;
    Console.WriteLine(result);
    if (correct)
    break;
}

