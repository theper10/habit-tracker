using HabitTracker.Services;
using HabitTracker.Menus;

namespace HabitTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HabitMenu habitMenu = new();
            habitMenu.ShowMenu();
        }
    }
}
