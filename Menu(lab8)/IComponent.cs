namespace Menu_lab8_
{
    public abstract class IComponent
    {
        public abstract void Add(IComponent component);
        public abstract void Print();
        public abstract void Remove(IComponent component);
    }
}
