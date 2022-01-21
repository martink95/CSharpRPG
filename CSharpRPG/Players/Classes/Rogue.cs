using CSharpRPG.Items.Weapons;
using CSharpRPG.Items.Armors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG.Players.Classes
{
    public class Rogue : Player
    {
        public Rogue(string _name) : base(_name)
        {
            ClassName = "Rogue";
            Intellect = 1;
            Strength  = 2;
            Dexterity = 6;
            Weapon = new Weapon(_name: "Wooden Dagger", _slot: "Weapon", _type: "Dagger", _lvl: 1, _int: 0, _str: 0, _dex: 2, _dmg: 7.0, _aspeed: 1.6);
            HeadArmor = new Armor(_name: "Leather Starter Head", _slot: "Head", _type: "Leather", _lvl: 1, _int: 0, _str: 0, _dex: 1, _armorValue: 6);
            BodyArmor = new Armor(_name: "Leather Starter Robe", _slot: "Body", _type: "Leather", _lvl: 1, _int: 0, _str: 0, _dex: 2, _armorValue: 9);
            LegArmor = new Armor(_name: "Leather Starter Legs", _slot: "Leg", _type: "Leather", _lvl: 1, _int: 0, _str: 0, _dex: 1, _armorValue: 5);
        }   
    }
}
