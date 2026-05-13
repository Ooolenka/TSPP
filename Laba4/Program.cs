using System;
using DesignPatternsGame.FactoryMethod;
using DesignPatternsGame.Composite;
using DesignPatternsGame.Strategy;

namespace DesignPatternsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== FACTORY METHOD: Створення персонажів ===");

            GameObjectFactory warriorFactory = new WarriorFactory();
            GameObjectFactory mageFactory = new MageFactory();
            GameObjectFactory archerFactory = new ArcherFactory();

            GameCharacter warrior = warriorFactory.CreateCharacter("Тор");
            GameCharacter mage = mageFactory.CreateCharacter("Мерлін");
            GameCharacter archer = archerFactory.CreateCharacter("Робін");

            warrior.ShowInfo();
            warrior.Attack();

            mage.ShowInfo();
            mage.Attack();

            archer.ShowInfo();
            archer.Attack();

            Console.WriteLine();
            Console.WriteLine("=== COMPOSITE: Система квестів ===");

            IQuest quest1 = new SimpleQuest("Знайти меч героя");
            IQuest quest2 = new SimpleQuest("Перемогти 5 монстрів");
            IQuest quest3 = new SimpleQuest("Зібрати 10 магічних кристалів");

            QuestGroup sideQuest = new QuestGroup("Додатковий квест");
            sideQuest.Add(quest2);
            sideQuest.Add(quest3);

            QuestGroup mainQuest = new QuestGroup("Головний квест");
            mainQuest.Add(quest1);
            mainQuest.Add(sideQuest);

            mainQuest.ShowQuest();
            Console.WriteLine();
            mainQuest.Complete();

            Console.WriteLine();
            Console.WriteLine("=== STRATEGY: Вибір AI ===");

            GameBot bot = new GameBot("EnemyBot");

            bot.SetStrategy(new AggressiveAI());
            bot.RunStrategy();

            bot.SetStrategy(new DefensiveAI());
            bot.RunStrategy();

            bot.SetStrategy(new NeutralAI());
            bot.RunStrategy();

            Console.WriteLine();
        }
    }
}