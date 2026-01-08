using System;

class Program
{
    static void Main(string[] args)
    {
        Resume resume = new Resume();

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Software Unlimited";
        job1._startYear = "2020";
        job1._endYear = "2022";
        
        Job job2 = new Job();
        job2._jobTitle = "CAD Designer";
        job2._company = "Cabinet World";
        job2._startYear = "2024";
        job2._endYear = "2026";

        resume._name = "Manchel Show";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.ShowResume();
    }
}