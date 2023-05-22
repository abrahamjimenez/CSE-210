using System;
using System.Linq;
using Develop03;

class Program
{
    static void Main(string[] args)
    {
        string verse = "For behold, this is my work and my glory to bring to pass the immortality and eternal life of man.";

        Verse myVerse = new Verse(verse); // Create an instance of the Verse class, passing the verse as an argument to the constructor
        myVerse.MaskRandomWords(); // Call the MaskRandomWords method to start the word masking process
    }
}