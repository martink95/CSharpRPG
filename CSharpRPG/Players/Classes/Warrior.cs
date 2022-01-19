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
            Weapon = new Weapon("Two-Handed Wooden Axe", "Weapon", "Axe", 1, 0, 3, 0, 13.0, 0.9);
            HeadArmor = new Armor("Mail Starter Head", "Head", "Mail", 1, 0, 1, 0, 7);
            BodyArmor = new Armor("Mail Starter Robe", "Body", "Mail", 1, 0, 2, 0, 11);
            LegArmor = new Armor("Mail Starter Legs", "Leg", "Mail", 1, 0, 1, 0, 6);

        } 
    }
}
