using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment assignment = new WritingAssignment("Daniel Loveless", "Programming", "The Art of Semicolons");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(assignment.GetWritingInformation());
    }
}