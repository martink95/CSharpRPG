using CSharpRPG.Items.Weapons;
using CSharpRPG.Items.Armors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG.Players.Classes
{
    public class Ranger : Player
    {
        public Ranger(string _name) : base(_name)
        {
            ClassName = "Ranger";
            Intellect = 1;
            Strength  = 1;
            Dexterity = 7;
            Weapon = new Weapon(_name: "Wooden Bow", _slot: "Weapon", _type: "Bow", _lvl: 1, _int: 0, _str: 0, _dex: 2, _dmg: 9.0, _aspeed: 1.2);
            HeadArmor = new Armor(_name: "Leather Starter Head", _slot: "Head", _type: "Leather", _lvl: 1, _int: 0, _str: 0, _dex: 1, _armorValue: 6);
            BodyArmor = new Armor(_name: "Leather Starter Robe", _slot: "Body", _type: "Leather", _lvl: 1, _int: 0, _str: 0, _dex: 2, _armorValue: 9);
            LegArmor = new Armor(_name: "Leather Starter Legs", _slot: "Leg", _type: "Leather", _lvl: 1, _int: 0, _str: 0, _dex: 1, _armorValue: 5);
        }
    }
}
