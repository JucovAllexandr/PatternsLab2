namespace PatternsLab2
{
    public interface IWidgetMemento
    {
        MoveMemento SaveState();
        void RestoreState(MoveMemento moveMemento);
    }
}