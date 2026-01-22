using System;

class Program
{
    static void Main(string[] args)
    {
        string progress = "";
        string verse = "And it came to pass that as he read, he was filled with the Spirit of the Lord.";
        Reference reference = new Reference("1 Nephi",1,12);
        Scripture scripture = new Scripture(reference, verse);
        while (progress != "quit")
        {
        Console.Clear();

        Console.WriteLine($"{scripture.GetDisplayText()}");
        Console.WriteLine("");
        Console.WriteLine("Press enter to continue, or type 'quit' to finish:");
        progress = Console.ReadLine();
        bool checkCompletelyHidden = scripture.IsCompletelyHidden();
        if(checkCompletelyHidden == false)
            {
                scripture.HideRandomWords(2);
            }
            else
            {
                progress = "quit";
            }
        }

    }
}