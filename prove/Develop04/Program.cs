using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> number_list = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        int number_input = int.Parse(Console.ReadLine());

        while (number_input != 0)
        {
            number_list.Add(number_input);
            Console.WriteLine(number_list);

            Console.Write("Enter number: ");
            number_input = int.Parse(Console.ReadLine());
        }
        // This should print the sum
        Console.WriteLine($"The sum is: {number_list.AsQueryable().Sum()}");
        Console.WriteLine($"The average is: {number_list.Average()}");
        Console.WriteLine($"The average is: {number_list.Max()}");
    }
}