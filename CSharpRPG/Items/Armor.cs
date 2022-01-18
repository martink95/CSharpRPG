using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG.Items
{
    public class Armor : Item
    {
        public int ArmorValue { get; set; }
        public Armor(string _name, string _slot, string _type, int _lvl, int _int, int _str, int _dex, int _armorValue) : base(_name, _slot, _type, _lvl, _int, _str, _dex)
        {
            ArmorValue = _armorValue;
        }
    }
}
