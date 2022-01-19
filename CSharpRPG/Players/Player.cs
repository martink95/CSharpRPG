using CSharpRPG.Items;
using CSharpRPG.Items.Armors;
using CSharpRPG.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG.Players
{
    public class Player
    {

        public string Name { get; set; }
        public string ClassName { get; set; }

        public int MaxHealth { get; set; }
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
            MaxHealth = 100;
        }

        public void LevelUp()
        {
            if(ClassName == "Mage")
            {
                Level++;
                Intellect += 5;
                Strength  += 1;
                Dexterity += 1;
                MaxHealth += 20;
                Health = MaxHealth;
            }
            if(ClassName == "Rogue")
            {
                Level++;
                Intellect += 1;
                Strength  += 1;
                Dexterity += 4;
                MaxHealth += 25;
                Health = MaxHealth;
            }
            if(ClassName == "Ranger")
            {
                Level++;
                Intellect += 1;
                Strength  += 1;
                Dexterity += 5;
                MaxHealth += 25;
                Health = MaxHealth;
            }
            if(ClassName == "Warrior")
            {
                Level++;
                Intellect += 1;
                Strength  += 3;
                Dexterity += 2;
                MaxHealth += 30;
                Health = MaxHealth;
            }
            
        }
        public void PrintStats()
        {
            Console.WriteLine();
            Console.WriteLine("###################################################");
            Console.WriteLine($"Name: {Name} | Class: {ClassName}");
            Console.WriteLine($"Level: {Level} | HP: {Health}");
            Console.WriteLine($"Strength: {Strength}(+{HeadArmor.Strength+BodyArmor.Strength+LegArmor.Strength+Weapon.Strength}) | Dexterity: {Dexterity}(+{HeadArmor.Dexterity+BodyArmor.Dexterity+LegArmor.Dexterity+Weapon.Dexterity}) | Intellect: {Intellect}(+{HeadArmor.Intellect+BodyArmor.Intellect+LegArmor.Intellect+Weapon.Intellect})");
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

        public void EquipWeapon(Player _player, Weapon _weapon)
        {
            bool lvlReq = _weapon.CanEquipLevel(_player, _weapon);
            bool typeReq = _weapon.CanEquipWeapon(_player, _weapon);
            if(lvlReq && typeReq)
            {
                _player.Weapon = _weapon;
            }
        }

        public void EquipArmor(Player _player, Armor _armor)
        {
            bool lvlReq = _armor.CanEquipLevel(_player, _armor);
            bool typeReq = _armor.CanEquipArmor(_player, _armor);
            if (lvlReq && typeReq)
            {
                if (_armor.Slot == "Head")
                {
                    _player.HeadArmor = _armor;
                }
                if (_armor.Slot == "Body")
                {
                    _player.BodyArmor = _armor;
                }
                if (_armor.Slot == "Leg")
                {
                    _player.LegArmor = _armor;
                }
            }
            
        }

        public int GetDamage()
        {
            double dmg = 0;
            if(ClassName == "Mage")
            {
                double totalIntellect = Intellect + HeadArmor.Intellect + BodyArmor.Intellect + LegArmor.Intellect + Weapon.Intellect;
                dmg = Weapon.DamagePerSecond * (1 + totalIntellect / 100);
            }
            if (ClassName == "Rogue")
            {
                double totalDexterity = Dexterity + HeadArmor.Dexterity + BodyArmor.Dexterity + LegArmor.Dexterity + Weapon.Dexterity;
                dmg = Weapon.DamagePerSecond * (1 + totalDexterity / 100);
            }
            if (ClassName == "Ranger")
            {
                double totalDexterity = Dexterity + HeadArmor.Dexterity + BodyArmor.Dexterity + LegArmor.Dexterity + Weapon.Dexterity;
                dmg = Weapon.DamagePerSecond * (1 + totalDexterity / 100);
            }
            if (ClassName == "Warrior")
            {
                double totalStrength = Strength + HeadArmor.Strength + BodyArmor.Strength + LegArmor.Strength + Weapon.Strength;
                dmg = Weapon.DamagePerSecond * (1 + totalStrength / 100);
                Console.WriteLine(1+totalStrength/100);
                Console.WriteLine(dmg);
            }
            Console.WriteLine(dmg);
            return (int)dmg;
        }

        public void UsePotion()
        {
            Health += 25*Level/2;
            if (Health >= MaxHealth)
            {
                Health = MaxHealth;
            }
        }
    }
}
