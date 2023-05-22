using System;
using System.Collections.Generic;

namespace Develop03
{
    /// <summary>
    /// Holds list of words and scripture reference 
    /// </summary>
    public class Verse
    {
        private Words words; // Private field to hold the Words object
        private int totalWords; // Total number of words in the verse
        private int maskedCount; // Count of masked words

        public Verse(string verse)
        {
            words = new Words(verse); // Create a new Words object, passing the verse as an argument to the constructor
            totalWords = words.GetLength(); // Get the total number of words in the verse
            maskedCount = 0; // Initialize the masked word count to 0
        }

        public void MaskRandomWords()
        {
            Console.WriteLine($"Moses 1:36 {words}"); // Print the masked verse to the console
            Console.WriteLine("Please press enter: ");
            while (maskedCount < totalWords) // Continue masking words until all words are masked
            {
                Console.ReadLine(); // Wait for user input (pressing Enter)

                // Generate two random indices within the range of the remaining unmasked words
                Random random = new Random();
                int index1, index2;

                do
                {
                    index1 = random.Next(0, totalWords); // Generate a random index
                } while (words.IsWordMasked(index1)); // Repeat if the word at the index is already masked

                do
                {
                    index2 = random.Next(0, totalWords); // Generate another random index
                } while (words.IsWordMasked(index2) || index2 == index1); // Repeat if the word at the index is already masked or it's the same as the first index

                // Mask the words at the generated indices
                words.MaskWord(index1);
                words.MaskWord(index2);

                Console.Clear(); // Clear console
                Console.WriteLine($"Moses 1:39 { words}"); // Print the masked verse to the console
                Console.WriteLine("Please press enter: ");

                maskedCount += 2; // Increment the masked word count by 2, as two words are masked at a time
            }
            Console.Clear(); // Clear console once program is over 
        }
    }
}
