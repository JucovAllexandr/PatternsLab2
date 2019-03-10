using System.Collections;

namespace PatternsLab2
{
    public abstract class Iterator:IEnumerator
    {
        object IEnumerator.Current => Current();

        public abstract int Key();
        public abstract object Current();
        
        public abstract bool MoveNext();
        
        public abstract void Reset();
    }
}