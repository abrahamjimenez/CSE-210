using System;

class Program
{
    static void Main(string[] args)
    {
        // Function 1
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        // Function 2
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }
        // Function 3
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int fav_num = int.Parse(Console.ReadLine());

            return fav_num;
        }
        
        // Function 4
        static int SquareNumber(int x)
        {
            x *= x;

            return x;
        }

        // Fucntion 5
        static void DisplayResult(string name, int x)
        {
            Console.WriteLine($"{name}, the square of your number is {x}."); 
        }

        // Run Functions
        DisplayWelcome();
        string name = PromptUserName();
        int fav_num = PromptUserNumber();
        int num_squared = SquareNumber(fav_num);
        DisplayResult(name, num_squared);

    }
}