using CSharpRPG.Items.Weapons;
using CSharpRPG.Items.Armors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG.Players.Classes
{
    public class Mage : Player
    {
        public Mage(string _name) : base(_name)
        {
            ClassName = "Mage";
            Intellect = 8;
            Strength  = 1;
            Dexterity = 1;
            Weapon = new Weapon(_name: "Wooden Staff", _slot: "Weapon", _type: "Staff", _lvl: 1, _int: 2, _str: 0, _dex: 0, _dmg: 9.0, _aspeed: 1.3);
            HeadArmor = new Armor(_name: "Cloth Starter Head", _slot: "Head", _type: "Cloth", _lvl: 1, _int: 1, _str: 0, _dex: 0, _armorValue: 5);
            BodyArmor = new Armor(_name: "Cloth Starter Robe", _slot: "Body", _type: "Cloth", _lvl: 1, _int: 2, _str: 0, _dex: 0, _armorValue: 8);
            LegArmor = new Armor(_name: "Cloth Starter Legs", _slot: "Leg", _type: "Cloth", _lvl: 1, _int: 1, _str: 0, _dex: 0, _armorValue: 5);
        }
    }
}
