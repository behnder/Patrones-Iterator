namespace Patrones_Iterator
{
    public abstract class IteratorEjemplo
    {
        public abstract void First();
        public abstract void Next();
        public abstract bool IsDone();
        public abstract Item CurrentItem();
    }
}