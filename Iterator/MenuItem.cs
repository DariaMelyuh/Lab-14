﻿using Menu_lab8_;
namespace Iterator
{
    public class MenuItem : IComponent
    {
        public string Name { get; private set; }
        public bool IsVegan { get; private set; }

        public MenuItem(string name, bool isVegan)
        {
            if (name == null)
            { 
                throw new ArgumentNullException(nameof(name),"Недопустимое значение");
            }

            Name = name;
            IsVegan = isVegan;
        }

        public override void Print()
        {
            string isVegan = IsVegan ? "(Веганское блюдо)" : "";
            Console.WriteLine($"{Name} {isVegan}");
        }

        public override void Add(IComponent component)
        {
            throw new InvalidOperationException("Нельзя добавить к блюду");
        }

        public override void Remove(IComponent component)
        {
            throw new InvalidOperationException("Нельзя удалить из блюда");
        }
    }
}
