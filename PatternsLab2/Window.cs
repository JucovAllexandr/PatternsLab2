using System;

namespace PatternsLab2
{
    public class Window:Widget
    {
        public override void Move(int x, int y)
        {
            Console.WriteLine("Window "+Name+" moved at position x: "+(X+x).ToString()+", y: "+(Y+y).ToString());
        }

        public override void Draw(WidgetStyle style)
        {
            Console.WriteLine("Window "+Name+" has been draw at position x: "
                              +(X).ToString()+", y: "+(Y).ToString()+" with "+style.style+" style");
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitWindow(this);
        }

        public Window(string name, int x, int y, int width, int height)
        {
            Name = name;
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
    }
}