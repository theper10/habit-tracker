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
            Console.Write("Enter habit name: ");
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
            foreach (Habit habit in habits)
            {
                string status = habit.isCompleted ? "[X]" : "[ ]";
                Console.WriteLine($"{habit.Id}. {status} {habit.Name}");
            }

            Console.Write("Enter the ID of the habit you want to remove: ");
            string input = Console.ReadLine().Trim();

            if (!int.TryParse(input, out int id))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            Habit habitToRemove = habits.FirstOrDefault(habit => habit.Id == id);

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

        }
    }
}
