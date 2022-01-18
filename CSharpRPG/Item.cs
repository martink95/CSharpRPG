using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG
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

        public bool checkWearable(Player _player)
        {
            if (_player.Level >= Level) return true;
            else return false;
        }

    }
}
