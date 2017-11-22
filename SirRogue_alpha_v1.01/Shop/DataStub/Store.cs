using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirRogue_alpha_v1._01.Shop.DataStub
{
    public class Store
    {
        public List<Item> Items { get; set; }

        public Store()
        {
            Items = new List<Item>();
            Items.Add(new Item
            {
                Name = "Helmet",
                Type = ItemTypes.ManaModifier,
                Modifier = 3,
                Role = ItemRoles.Head,
                Price = 300
            });
            Items.Add(new Item
            {
                Name = "Armor",
                Type = ItemTypes.HPModifier,
                Modifier = 2,
                Role = ItemRoles.Torso,
                Price = 200
            });
            Items.Add(new Item
            {
                Name = "Sword",
                Type = ItemTypes.AttackModifier,
                Modifier = 5,
                Role = ItemRoles.Hands,
                Price = 500
            });
            Items.Add(new Item
            {
                Name = "Boots",
                Type = ItemTypes.SpeedModifier,
                Modifier = 4,
                Role = ItemRoles.Legs,
                Price = 400
            });
        }

        public List<string> GetStringList()
        {
            List<string> lst = new List<string>();
            foreach (Item item in Items)
                lst.Add(item.Name);
            return lst;
        }

    }
}
