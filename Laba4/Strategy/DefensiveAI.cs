using System;

namespace DesignPatternsGame.Strategy
{
    public class DefensiveAI : IAIStrategy
    {
        public void Execute(string botName)
        {
            Console.WriteLine($"{botName} обирає захисну тактику: блокує та уникає атак.");
        }
    }
}