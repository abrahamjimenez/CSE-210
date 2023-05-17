using System;
using Develop03;

class Program
{
    static void Main(string[] args)
    {
        /// This gets the reference
        Reference reference = new Reference();
        string myReference = reference.ScriptureReference();

        Console.WriteLine(myReference);



    }
}