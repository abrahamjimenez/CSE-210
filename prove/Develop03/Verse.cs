using System;
using System.Collections.Generic;

namespace Develop03
{
	/// <summary>
	/// Holds list of words and scripture reference
	/// </summary>
	public class Verse
	{
		Reference _reference;
		string verse;
		string verse2;

        public Verse()
		{
			
        }

		public List<string> HoldWords()
		{
			List <string> wordList = new List<string>();

            // Hold scripture verses in here and output them
            verse = "For behold, this is my work and my glory-to bring to pass the immortality and eternal life of man.";
			verse2 = "Ye are the light of the world. A city that is set on an hill cannot be hid. Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house.Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven.";

            wordList.Add(verse);
            wordList.Add(verse2);

            foreach (string word in wordList) // This prints out the verses
			{
				//Console.WriteLine($"Scripture: {word}"); // This will write the scripture
				//Console.WriteLine(wordList[0]); // This will get the verse
			}
			return wordList;
		}
	}
}

