using System;
using Develop03;

class Program
{
    static void Main(string[] args)
    {
        /// This gets the reference
        Reference reference = new Reference();
        string myReference = reference.ScriptureReference();

        //Console.WriteLine(myReference);

        // This gets words
        Words words = new Words();
        string verseWords = words.VerseWords();
        string[] wordsList = verseWords.Split(" ");


        foreach (string word in wordsList)
        {
            Console.Write(word);
        }



    }
}