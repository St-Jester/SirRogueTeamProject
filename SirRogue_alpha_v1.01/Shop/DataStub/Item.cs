using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirRogue_alpha_v1._01.Shop.DataStub
{
    public enum ItemTypes
    {
        ManaModifier,
        HPModifier,
        AttackModifier,
        SpeedModifier
    }

    public enum ItemRoles
    {
        Head,
        Torso,
        Hands,
        Legs,
        None
    }

    public class Item
    {
        public string Name { get; set; }
        public ItemTypes Type { get; set; }
        public double Modifier { get; set; }
        public ItemRoles Role { get; set; }
        public double Price { get; set; }
    }
}
