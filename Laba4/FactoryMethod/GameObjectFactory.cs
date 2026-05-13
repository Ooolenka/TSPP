namespace DesignPatternsGame.FactoryMethod
{
    public abstract class GameObjectFactory
    {
        public abstract GameCharacter CreateCharacter(string name);
    }
}