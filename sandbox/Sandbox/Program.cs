using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class SimpleBibleReader
{
    static void Main(string[] args)
    {
        // Read JSON file content
        string jsonContent = File.ReadAllText("standard-works.json");

        // Deserialize the JSON into a dictionary structure
        var bible = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, Dictionary<string, string>>>>(jsonContent);

        // Ask the user for input (book, chapter, start verse, and end verse)
        Console.Write("Enter the book: ");
        string book = Console.ReadLine();
        
        Console.Write("Enter the chapter: ");
        string chapter = Console.ReadLine();
        
        Console.Write("Enter the start verse: ");
        string startVerse = Console.ReadLine();
        
        Console.Write("Enter the end verse: ");
        string endVerse = Console.ReadLine();

        // Fetch verses from user input
        for (int i = int.Parse(startVerse); i <= int.Parse(endVerse); i++)
        {
            string verse = bible[book][chapter][i.ToString()];
            Console.WriteLine($"{i}: {verse}");
        }
    }
}


// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Text.Json;

// class SimpleBibleReader
// {
//     private static Dictionary<string, Dictionary<string, Dictionary<string, string>>> bible;

//     static void Main(string[] args)
//     {
//         // Load the Bible data
//         LoadStandardWorks("standard-works.json");

//         // Main program loop
//         while (true)
//         {
//             Console.WriteLine("Welcome to the Simple Bible Reader!");
//             Console.WriteLine("Type 'exit' to quit the program.");

//             // Get user input
//             string book = GetUserInput("Enter the book: ");
//             if (book.ToLower() == "exit") break;

//             string chapter = GetUserInput("Enter the chapter: ");
//             if (chapter.ToLower() == "exit") break;

//             string startVerse = GetUserInput("Enter the start verse: ");
//             if (startVerse.ToLower() == "exit") break;

//             string endVerse = GetUserInput("Enter the end verse: ");
//             if (endVerse.ToLower() == "exit") break;

//             // Fetch and display verses
//             DisplayVerses(book, chapter, startVerse, endVerse);
//         }
//     }

//     private static void LoadStandardWorks(string filePath)
//     {
//         try
//         {
//             string jsonContent = File.ReadAllText(filePath);
//             bible = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, Dictionary<string, string>>>>(jsonContent);
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"Error loading Standard Works: {ex.Message}");
//             Environment.Exit(1);
//         }
//     }

//     private static string GetUserInput(string prompt)
//     {
//         Console.Write(prompt);
//         return Console.ReadLine();
//     }

//     private static void DisplayVerses(string book, string chapter, string startVerse, string endVerse)
//     {
//         if (!bible.ContainsKey(book) || !bible[book].ContainsKey(chapter))
//         {
//             Console.WriteLine("Invalid book or chapter.");
//             return;
//         }

//         if (!int.TryParse(startVerse, out int start) || !int.TryParse(endVerse, out int end) || start > end)
//         {
//             Console.WriteLine("Invalid verse range.");
//             return;
//         }

//         for (int i = start; i <= end; i++)
//         {
//             if (bible[book][chapter].TryGetValue(i.ToString(), out string verse))
//             {
//                 Console.WriteLine($"{book} {chapter}:{i} - {verse}");
//             }
//             else
//             {
//                 Console.WriteLine($"Verse {i} does not exist in {book} {chapter}.");
//             }
//         }
//     }
// }
