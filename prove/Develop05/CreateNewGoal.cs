using System;
namespace Develop05
{
    public class CreateNewGoal
    {
        private int input;
        private string[] goals =
            {
            "1. Simple Goal",
            "2. Eternal Goal",
            "3. Checklist Goal"
            };
        private string goalName;
        private string goalDesc;
        private string goalPoints;
        string[] addGoals = new string[]
            {

            };

        public CreateNewGoal()
        {

        }

        public void SimpleGoal()
        {
            Console.WriteLine("What is the name of your goal? ");
            goalName = Console.ReadLine();
            Console.WriteLine("What is a short description of it? Study for at least 10 minutes");
            goalDesc = Console.ReadLine();
            Console.WriteLine("What is the amount of points assosiated with this goal?");
            goalPoints = Console.ReadLine();
        }

        public void EternalGoal()
        {
            Console.WriteLine("What is the name of your goal? ");
            goalName = Console.ReadLine();
            Console.WriteLine("What is a short description of it? Study for at least 10 minutes");
            goalDesc = Console.ReadLine();
            Console.WriteLine("What is the amount of points assosiated with this goal?");
            goalPoints = Console.ReadLine();
        }

        public void ChecklistGoal()
        {
            Console.WriteLine("What is the name of your goal? ");
            goalName = Console.ReadLine();
            Console.WriteLine("What is a short description of it? Study for at least 10 minutes");
            goalDesc = Console.ReadLine();
            Console.WriteLine("What is the amount of points assosiated with this goal?");
            goalPoints = Console.ReadLine();
        }

        public void DisplayGoals()
        {
            Console.WriteLine($"Name: {goalName}");
            Console.WriteLine($"Description: {goalDesc}");
            Console.WriteLine($"Points: {goalPoints}");
        }

        public void DisplayTypesOfGoals()
        {
            foreach (string goal in goals)
            {
                Console.WriteLine(goal);
            }
        }

        public void RunChoice(int input)
        {
            if (input == 1)
            {
                SimpleGoal();
            }
            else if (input == 2)
            {
                EternalGoal();
            }
            else if (input == 3)
            {
                ChecklistGoal();
            }
        }

        public int SelectChoice()
        {
            Console.Write("Select a choice from the menu: ");
            int input = int.Parse(Console.ReadLine());
            RunChoice(input);
            return input;
        }

        public void RunCreateNewGoal()
        {
            DisplayTypesOfGoals();
            SelectChoice();
            DisplayGoals();
        }
    }
}

