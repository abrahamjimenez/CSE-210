using System;
namespace Develop04
{
    /// <summary>
    /// This activity will help you relax by walking your through breathing in and out slowly.
    /// Clear your mind and focus on your breathing.
    /// </summary>
    public class Breathing_Activity : Activity
    {
        public Breathing_Activity()
        {

        }

        private void AlternateMessages()
        {
            BreatheIn();
            BreathOut();
            Console.WriteLine();
        }

        private void BreatheIn()
        {
            int countDown = 3;

            while (countDown != 0) {
                Thread.Sleep(1000);
                countDown--;
                Console.Write($"\rBreathe in...{countDown + 1}");
            }
            Console.WriteLine();
        }

        private void BreathOut()
        {
            int countDown = 3;

            while (countDown != 0)
            {
                Thread.Sleep(1000);
                countDown--;
                Console.Write($"\rNow breathe out...{countDown + 1}");
            }
            Console.WriteLine();
        }

        private void DisplayBreaths(int duration)
        {
            int breathCycles = duration / 4;

            for (int i = 0; i < breathCycles; i++)
            {
                AlternateMessages();
            }
        }

        public void RunBreathingActivity()
        {
            Console.WriteLine(StandardMessage());
            int duration = DurationPrompt();

            DisplayBreaths(duration);
        }
    }
}

