using CSharpRPG.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG.Items
{
    public class Item
    {
        public string Name { get; set; }
        public string Slot { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }
        public int Intellect { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }


        public Item(string _name, string _slot, string _type, int _lvl, int _int, int _str, int _dex)
        {
            Name = _name;
            Slot = _slot;
            Type = _type;
            Level = _lvl;
            Intellect = _int;
            Strength = _str;
            Dexterity = _dex;
        }

        /// <summary>
        /// CanEquipLevel checks if the Players level meet the item requirement.
        /// If the Player meets the level requirement it returns true, if not it returns false.
        /// </summary>
        /// <param name="_player"></param>
        /// <param name="_item"></param>
        /// <returns></returns>
        public bool CanEquipLevel(Player _player, Item _item)
        {
            if (_player.Level >= _item.Level) return true;
            return false;
        }


    }
}
