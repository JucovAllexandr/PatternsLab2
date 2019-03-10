namespace PatternsLab2
{
    public abstract class Widget : IWidget, IWidgetMemento
    {
        public string Name { get; protected set; }

        public int X { get; protected set; }

        public int Y { get; protected set; }

        public int Width { get; protected set; }

        public int Height { get; protected set; }

        public abstract void Move(int x, int y);
        public abstract void Draw(WidgetStyle style);
        public abstract void Accept(IVisitor visitor);

        public MoveMemento SaveState()
        {
            return new MoveMemento(X,Y);
        }

        public void RestoreState(MoveMemento moveMemento)
        {
            X = moveMemento.X;
            Y = moveMemento.Y;
        }
    }
}