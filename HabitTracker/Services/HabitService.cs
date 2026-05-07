using System;
using System.Collections.Generic;
using System.Text;
using HabitTracker.Models;

namespace HabitTracker.Services
{
    internal class HabitService
    {
        private List<Habit> habits = new List<Habit>();
        private int nextId = 1;

        public void ViewHabits()
        {
            if (habits.Count == 0)
            {
                Console.WriteLine("No habits found.");
            }

            foreach (Habit habit in habits)
            {
                string status = habit.isCompleted ? "[X]" : "[ ]";
                Console.WriteLine($"{habit.Id}. {status} {habit.Name}");
            }
        }

        public void AddHabit()
        {
            Console.WriteLine("Enter habit name: ");
            string newHabitName = Console.ReadLine().Trim();

            if (String.IsNullOrWhiteSpace(newHabitName))
            {
                Console.WriteLine("Habit name cannot be empty.");
                return;
            }

            Habit habit = new Habit(nextId, newHabitName);
            habits.Add(habit);
            nextId++;
        }

        public void RemoveHabit()
        {

        }

        public void CompleteHabit()
        {

        }
    }
}
