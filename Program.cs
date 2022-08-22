using System;

int secretNumber = 42;
int attempt = 1;
bool guessed = false;
while (attempt < 5 && !guessed) 
{
    Console.Write($"Guess a secret number (Guess #{attempt}): ");
    int guessedNumber = int.Parse(Console.ReadLine());

    if (guessedNumber == secretNumber)
        {
            Console.WriteLine("Your guess is correct!");
            guessed = true;
        }

    else 
        {
            Console.WriteLine("Unfortunately, your guess is incorrect.");
        }
        attempt++;
}



