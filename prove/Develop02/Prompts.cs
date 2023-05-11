using System;
using System.Collections.Generic;

namespace Develop02
{
	/// <summary>
	/// The responsibility of this class is to store predefined prompts
	/// </summary>
	public class Prompts
	{
		public List<String> prompts;
		public Random number = new Random();

        public Prompts()
		{
            prompts = new List<String>();
            prompts.Add("Who was the most interesting person I interacted with today?");
            prompts.Add("What was the best part of my day?");
            prompts.Add("How did I see the hand of the Lord in my life today?");
            prompts.Add("What is the best part of your day?");
            prompts.Add("If I had one thing I could do over today, what would it be?");
        }

		public string GetRandomPrompt()
		{
			int randomIndex = number.Next(0, prompts.Count);
			return prompts[randomIndex];
		}

		public string Display()
		{
			string prompt = GetRandomPrompt();
			return prompt;
		}

		public string AskInput()
		{
			return Console.ReadLine();
		}

		public string DisplayCurrentDate()
		{
			DateTime currentDate = DateTime.Now;
			string dateText = currentDate.ToShortDateString();
			return dateText;
		}
	}
}