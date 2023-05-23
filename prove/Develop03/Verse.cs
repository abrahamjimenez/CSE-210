using System;
namespace Develop03
{
    public class Verse
    /// <summary>
    /// This will receive the verse. Then it will send the verse to Words.cs, where it will modify it. It will come back and we will replace the specific words to "___"
    /// </summary>
    {
        private Words words; // References the Words.cs file
        private int totalWords; // This will get length of verse
        private int maskedCount; // Counts the amount of masked words
        private Reference reference; // Reference the Reference.cs file

        public Verse(string verse)
        {
            words = new Words(verse); //This will go in Words.cs & Split the verse into a string
            totalWords = words.GetLength(); // This will take the verse, and get its length
            maskedCount = 0; // Set masked counts value to 0
        }

        public void MaskRandomWords() // This will mask the words. Pretty much the program will run here :)
        {
            Console.Clear(); // This will clear the console so it looks good once program starts
            Console.WriteLine($"{reference} {words}"); // This will begin the console with the Reference & Scripture
            Console.WriteLine("Please press enter: "); // This gives user a hint to press enter

            while (maskedCount < totalWords) // This while loop will stop once all words are "___"
            {
                Console.ReadLine(); // Any input will work, but following code will excecute when user presses enter

                Random random = new Random(); // We will use this random to grab a random word from words (the verse)
                int index1, index2; // Cool way to set two indexes as int's

                do
                {
                    index1 = random.Next(0, totalWords); // This will get a random word from the words

                } while (words.isWordMasked(index1)); // If the word is already "___" it'll get another word

                do
                {
                    index2 = random.Next(0, totalWords); // This will get a random word from the words

                } while (words.isWordMasked(index2) || index1 == index2); // If the word is already "___" it'll get another word OR if the index is the same as the first index. Complicated stuff man.

                // Once these do while get a word, the code under here will change those words to "___". Poor guys
                words.MaskWord(index1); // Turns the specific word into "___"
                words.MaskWord(index2); // Turns the specific word into "___"

                // Now that all the big code is done, we need to show this in the console
                Console.Clear(); // Clear the console so it looks cute
                Console.WriteLine($"{reference} {words}"); // Write the new words, but some will now be "___"
                Console.WriteLine("Please press enter: "); // This continues the enter prompt while program is in the while loop

                maskedCount += 2; // This will increase until it cant anymore. The program will then quit once it's done
            }
            Console.Clear(); // This will clear the console so the console looks brand new by the end of it
        }
    }
}

