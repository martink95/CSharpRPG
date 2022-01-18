using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG.Items
{
    public class Weapon : Item
    {
        public double Damage { get; set; }
        public double AttackSpeed { get; set; }
        public Weapon(string _name, string _slot, string _type, int _lvl, int _int, int _str, int _dex, double _dmg, double _aspeed) : base(_name, _slot, _type, _lvl, _int, _str, _dex)
        {
            Damage = _dmg;
            AttackSpeed = _aspeed;
        }
    }
}
