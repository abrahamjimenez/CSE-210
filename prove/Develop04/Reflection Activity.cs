using System;
using System.Data;
using System.Security.Cryptography;

namespace Develop04
{
    /// <summary>
    /// This activity will help you reflect on times in your life when you have shown strength and resilience.
	/// This will help you recognize the power you have and how you can use it in other aspects of your life.
    /// </summary>
    public class Reflection_Activity : Activity
    {
        Random random = new Random();

        private string[] prompts = new string[]
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless.",
            };

        private string[] reflectionQuestions = new string[]
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };

        public Reflection_Activity()
        {

        }

        private void SelectRandomPrompt()
        {
            Random random = new Random();
            int randomIndex = random.Next(prompts.Length);
            string randomPrompt = prompts[randomIndex];

            Console.WriteLine(randomPrompt);
        }

        private string GetRandomReflection()
        {
            int randomIndex = random.Next(reflectionQuestions.Length);
            string randomPrompt = reflectionQuestions[randomIndex];

            return randomPrompt;
        }

        private void DisplaySpinner()
        {

        }

        public void RunReflectionActivity()
        {
            StandardMessageReflection();
            int duration = DurationPrompt();
            SelectRandomPrompt();
            string randomReflection = GetRandomReflection();
            DisplayPausedMessages(randomReflection);
        }
    }
}

