using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment = new MathAssignment("Samuel Bennet","Multiplication","Section 7.3","Problems 8-19");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(assignment.GetHomeworkList());
        WritingAssignment writtenAssignment = new WritingAssignment("Daniel Danson","History","Fighting wars in history");
        Console.WriteLine(writtenAssignment.GetSummary());
        Console.WriteLine(writtenAssignment.GetWritingInformation());
    }
}