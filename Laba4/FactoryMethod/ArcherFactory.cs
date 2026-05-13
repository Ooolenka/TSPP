namespace DesignPatternsGame.FactoryMethod
{
    public class ArcherFactory : GameObjectFactory
    {
        public override GameCharacter CreateCharacter(string name)
        {
            return new Archer(name);
        }
    }
}