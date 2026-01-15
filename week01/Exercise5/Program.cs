using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name);
        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        int PromptUserNumber()
        {
            Console.Write("Please enter your Favorite number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            return number;
        }
        int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        void DisplayResult(string name)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}