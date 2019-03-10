namespace PatternsLab2
{
    public interface IWidget
    {
        void Move(int x, int y);
        void Draw(WidgetStyle style);
        void Accept(IVisitor visitor);
    }
}