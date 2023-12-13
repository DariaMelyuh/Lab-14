namespace Iterator
{
    public class MenuArrayIterator : IIterator<MenuItem>
    {
        private MenuItem[] _menuItems;
        private int _item;

        public MenuArrayIterator(MenuItem[] menuItems)
        {
            _menuItems = menuItems;
            _item = 0;
        }

        public bool HasNext()
        {
            return _menuItems.Length > _item;
        }

        public MenuItem Next()
        {
            if (HasNext())
            {
                return _menuItems[_item++];
            }
            else
            {
                throw new InvalidOperationException("Конец");
            }
        }
    }
}
