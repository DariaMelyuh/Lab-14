namespace Menu_lab8_
{
    public class Menu : IComponent
    {
        private List<IComponent> _components = new List<IComponent>();
        private string _name;

        public Menu(string name)
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
            Console.WriteLine($"Меню {_name}:");

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
                throw new InvalidOperationException("Блюдо не найдено");
            }

            _components.Remove(component);
        }
    }
}
