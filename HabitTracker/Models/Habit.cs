using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker.Models
{
    internal class Habit
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public bool isCompleted { get; set; }

        public Habit (int id, string name)
        {
            Id = id;
            Name = name;
            isCompleted = false;
        }
    }
}
