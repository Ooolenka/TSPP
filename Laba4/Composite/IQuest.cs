namespace DesignPatternsGame.Composite
{
    public interface IQuest
    {
        void ShowQuest(int level = 0);
        void Complete();
    }
}