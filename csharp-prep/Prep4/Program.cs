using System;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (true)
        {
            Console.Write("Enter a number: ");
            int newNumber = int.Parse(Console.ReadLine());
            if (newNumber == 0)
            {
                break;
            }
            numbers.Add(newNumber);
        }
        int sum = 0;
        int quantity = numbers.Count;
        int greatestNum = 0;
        foreach (int number in numbers)
        {
            if (number > greatestNum)
            {
                greatestNum = number;
            }
            sum += number;
        }
        float average = (float)sum / quantity;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {greatestNum}");
    }
}