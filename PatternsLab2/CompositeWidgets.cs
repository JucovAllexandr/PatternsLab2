using System.Collections;
using System.Collections.Generic;

namespace PatternsLab2
{
    public class CompositeWidgets : Widget, IEnumerable
    {
        private List<Widget> widgets = new List<Widget>();

        public override void Move(int x, int y)
        {
            foreach (var w in widgets)
            {
                w.Move(x, y);
            }
        }

        public override void Draw(WidgetStyle style)
        {
            foreach (var w in widgets)
            {
                w.Draw(style);
            }
        }

        public override void Accept(IVisitor visitor)
        {
            throw new System.NotImplementedException();
        }

        public void AddWidget(Widget widget)
        {
            if (!widgets.Contains(widget))
                widgets.Add(widget);
        }
        
        public List<Widget> getItems()
        {
            return widgets;
        }

        public IEnumerator GetEnumerator()
        {
            return new ReverseIterator(this);
        }
    }
}