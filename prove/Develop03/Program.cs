using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer!");

        // Ask the user for input (book, chapter, start verse, and end verse)
        Console.Write("Enter the book: ");
        string book = Console.ReadLine();
        
        Console.Write("Enter the chapter: ");
        int chapter = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the start verse: ");
        int startVerse = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the end verse: ");
        int endVerse = int.Parse(Console.ReadLine());


        Reference reference = new Reference(book, chapter, startVerse, endVerse);


        // Read JSON file content
        string jsonContent = File.ReadAllText("standard-works.json");

        // Deserialize the JSON into a dictionary structure
        var scriptures = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, Dictionary<string, string>>>>(jsonContent);

        string text = "";
        
        for (int i = startVerse; i <= endVerse; i++)
        {
            string verse = scriptures[book][chapter.ToString()][i.ToString()];
            text += verse + ' ';
        }


        Scripture scripture = new Scripture(reference, text);


        bool exit = false;

        do
        {
            Console.Clear();
            scripture.Display();
            
            Console.Write("\n\nPress enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();
            if (userInput == "")
            {
                scripture.HideWords(3);
                scripture.Display();
            }

            else if (userInput == "quit")
            {
                exit = true;
            }
        } while (!exit);
    }
}