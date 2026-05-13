using System;

namespace DesignPatternsGame.Strategy
{
    public class GameBot
    {
        public string Name { get; set; }
        private IAIStrategy _strategy;

        public GameBot(string name)
        {
            Name = name;
        }

        public void SetStrategy(IAIStrategy strategy)
        {
            _strategy = strategy;
        }

        public void RunStrategy()
        {
            if (_strategy == null)
            {
                Console.WriteLine($"Для {Name} не вибрано стратегію.");
                return;
            }

            _strategy.Execute(Name);
        }
    }
}