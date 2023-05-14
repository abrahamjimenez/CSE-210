using System;
using System.Collections.Generic;
using System.IO;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {

            /// <summary>
            /// This is where the program will loop through a menu
            /// </summary>
            ///

            bool x = true;

            while (x)
            {
                Console.WriteLine("Please choose one of the following choices");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (input == 1)
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
                        //Console.WriteLine("Saving...");
                        outputFile.WriteLine($"{currentDate} - {prompt} - {userInput}");
                    }

                    Console.WriteLine("Please choose one of the following choices");
                    Console.WriteLine("1. Write");
                    Console.WriteLine("2. Display");
                    Console.WriteLine("3. Load");
                    Console.WriteLine("4. Save");
                    Console.WriteLine("5. Quit");
                    int input_two = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    if (input_two == 1)
                    {
                        Prompts myPrompts_2 = new Prompts();
                        string prompt_2 = myPrompts.Display();
                        Console.WriteLine(prompt);
                        string userInput_2 = myPrompts.AskInput();
                        Console.WriteLine("");
                        string currentDate_2 = myPrompts.DisplayCurrentDate();

                        Entry myEntry_2 = new Entry();
                        myEntry.Hold(prompt, userInput, currentDate);

                        Journal journal_2 = new Journal();
                        journal.AddEntry(myEntry);

                        List<Entry> entries_2 = journal.GetAllEntries();
                        foreach (Entry entry in entries)
                        {
                            string message = entry.ConvertToString();

                        }
                    }
                    else if (input_two == 2)
                    {
                        //string filename = "myFile.txt";

                        // Load file
                        string[] lines = System.IO.File.ReadAllLines(filename);

                        foreach (string line in lines)
                        {

                            // Console.WriteLine(line);
                            // line will have something like this 5/11/2023 - What is the best part of your day? - Everything

                            string[] parts = line.Split("-");

                            Console.WriteLine("");
                            //Console.WriteLine("Reading from file...");
                            Console.WriteLine(line);
                        }
                    }
                    else if (input_two == 3)
                    {
                        //string filename = "myFile.txt";

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
                    else if (input_two == 4)
                    {

                        // Save to file
                        //string filename = "myFile.txt";

                        using (StreamWriter outputFile = new StreamWriter(filename))
                        {
                            Console.WriteLine("Saving...");
                            outputFile.WriteLine($"{currentDate} - {prompt} - {userInput}");
                        }
                    }
                    else if (input_two == 5)
                    {
                        x = false;
                    }
                }
                else if (input == 2)
                {
                    string filename = "myFile.txt";

                    // Load file
                    string[] lines = System.IO.File.ReadAllLines(filename);

                    foreach (string line in lines)
                    {

                        // Console.WriteLine(line);
                        // line will have something like this 5/11/2023 - What is the best part of your day? - Everything

                        string[] parts = line.Split("-");

                        Console.WriteLine("");
                        //Console.WriteLine("Reading from file...");
                        Console.WriteLine(line);
                    }
                }
                else if (input == 3)
                {

                    string filename = "myFile.txt";

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
                else if (input == 4)
                {

                    // Save to file

                    Console.WriteLine("Saving...");
                }
                else
                {
                    x = false;
                }
            }
        }
    }
}