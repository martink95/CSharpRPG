using CSharpRPG.Players;
using CSharpRPG.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpRPG.Items.Weapons
{
    public class Weapon : Item
    {
        public double Damage { get; set; }
        public double AttackSpeed { get; set; }
        public double DamagePerSecond { get; set; }

        public Weapon(string _name, string _slot, string _type, int _lvl, int _int, int _str, int _dex, double _dmg, double _aspeed)
            : base(_name, _slot, _type, _lvl, _int, _str, _dex)
        {
            Damage = _dmg;
            AttackSpeed = _aspeed;
            DamagePerSecond = _dmg * _aspeed;
        }

        /// <summary>
        /// CanEquipWeapon checks if the Players class can equip that type of weapon.
        /// If the Player can equip the weapon it returns true, if not it returns false.
        /// </summary>
        /// <param name="_player"></param>
        /// <param name="_weapon"></param>
        /// <returns></returns>
        public bool CanEquipWeapon(Player _player, Weapon _weapon)
        {
            if (_player.ClassName == "Warrior")
            {
                if (_weapon.Type == "Axe" || _weapon.Type == "Sword" || _weapon.Type == "Hammer") return true;
            }

            if (_player.ClassName == "Mage")
            {
                if (_weapon.Type == "Staff" || _weapon.Type == "Wand") return true;
            }

            if (_player.ClassName == "Rogue")
            {
                if (_weapon.Type == "Dagger" || _weapon.Type == "Sword") return true;
            }

            if (_player.ClassName == "Ranger")
            {
                if (_weapon.Type == "Bow") return true;
            }

            return false;
        }
    }
}
