using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Menu
    {
        public int Id { get; }
        public List<Item> items { get; }
        public MenuType MenuType { get; }

        public Menu(int id, MenuType menuType)
        {
            Id = id;
            MenuType = menuType;
        }
    }
}
