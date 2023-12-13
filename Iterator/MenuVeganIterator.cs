namespace Iterator
{
    public class MenuVeganIterator : IIterator<MenuItem>
    {
        private List<MenuItem> _menuItems;
        private int _item;

        public MenuVeganIterator(List<MenuItem> items)
        {
            _menuItems = items;
            _item = 0;
        }

        public bool HasNext()
        {
            while (_item < _menuItems.Count && !_menuItems[_item].IsVegan)
            {
                _item++;
            }
            return _item < _menuItems.Count;
        }

        public MenuItem Next()
        {
            if (HasNext())
            {
                return _menuItems[_item++];
            }
            else
            {
                throw new InvalidOperationException("Конец веганских блюд");
            }
        }
    }
}
