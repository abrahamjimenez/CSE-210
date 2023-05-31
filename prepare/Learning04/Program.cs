using System;
using Learning04;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        Assignment assignment = new Assignment();
        assignment.SetStudentName("Abraham Jimenez");
        assignment.SetTopic("PE Class");
        Console.WriteLine(assignment.GetSummary());

        Console.WriteLine();

        MathAssignment mathAssignment = new MathAssignment();
        mathAssignment.SetTextbookSection("7.3");
        mathAssignment.SetProblems("8-19");
        mathAssignment.SetStudentName("Bill Nye");
        mathAssignment.SetTopic("Math");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment writingAssignment = new WritingAssignment();
        writingAssignment.SetTitle("The Causes of World War II by Mary Waters");
        writingAssignment.SetStudentName("Jane Doe");
        writingAssignment.SetTopic("European History");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

        Console.WriteLine();
    }
}