using CSharpRPG.Items;
using CSharpRPG.Items.Armors;
using CSharpRPG.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpRPG.Exceptions;

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

        /// <summary>
        /// LevelUp checks for the Player.ClassName
        /// Then increment the stats with the correct value based on Player.ClassName.
        /// </summary>
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

        /// <summary>
        /// PrintStats takes the values Name, Classname, Level, Health and stats + (gear stats)
        /// and prints it out to the user to see in the console.
        /// </summary>
        public void PrintStats()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("###################################################");
            sb.AppendLine($"Name: {Name} | Class: {ClassName}");
            sb.AppendLine($"Level: {Level} | HP: {Health}");
            sb.AppendLine($"Strength: {Strength}(+{HeadArmor.Strength+BodyArmor.Strength+LegArmor.Strength+Weapon.Strength}) | Dexterity: {Dexterity}(+{HeadArmor.Dexterity+BodyArmor.Dexterity+LegArmor.Dexterity+Weapon.Dexterity}) | Intellect: {Intellect}(+{HeadArmor.Intellect+BodyArmor.Intellect+LegArmor.Intellect+Weapon.Intellect})");
            sb.AppendLine("###################################################");
            sb.AppendLine();
            Console.WriteLine(sb);
        }

        /// <summary>
        /// PrintInventory takes the values of each equipped weapons name, level and stats
        /// and prints it out to the user to see in the console.
        /// </summary>
        public void PrintInventory()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("###################################################");
            sb.AppendLine($"Weapon: {Weapon.Name} | Level: {Weapon.Level}");
            sb.AppendLine($"Damage: {Weapon.Damage} | Attack Speed: {Weapon.AttackSpeed}");
            sb.AppendLine($"Strength: {Weapon.Strength} | Dexterity: {Weapon.Dexterity} | Intellect: {Weapon.Intellect}");
            sb.AppendLine("---------------------------------------------------");
            sb.AppendLine($"Head: {HeadArmor.Name} | Type: {HeadArmor.Type} | Level: {HeadArmor.Level}");
            sb.AppendLine($"Strength: {HeadArmor.Strength} | Dexterity: {HeadArmor.Dexterity} | Intellect: {HeadArmor.Intellect} | Armor: {HeadArmor.ArmorValue}");
            sb.AppendLine("---------------------------------------------------");
            sb.AppendLine($"Body: {BodyArmor.Name} | Type: {BodyArmor.Type} | Level: {BodyArmor.Level}");
            sb.AppendLine($"Strength: {BodyArmor.Strength} | Dexterity: {BodyArmor.Dexterity} | Intellect: {BodyArmor.Intellect} | Armor: {BodyArmor.ArmorValue}");
            sb.AppendLine("---------------------------------------------------");
            sb.AppendLine($"Legs: {LegArmor.Name} | Type: {LegArmor.Type} | Level: {LegArmor.Level}");
            sb.AppendLine($"Strength: {LegArmor.Strength} | Dexterity: {LegArmor.Dexterity} | Intellect: {LegArmor.Intellect} | Armor: {LegArmor.ArmorValue}");
            sb.AppendLine("###################################################");
            sb.AppendLine();
            Console.WriteLine(sb);
        }

        /// <summary>
        /// EquipWeapon will change out the players weapon if type condition and level is met.
        /// If the player tries to equip a weapon of other type or level an InvalidWeaponException will be thrown.
        /// </summary>
        /// <param name="_player"></param>
        /// <param name="_weapon"></param>
        /// <exception cref="InvalidWeaponException"></exception>
        public void EquipWeapon(Player _player, Weapon _weapon)
        {
            bool lvlReq = _weapon.CanEquipLevel(_player, _weapon);
            bool typeReq = _weapon.CanEquipWeapon(_player, _weapon);
            if(lvlReq && typeReq)
            {
                _player.Weapon = _weapon;
            } 
            else throw new InvalidWeaponException($"not allowed to use that weapon | level: {lvlReq} type: {typeReq}");
        }

        /// <summary>
        /// EquipArmor will change out the players armor in the correct slot
        /// if the type condition and level requirement is met.
        /// If the player tries to equip an armor of other type or level an InvalidArmorException will be thrown.
        /// </summary>
        /// <param name="_player"></param>
        /// <param name="_armor"></param>
        /// <exception cref="InvalidArmorException"></exception>
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
            else throw new InvalidArmorException($"not allowed to use that armor | level {lvlReq} type: {typeReq}");

        }

        /// <summary>
        /// GetDamage checks player.ClassName to find the primary attribute.
        /// It then calculates the players damage based on dmg = dps * (1 + totalIntellect / 100)
        /// Then returns the dmg as an integer.
        /// </summary>
        /// <returns></returns>
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
            }
            return (int)dmg;
        }

        /// <summary>
        /// UsePotion increments the player health as long as it doesn't go above players max health.
        /// </summary>
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
