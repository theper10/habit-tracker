using HabitTracker.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker.Menus
{
    internal class HabitMenu
    {
        private HabitService habitService = new();
        public void ShowMenu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("=== HABIT TRACKER ===");
                Console.WriteLine("1. View habits");
                Console.WriteLine("2. Add habit");
                Console.WriteLine("3. Complete habit");
                Console.WriteLine("4. Remove habit");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string menuChoice = Console.ReadLine().Trim();

                switch (menuChoice)
                {
                    case "1":
                        habitService.ViewHabits();
                        break;
                    case "2":
                        habitService.AddHabit();
                        break;
                    case "3":
                        Console.WriteLine("Completing habits");
                        break;
                    case "4":
                        habitService.RemoveHabit();
                        break;
                    case "5":
                        Console.WriteLine("Application closing..");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }
    }
}
