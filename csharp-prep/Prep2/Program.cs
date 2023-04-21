using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        Console.WriteLine();

        if (grade >= 93)
        {
            Console.WriteLine("A");
            Console.WriteLine("Congratulations! You passed the course");
        }
        else if (grade >= 90)
        {
            Console.WriteLine("A-");
            Console.WriteLine("Congratulations! You passed the course");
        }
        else if (grade >= 87)
        {
            Console.WriteLine("B+");
            Console.WriteLine("Congratulations! You passed the course");
        }
        else if (grade >= 83)
        {
            Console.WriteLine("B");
            Console.WriteLine("Congratulations! You passed the course");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("B-");
            Console.WriteLine("Congratulations! You passed the course");
        }
        else if (grade >= 77)
        {
            Console.WriteLine("C+");
            Console.WriteLine("Congratulations! You passed the course");
        }
        else if (grade >= 73)
        {
            Console.WriteLine("C");
            Console.WriteLine("Congratulations! You passed the course");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("C-");
            Console.WriteLine("Congratulations! You passed the course");
        }
        else if (grade >= 67)
        {
            Console.WriteLine("D+");
            Console.WriteLine("Bummer! You didn't pass... Better luck next time!");
        }
        else if (grade >= 63)
        {
            Console.WriteLine("D");
            Console.WriteLine("Bummer! You didn't pass... Better luck next time!");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("D-");
            Console.WriteLine("Bummer! You didn't pass... Better luck next time!");
        }
        else
        {
            Console.WriteLine("F");
            Console.WriteLine("Bummer! You didn't pass... Better luck next time!");
        }

        // Notes to improve. I could add an empty string variable and assign a letter based on the result, instead of copying and pasting text in every if else statement
        // Same thing goes to check if they passed or not
    }
}