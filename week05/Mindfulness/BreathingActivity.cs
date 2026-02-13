public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Setname("Breathing");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }
    public void Run()
    {
        DisplayStartingMessage();
        PromptDuration();
        Console.Clear();
        int seconds = GetDuration();
        while(seconds > 0)
        {
            Random timer = new Random();
            if(seconds >=6)
            {
                int breathIn = timer.Next(3,6);
                seconds -= breathIn;
                Console.Write("Breath in ");
                ShowCountDown(breathIn);
                Console.WriteLine("");
                int breathOut = timer.Next(3,6);
                seconds -= breathOut;
                Console.Write("Breath out ");
                ShowCountDown(breathOut);
                Console.WriteLine("");
            }
            else if(seconds > 0)
            {
                int time = seconds/2;
                Console.Write("Breath in ");
                ShowCountDown(time);
                Console.WriteLine("");
                Console.Write("Breath out ");
                ShowCountDown(time);
                seconds = 0;
                Console.WriteLine("");
            }
        }
        DisplayEndingMessage();
    }
}