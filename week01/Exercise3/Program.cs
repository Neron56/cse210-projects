using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Number game. I pick a magic number between 1-100. You guess a number, i will tell you higher or lower until you correctly guess it!");
        Random randomizer = new Random();
        int number = randomizer.Next(1,100);
        int guess = -1;
        int guessCounter = 1;
        while (guess != number)
        {
            Console.Write("What number do you guess? ");
            string input = Console.ReadLine();
            guess = int.Parse(input);
            if (guess == number)
            {
                Console.WriteLine($"You guessed it! the number was {number}!");
                Console.WriteLine($"It took you {guessCounter} Tries");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            guessCounter ++;
        }

    }
}