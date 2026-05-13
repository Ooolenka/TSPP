namespace DesignPatternsGame.FactoryMethod
{
    public class MageFactory : GameObjectFactory
    {
        public override GameCharacter CreateCharacter(string name)
        {
            return new Mage(name);
        }
    }
}