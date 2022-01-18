using CSharpRPG.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG
{
    public class Player
    {

        public string Name { get; set; }
        public string ClassName { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intellect { get; set; }
        public Weapon Weapon { get; set; }
        public Armor HeadArmor { get; set; }
        public Armor BodyArmor { get; set; }
        public Armor LegArmor { get; set; }

        public Player(string _name)
        {
            Name = _name;
            Level = 1;
            Health = 100;
            
        }

        public void LevelUp()
        {
            if(ClassName == "Mage")
            {
                Level++;
                Intellect += 1;
                Strength  += 1;
                Dexterity += 1;
            }
            if(ClassName == "Rogue")
            {
                Level++;
                Intellect += 1;
                Strength  += 1;
                Dexterity += 4;
            }
            if(ClassName == "Ranger")
            {
                Level++;
                Intellect += 1;
                Strength  += 1;
                Dexterity += 5;
            }
            if(ClassName == "Warrior")
            {
                Level++;
                Intellect += 1;
                Strength  += 3;
                Dexterity += 2;
            }
            
        }
        public void PrintStats()
        {
            Console.WriteLine();
            Console.WriteLine("###################################################");
            Console.WriteLine($"Name: {Name} | Class: {ClassName}");
            Console.WriteLine($"Level: {Level} | HP: {Health}");
            Console.WriteLine($"Strength: {Strength} | Dexterity: {Dexterity} | Intellect: {Intellect}");
            Console.WriteLine("###################################################");
            Console.WriteLine();
        }

        public void PrintInventory()
        {
            Console.WriteLine();
            Console.WriteLine("###################################################");
            Console.WriteLine($"Weapon: {Weapon.Name} | Level: {Weapon.Level}");
            Console.WriteLine($"Damage: {Weapon.Damage} | Attack Speed: {Weapon.AttackSpeed}");
            Console.WriteLine($"Strength: {Weapon.Strength} | Dexterity: {Weapon.Dexterity} | Intellect: {Weapon.Intellect}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Head: {HeadArmor.Name} | Type: {HeadArmor.Type} | Level: {HeadArmor.Level}");
            Console.WriteLine($"Strength: {HeadArmor.Strength} | Dexterity: {HeadArmor.Dexterity} | Intellect: {HeadArmor.Intellect} | Armor: {HeadArmor.ArmorValue}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Head: {BodyArmor.Name} | Type: {BodyArmor.Type} | Level: {BodyArmor.Level}");
            Console.WriteLine($"Strength: {BodyArmor.Strength} | Dexterity: {BodyArmor.Dexterity} | Intellect: {BodyArmor.Intellect} | Armor: {BodyArmor.ArmorValue}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Head: {LegArmor.Name} | Type: {LegArmor.Type} | Level: {LegArmor.Level}");
            Console.WriteLine($"Strength: {LegArmor.Strength} | Dexterity: {LegArmor.Dexterity} | Intellect: {LegArmor.Intellect} | Armor: {LegArmor.ArmorValue}");
            Console.WriteLine("###################################################");
            Console.WriteLine();
        }

    }
}
