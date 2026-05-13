namespace DesignPatternsGame.FactoryMethod
{
    public class WarriorFactory : GameObjectFactory
    {
        public override GameCharacter CreateCharacter(string name)
        {
            return new Warrior(name);
        }
    }
}