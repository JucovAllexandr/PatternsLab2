namespace PatternsLab2
{
    public class MoveMemento
    {
        public MoveMemento(int x, int y)
        {
            Y = y;
            X = x;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
    }
}