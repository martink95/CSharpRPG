using CSharpRPG.Items.Weapons;
using CSharpRPG.Items.Armors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG.Players.Classes
{
    public class Warrior : Player
    {
        public Warrior(string _name) : base(_name)
        {
            ClassName = "Warrior";
            Intellect = 1;
            Strength  = 5;
            Dexterity = 2;
            Weapon = new Weapon(_name: "Two-Handed Wooden Axe", _slot: "Weapon", _type: "Axe", _lvl: 1, _int: 0, _str: 3, _dex: 0, _dmg: 13.0, _aspeed: 0.9);
            HeadArmor = new Armor(_name: "Mail Starter Head", _slot: "Head", _type: "Mail", _lvl: 1, _int: 0, _str: 1, _dex: 0, _armorValue: 7);
            BodyArmor = new Armor(_name: "Mail Starter Robe", _slot: "Body", _type: "Mail", _lvl: 1, _int: 0, _str: 2, _dex: 0, _armorValue: 11);
            LegArmor = new Armor(_name: "Mail Starter Legs", _slot: "Leg", _type: "Mail", _lvl: 1, _int: 0, _str: 1, _dex: 0, _armorValue: 6);

        } 
    }
}
