class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompter = new PromptGenerator();
        int number = 0;
        while (number < 5)
        {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string choice = Console.ReadLine();
        number = int.Parse(choice);

            //Write
            if (number == 1)
            {
                DateTime currentTime = DateTime.Now;
                string date = currentTime.ToShortDateString();
                Entry entry = new Entry();
                entry._date = date;
                entry._prompt = prompter.CreateEntry();
                entry._text = Console.ReadLine();
                journal._entries.Add(entry);
            }
            //Display
            else if (number == 2)
            {
                journal.DisplayEntries(journal._entries);
            }
            //Load
            else if (number == 3)
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                journal._entries = journal.LoadEntries(fileName);
            }
            //Save
            else if (number == 4)
            {
                Console.Write("What would you like to name the file? ");
                string fileName = Console.ReadLine();
                journal.SaveEntries(fileName, journal._entries);
            }
        }


    }
}