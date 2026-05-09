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
            if (HasNoHabits())
            {
                return;
            }
            PrintHabits();
        }

        public void AddHabit()
        {
            Console.Write("Enter habit name: ");
            string newHabitName = (Console.ReadLine() ?? "").Trim();

            if (String.IsNullOrWhiteSpace(newHabitName))
            {
                Console.WriteLine("Habit name cannot be empty.");
                return;
            }

            Habit habit = new Habit(nextId, newHabitName);
            habits.Add(habit);
            nextId++;

            Console.WriteLine($"Habit {newHabitName} added!");
        }

        public void RemoveHabit()
        {
            if (HasNoHabits())
            {
                return;
            }
            PrintHabits();

            Console.Write("Enter the ID of the habit you want to remove: ");
            string input = (Console.ReadLine() ?? "").Trim();

            if (!int.TryParse(input, out int id))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            Habit? habitToRemove = habits.FirstOrDefault(habit => habit.Id == id);

            if (habitToRemove == null)
            {
                Console.WriteLine("Habit not found.");
                return;
            }

            habits.Remove(habitToRemove);
            Console.WriteLine("Habit removed!");
        }

        public void CompleteHabit()
        {
            if (HasNoHabits())
            {
                return;
            }
            PrintHabits();

            Console.Write("Enter the ID of the habit you want to complete: ");
            string input = (Console.ReadLine() ?? "").Trim();

            if (!int.TryParse(input, out int id))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            Habit? habitToComplete = habits.FirstOrDefault(habit => habit.Id == id);

            if (habitToComplete == null)
            {
                Console.WriteLine("Habit not found.");
                return;
            }

            else if (habitToComplete.IsCompleted == true)
            {
                Console.WriteLine("Habit is already completed!");
                return;
            }

            habitToComplete.IsCompleted = true;
            Console.WriteLine("Habit completed!");
        }

        private void PrintHabits()
        {
            foreach (Habit habit in habits)
            {
                string status = habit.IsCompleted ? "[X]" : "[ ]";
                Console.WriteLine($"{habit.Id}. {status} {habit.Name}");
            }
        }
        
        private bool HasNoHabits()
        {
            if (habits.Count == 0)
            {
                Console.WriteLine("No habits found.");
                return true;
            }
            return false;
        }
    }
}
