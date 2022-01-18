using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG.Classes
{
    public class Mage : Player
    {
        public Mage(string _name) : base(_name)
        {
            ClassName = "Mage";
            Intellect = 8;
            Strength  = 1;
            Dexterity = 1;
            Weapon = new Items.Weapon("Wooden Staff", "Weapon", "Staff", 1, 2, 0, 0, 8.0, 1);
            HeadArmor = new Items.Armor("Cloth Starter Head", "Head", "Cloth", 1, 1, 0, 0, 5);
            BodyArmor = new Items.Armor("Cloth Starter Robe", "Body", "Cloth", 1, 2, 0, 0, 8);
            LegArmor = new Items.Armor("Cloth Starter Legs", "Leg", "Cloth", 1, 1, 0, 0, 5);
        }
    }
}
