using System;

namespace DesignPatternsGame.FactoryMethod
{
    public class Mage : GameCharacter
    {
        public Mage(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} атакує магічним заклинанням!");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name}, клас: Mage");
        }
    }
}