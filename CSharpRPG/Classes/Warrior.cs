using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG.Classes
{
    public class Warrior : Player
    {
        public Warrior(string _name) : base(_name)
        {
            ClassName = "Warrior";
            Intellect = 1;
            Strength  = 5;
            Dexterity = 2;
            Weapon = new Items.Weapon("Two-Handed Wooden Axe", "Weapon", "Axe", 1, 0, 2, 0, 12.0, 0.8);
            HeadArmor = new Items.Armor("Mail Starter Head", "Head", "Mail", 1, 0, 1, 0, 7);
            BodyArmor = new Items.Armor("Mail Starter Robe", "Body", "Mail", 1, 0, 2, 0, 11);
            LegArmor = new Items.Armor("Mail Starter Legs", "Leg", "Mail", 1, 0, 1, 0, 6);

        } 
    }
}
