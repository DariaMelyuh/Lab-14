namespace Menu_lab8_
{
    public class Section : IComponent
    {
        private List<IComponent> _components = new List<IComponent>();
        private string _name;

        public Section(string name)
        {
            _name = name;
        }

        public override void Add(IComponent component)
        {
            if (component == null)
            {
                throw new ArgumentNullException(nameof(component), "Недопустимое значение");
            }

            _components.Add(component);
        }

        public override void Print()
        {
            Console.WriteLine($"{_name}:");

            foreach (var component in _components)
            {
                component.Print();
            }
        }

        public override void Remove(IComponent component)
        {
            if (component == null)
            {
                throw new ArgumentNullException(nameof(component));
            }

            if (!_components.Contains(component))
            {
                throw new InvalidOperationException("Компонент не найден");
            }

            _components.Remove(component);
        }
    }
}
