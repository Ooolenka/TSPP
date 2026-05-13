using System;

namespace DesignPatternsGame.Composite
{
    public class SimpleQuest : IQuest
    {
        private readonly string _title;

        public SimpleQuest(string title)
        {
            _title = title;
        }

        public void ShowQuest(int level = 0)
        {
            Console.WriteLine($"{new string(' ', level * 2)}- Завдання: {_title}");
        }

        public void Complete()
        {
            Console.WriteLine($"Квест \"{_title}\" виконано.");
        }
    }
}