using System;

namespace DesignPatternsGame.Strategy
{
    public class AggressiveAI : IAIStrategy
    {
        public void Execute(string botName)
        {
            Console.WriteLine($"{botName} обирає агресивну тактику: постійно атакує ворога.");
        }
    }
}