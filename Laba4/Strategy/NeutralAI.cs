using System;

namespace DesignPatternsGame.Strategy
{
    public class NeutralAI : IAIStrategy
    {
        public void Execute(string botName)
        {
            Console.WriteLine($"{botName} обирає нейтральну тактику: балансує між атакою і захистом.");
        }
    }
}