using System;
using System.Collections.Generic;
using System.IO;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            Prompts myPrompts = new Prompts();
            string prompt = myPrompts.Display();
            Console.WriteLine(prompt);
            string userInput = myPrompts.AskInput();
            Console.WriteLine("");
            string currentDate = myPrompts.DisplayCurrentDate();

            Entry myEntry = new Entry();
            myEntry.Hold(prompt, userInput, currentDate);

            Journal journal = new Journal();
            journal.AddEntry(myEntry);

            List<Entry> entries = journal.GetAllEntries();
            foreach (Entry entry in entries)
            {
                string message = entry.ConvertToString();
                
            }

            // Save to file
            string filename = "myFile.txt";

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                Console.WriteLine("Saving...");
                outputFile.WriteLine($"{currentDate} - {prompt} - {userInput}");                
            }

            // Load file
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {

                // Console.WriteLine(line);
                // line will have something like this 5/11/2023 - What is the best part of your day? - Everything

                string[] parts = line.Split("-");

                Console.WriteLine("");
                Console.WriteLine("Reading from file...");
                Console.WriteLine(line);
            }
        }
    }
}