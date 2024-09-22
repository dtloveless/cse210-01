using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What grade percentage did you earn? ");
        string userInput = Console.ReadLine();
        float gradePercentage = float.Parse(userInput);
        // Console.WriteLine(gradePercentage);

        string letterGrade = "";
        string determiner = "a";
        bool pass = true;

        if (gradePercentage >= 90)
        {
            letterGrade = "A";
            determiner = "an";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
            pass = false;
        }
        else
        {
            letterGrade = "F";
            determiner = "an";
            pass = false;
        }

        Console.Write($"\nYou earned {determiner} {letterGrade}. ");
        
        if (pass)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You did not pass. Better study harder!");
        }
        
        Console.WriteLine();
    }   
}