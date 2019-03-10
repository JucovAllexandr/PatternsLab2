using System.Collections.Generic;

namespace PatternsLab2
{
    public class MoveHistory
    {
        public Queue<MoveMemento> History { get; private set; }
        public MoveHistory()
        {
            History = new Queue<MoveMemento>();
        }
    }
}