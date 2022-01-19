using CSharpRPG.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG.Items.Armors
{
    public class Armor : Item
    {
        public int ArmorValue { get; set; }
        public Armor(string _name, string _slot, string _type, int _lvl, int _int, int _str, int _dex, int _armorValue) : base(_name, _slot, _type, _lvl, _int, _str, _dex)
        {
            ArmorValue = _armorValue;
        }

        public bool CanEquipArmor(Player _player, Armor _armor)
        {

            if (_player.ClassName == "Warrior")
            {
                if (_armor.Type == "Mail" || _armor.Type == "Plate") return true;
                else
                {
                    //Throw a custom exception

                    return false;
                }
            }
            if (_player.ClassName == "Mage")
            {
                if (_armor.Type == "Cloth") return true;
                else
                {
                    //Throw a custom exception

                    return false;
                }
            }
            if (_player.ClassName == "Rogue")
            {
                if (_armor.Type == "Mail" || _armor.Type == "Leather") return true;
                else
                {
                    //Throw a custom exception

                    return false;
                }
            }
            if (_player.ClassName == "Ranger")
            {
                if (_armor.Type == "Mail" || _armor.Type == "Leather") return true;
                else
                {
                    //Throw a custom exception

                    return false;
                }
            }

            // Throw error, because item may not be any of the above types (or class might be wrong).
            return false;
        }
    }
}
