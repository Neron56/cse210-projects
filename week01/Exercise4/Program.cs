using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, Type 0 when finished.");
        int input = 5;
        List<int> numbers = new List<int>();
        while (input != 0)
        {
            Console.Write("Enter number: ");
            string stringInput = Console.ReadLine();
            input = int.Parse(stringInput);
            numbers.Add(input);
        }
        int total = 0;
        int largestNumber = -1;
        foreach (int number in numbers)
        {
            total = number + total;
            if(number > largestNumber)
            {
                largestNumber = number;
            }
        }
        float average = ((float)total) /numbers.Count;
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}