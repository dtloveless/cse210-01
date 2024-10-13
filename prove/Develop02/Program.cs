using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Journal Program!");

        Journal Journal = new Journal();

        bool loop = true;

        while (loop)
        {
            Console.WriteLine("Select from any of the following actions.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Journal.AddEntry();
                    break;
                case "2":
                    Journal.DisplayEntries();
                    break;
                case "3":
                    Journal.LoadFile();
                    break;
                case "4":
                    Journal.SaveFile();
                    break;
                case "5":
                    Console.WriteLine("Thanks for journaling!");
                    loop = false;
                    break;
                default:
                    Console.WriteLine("That is not a valid response.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
