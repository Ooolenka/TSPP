using System;

namespace DesignPatternsGame.FactoryMethod
{
    public class Warrior : GameCharacter
    {
        public Warrior(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} атакує мечем!");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name}, клас: Warrior");
        }
    }
}