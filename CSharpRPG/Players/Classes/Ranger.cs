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
            Weapon = new Weapon("Wooden Bow", "Weapon", "Bow", 1, 0, 0, 2, 9.0, 1.2);
            HeadArmor = new Armor("Leather Starter Head", "Head", "Leather", 1, 0, 0, 1, 6);
            BodyArmor = new Armor("Leather Starter Robe", "Body", "Leather", 1, 0, 0, 2, 9);
            LegArmor = new Armor("Leather Starter Legs", "Leg", "Leather", 1, 0, 0, 1, 5);
        }
    }
}
