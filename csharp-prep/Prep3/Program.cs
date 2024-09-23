using System;

class Program
{
    static void Main(string[] args)
    {
        Random numberGenerator = new Random();
        int magicNumber = numberGenerator.Next(1, 101);
        
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        while (true)
        {
            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());
            
            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
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
    }
}