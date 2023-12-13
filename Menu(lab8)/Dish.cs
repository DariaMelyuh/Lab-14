namespace Menu_lab8_
{
    public class Dish : IComponent
    {
        private string _name;
        private bool _isVegan;

        public Dish(string name, bool isVegan)
        {
            _name = name;
            _isVegan = isVegan;
        }

        public override void Add(IComponent component)
        {
            throw new InvalidOperationException("Блюдо не изменяется");
        }

        public override void Print()
        {
            string isVegan = _isVegan ? "Веганское блюдо" : "";
            Console.WriteLine($"{_name} {isVegan}");
        }

        public override void Remove(IComponent component)
        {
            throw new InvalidOperationException("Блюдо не изменяется");
        }
    }
}
