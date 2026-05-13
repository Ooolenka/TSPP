using System;

namespace DesignPatternsGame.FactoryMethod
{
    public class Archer : GameCharacter
    {
        public Archer(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} атакує з лука!");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name}, клас: Archer");
        }
    }
}