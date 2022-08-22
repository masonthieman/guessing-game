using System;

int secretNumber = new Random().Next(1, 101);

int attempts = 4;

while (attempts > 0) 
{
    Console.Write("Guess a secret number: ");
    attempts--;
    int guessedNumber = int.Parse(Console.ReadLine());

    string onWrong = (attempts != 0) ? $"Try again... You have {attempts} tries left" : $"All out of attempts\nThe number was {secretNumber}";

    bool correct = guessedNumber == secretNumber;

    string result = (correct) ? "You got the secret number!!" : onWrong;
    Console.WriteLine(result);
    if (correct)
    break;
}

