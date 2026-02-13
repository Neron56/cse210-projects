public class Activity
{
    string _name;
    string _description;
    int _duration;

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine($"{_description}");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(2);
        Console.WriteLine("");
        Console.WriteLine($"You completed another {_duration} seconds of the {_name} Activity!");
        ShowSpinner(8);
    }
    public void ShowSpinner(int seconds)
    {
        int spinnerTimer = 250;
        for(int i = 0; i < seconds; i++)
        {
            Console.Write("-");
            Thread.Sleep(spinnerTimer);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(spinnerTimer);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(spinnerTimer);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(spinnerTimer);
            Console.Write("\b \b");
        }
    }
    public void ShowCountDown(int seconds)
    {
        for(int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    protected void Setname(string name)
    {
        _name = name;
    }
    protected void SetDescription(string description)
    {
        _description = description;
    }
    protected void PromptDuration()
    {
        Console.Write("how many seconds do you want your activity to be? ");
        int seconds = int.Parse(Console.ReadLine());
        SetDuration(seconds);
    }
    protected void SetDuration(int duration)
    {
        _duration = duration;
    }
    protected int GetDuration()
    {
        return _duration;
    }
}