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
            Weapon = new Weapon("Wooden Staff", "Weapon", "Staff", 1, 2, 0, 0, 9.0, 1.3);
            HeadArmor = new Armor("Cloth Starter Head", "Head", "Cloth", 1, 1, 0, 0, 5);
            BodyArmor = new Armor("Cloth Starter Robe", "Body", "Cloth", 1, 2, 0, 0, 8);
            LegArmor = new Armor("Cloth Starter Legs", "Leg", "Cloth", 1, 1, 0, 0, 5);
        }
    }
}
