using System;
using System.Globalization;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "y";

        //Loops as long as play again is equal to y
        while (playAgain == "y")
        {
            //Get Number
                Random randomGenerator = new Random();
                int number = randomGenerator.Next(1,101);
                
            //Get Guess
            Console.WriteLine("What is your guess? ");
            string userGuess = Console.ReadLine();
            int guess = int.Parse(userGuess);

            //Loop until guess is equal to the number
            while (guess != number)
            {
                //Check if guess is correct
                if (guess > number)
                {
                    Console.WriteLine("Guess lower."); 
                }
                else
                {
                    Console.WriteLine("Guess higher.");
                } 
                //Get a new guess
                Console.WriteLine("Please guess again: ");
                userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);
            }
            Console.WriteLine($"Correct! The answer was {number}");

            Console.WriteLine("Would you like to play again? (y/n)");
            playAgain = Console.ReadLine();
        }
        Console.WriteLine("Goodbye, thanks for playing!");
    }
}