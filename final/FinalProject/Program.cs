using System;
namespace FinalProject;

class Program
{
    static void Main(string[] args)
    {
        PreciousMetal metal = new Gold();

        Console.WriteLine("Enter weight (in grams):");
        double weight = double.Parse(Console.ReadLine());

        double price = metal.CalculatePrice(weight);
        Console.WriteLine($"The price of {metal.MetalType} for {weight} grams is: {price}");
    }
}
