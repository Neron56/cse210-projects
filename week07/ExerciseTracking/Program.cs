using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = [];
        DateTime date1 = DateTime.Today;
        DateTime date2 = new DateTime(2026,2,15);
        Biking biking1 = new Biking(date2.ToString("d"),30,9.5F);
        Swimming swimming1 = new Swimming(date2.ToString("d"),45,45);
        Running running1 = new Running(date1.ToString("d"),30,2);
        Running running2 = new Running(date1.ToString("d"),30,2.2F);
        activities.Add(biking1);
        activities.Add(swimming1);
        activities.Add(running1);
        activities.Add(running2);
        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}