namespace DesignPatternsGame.FactoryMethod
{
    public abstract class GameCharacter
    {
        public string Name { get; set; }

        protected GameCharacter(string name)
        {
            Name = name;
        }

        public abstract void Attack();
        public abstract void ShowInfo();
    }
}