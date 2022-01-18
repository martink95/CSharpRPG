using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG.Classes
{
    public class Ranger : Player
    {
        public Ranger(string _name) : base(_name)
        {
            ClassName = "Ranger";
            Intellect = 1;
            Strength  = 1;
            Dexterity = 7;
            Weapon = new Items.Weapon("Wooden Bow", "Weapon", "Bow", 1, 0, 0, 2, 8.0, 1);
            HeadArmor = new Items.Armor("Leather Starter Head", "Head", "Leather", 1, 0, 0, 1, 6);
            BodyArmor = new Items.Armor("Leather Starter Robe", "Body", "Leather", 1, 0, 0, 2, 9);
            LegArmor = new Items.Armor("Leather Starter Legs", "Leg", "Leather", 1, 0, 0, 1, 5);
        }
    }
}
