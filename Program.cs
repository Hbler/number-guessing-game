using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess
            int guesses = 0;
            int guess;
            string input;
            bool done = false;

            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer

            while (!done)
            {
                input = Console.ReadLine();


                bool isInt = false;

                isInt = Int32.TryParse(input, out guess);

                if (isInt)
                {
                    guesses++;
                    switch (guess)
                    {
                        case -1:
                            Console.WriteLine($"Game ended after {guesses} tries.");
                            done = true;
                            break;
                        case int n when n > theNumber:
                            Console.WriteLine("Whoops too high!\nTry a lower number.");
                            break;
                        case int n when n < theNumber:
                            Console.WriteLine("Whoops too low!\nTry a higher number.");
                            break;
                        default:
                            Console.WriteLine($"You got it: {theNumber}\nFigured it out after {guesses} tries.");
                            done = true;
                            break;
                    }
                }
                else
                {

                    Console.WriteLine($"Whoops! You did't enter a number. Try again");
                }

            }

        }
    }
}