namespace PatternsLab2
{
    public class ReverseIterator:Iterator
    {
        private CompositeWidgets widgets;
        private int _position = -1;

        public ReverseIterator(CompositeWidgets _widgets)
        {
            widgets = _widgets;
            _position = widgets.getItems().Count;
        }
        
        public override int Key()
        {
            return _position;
        }

        public override object Current()
        {
            return widgets.getItems()[_position];
        }

        public override bool MoveNext()
        {
            int newPos = _position - 1;
            if (newPos == -1)
                return false;
            _position = newPos;
            return true;
        }

        public override void Reset()
        {
            this._position = widgets.getItems().Count - 1;
        }
    }
}