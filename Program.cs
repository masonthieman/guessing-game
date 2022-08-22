using System;

int secretNumber = 42;
for (int i=0; i< 4; i++) 
{
    Console.Write("Guess a secret number: ");
    int guessedNumber = int.Parse(Console.ReadLine());

    if (guessedNumber == secretNumber)
        {
            Console.WriteLine("Your guess is correct!");
        }

    else 
        {
            Console.WriteLine("Unfortunately, your guess is incorrect.");
        }
}



