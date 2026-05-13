using System;
using System.Collections.Generic;

namespace DesignPatternsGame.Composite
{
    public class QuestGroup : IQuest
    {
        private readonly string _title;
        private readonly List<IQuest> _subQuests = new List<IQuest>();

        public QuestGroup(string title)
        {
            _title = title;
        }

        public void Add(IQuest quest)
        {
            _subQuests.Add(quest);
        }

        public void Remove(IQuest quest)
        {
            _subQuests.Remove(quest);
        }

        public void ShowQuest(int level = 0)
        {
            Console.WriteLine($"{new string(' ', level * 2)}[Група квестів: {_title}]");

            foreach (var quest in _subQuests)
            {
                quest.ShowQuest(level + 1);
            }
        }

        public void Complete()
        {
            Console.WriteLine($"Почато виконання групи квестів \"{_title}\":");

            foreach (var quest in _subQuests)
            {
                quest.Complete();
            }

            Console.WriteLine($"Групу квестів \"{_title}\" завершено.");
        }
    }
}