using System;
using System.Collections.Generic;

namespace Develop03
{
    /// <summary>
    /// Hold references and words and display when needed
    /// </summary>
    public class Scripture
	{
		private List<Verse> verseList;
        private List<string> allVerses = new List<string>();
		public int listLength;
		string verseWords;
		string randomScripture;

        public Scripture()
		{

		}

		public string HoldReference() // This will hold the references but return a random scripture
		{
			Reference reference = new Reference();
			List<string> myReferences = reference.GetReference();

			foreach (string references in myReferences)
			{
				allVerses.Add(references); // This code adds the references to the allVerses
			}

			// Code under here will get a random number
			Random random = new Random();
			listLength = random.Next(0, allVerses.Count);
			randomScripture = allVerses[listLength];
            return randomScripture; // This will return a random reference
		}

		public string HoldWords() // This will hold the verse words
		{
			// I need to get the verses, then pass them through the words
			Verse scriptures = new Verse();
			verseWords = scriptures.HoldWords()[listLength]; // This will get the same index as the randomScripture number

			return verseWords;
        }

		public void DisplayWords() // This will get it all
		{
            Console.WriteLine($"{randomScripture} {verseWords}");
		}
	}
}

