using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            
            Random numberGenerator = new Random();
            int magicNumber = numberGenerator.Next(1, 101);
            
            // Console.Write("What is the magic number? ");
            // int magicNumber = int.Parse(Console.ReadLine());

            int numGuesses = 0;
            while (true)
            {
                numGuesses += 1;

                Console.Write("What is your guess? ");
                int guess = int.Parse(Console.ReadLine());
                
                if (guess == magicNumber)
                {
                    Console.WriteLine($"You guessed it in {numGuesses} tries!");
                    break;
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }
            }

            Console.Write("Would you like to play again? ");
            string userResponse = Console.ReadLine().ToLower();

            if (userResponse == "no" || userResponse == "n")
            {
                break;
            }
        }
    }
}