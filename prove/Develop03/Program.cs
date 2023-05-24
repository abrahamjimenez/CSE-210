using Develop03;

class Program
{
    static void Main(string[] args)
    {
        string verse = "For behold, this is my work and my glory to bring to pass the immortality and eternal life of man.";

        Verse myVerse = new Verse(verse); // This will send the code to Verse.cs. It will get the verses length, set count to 0, and split this verse into a string
        myVerse.MaskRandomWords(); // This is what will excecute all the code
    }
}