public class PromptGenerator
{
    string[] prompts = File.ReadAllLines("prompts.txt");

    public string CreateEntry()
    {
        Random randomizer = new Random();
        int promptNumber = randomizer.Next(1,prompts.Count()-1);
        Console.WriteLine($"{prompts[promptNumber]}");
        Console.Write("-> ");
        return prompts[promptNumber];
    }
}