using CSharpRPG.Players;
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

        public Weapon(string _name, string _slot, string _type, int _lvl, int _int, int _str, int _dex, double _dmg, double _aspeed) : base(_name, _slot, _type, _lvl, _int, _str, _dex)
        {
            Damage = _dmg;
            AttackSpeed = _aspeed;
            DamagePerSecond = _dmg * _aspeed;
        }

        public bool CanEquipWeapon(Player _player, Weapon _weapon)
        {
            if (_player.ClassName == "Warrior")
            {
                if (_weapon.Type == "Axe" || _weapon.Type == "Sword" || _weapon.Type == "Hammer") return true;
                else
                {
                    //Throw a custom exception

                    return false;
                }
            }
            if (_player.ClassName == "Mage")
            {
                if (_weapon.Type == "Staff" || _weapon.Type == "Wand") return true;
                else
                {
                    //Throw a custom exception

                    return false;
                }
            }
            if (_player.ClassName == "Rogue")
            {
                if (_weapon.Type == "Dagger" || _weapon.Type == "Sword") return true;
                else
                {
                    //Throw a custom exception

                    return false;
                }
            }
            if (_player.ClassName == "Ranger")
            {
                if (_weapon.Type == "Bow") return true;
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
