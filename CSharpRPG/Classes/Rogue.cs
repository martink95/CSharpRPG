using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG.Classes
{
    public class Rogue : Player
    {
        public Rogue(string _name) : base(_name)
        {
            ClassName = "Rogue";
            Intellect = 1;
            Strength  = 2;
            Dexterity = 6;
            Weapon = new Items.Weapon("Wooden Dagger", "Weapon", "Dagger", 1, 0, 0, 2, 6.0, 1.5);
            HeadArmor = new Items.Armor("Leather Starter Head", "Head", "Leather", 1, 0, 0, 1, 6);
            BodyArmor = new Items.Armor("Leather Starter Robe", "Body", "Leather", 1, 0, 0, 2, 9);
            LegArmor = new Items.Armor("Leather Starter Legs", "Leg", "Leather", 1, 0, 0, 1, 5);
        }   
    }
}
