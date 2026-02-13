using System;

class Program
{
    static void Main(string[] args)
    {
        int selectedOption = 0;
        int activityCounter = 0;
        while(selectedOption != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            selectedOption = int.Parse(Console.ReadLine());
            Console.Clear();
            if(selectedOption == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                activityCounter += 1;
            }
            else if(selectedOption == 2)
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                activityCounter += 1;
            }
            else if(selectedOption == 3)
            {
                
                activityCounter += 1;
            }
            else if(selectedOption == 4)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Write("Please enter a valid option: ");
                selectedOption = int.Parse(Console.ReadLine());
            }
        }
    }
}