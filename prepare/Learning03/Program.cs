using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess the magic number!");
        Console.WriteLine("");
        Random random_number = new Random();
        int magic_number = random_number.Next(1, 101);


        Console.WriteLine("What is your guess?");
        int user_guess = int.Parse(Console.ReadLine());

        while (user_guess != magic_number)
        {

            if (user_guess > magic_number)
            {
                Console.WriteLine("Lower:");
                user_guess = int.Parse(Console.ReadLine());
            }
            else if (user_guess < magic_number)
            {
                Console.WriteLine("Higher:");
                user_guess = int.Parse(Console.ReadLine());
            }
        }
        Console.Write("You guessed it!");
    }
}