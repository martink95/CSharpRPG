using CSharpRPG.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpRPG.Exceptions;

namespace CSharpRPG.Items.Armors
{
    public class Armor : Item
    {
        public int ArmorValue { get; set; }
        public Armor(string _name, string _slot, string _type, int _lvl, int _int, int _str, int _dex, int _armorValue) : base(_name, _slot, _type, _lvl, _int, _str, _dex)
        {
            ArmorValue = _armorValue;
        }

        /// <summary>
        /// CanEquipArmor checks if the Players class can equip that type of armor.
        /// If the Player can equip the armor it returns true, if not it returns false.
        /// </summary>
        /// <param name="_player"></param>
        /// <param name="_armor"></param>
        /// <returns></returns>
        public bool CanEquipArmor(Player _player, Armor _armor)
        {
            if (_player.ClassName == "Warrior")
            {
                if (_armor.Type == "Mail" || _armor.Type == "Plate") return true;
            }

            if (_player.ClassName == "Mage")
            {
                if (_armor.Type == "Cloth") return true;
            }

            if (_player.ClassName == "Rogue")
            {
                if (_armor.Type == "Mail" || _armor.Type == "Leather") return true;
            }

            if (_player.ClassName == "Ranger")
            {
                if (_armor.Type == "Mail" || _armor.Type == "Leather") return true;
            }

            return false;
        }
    }
}
