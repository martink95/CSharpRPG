using CSharpRPG.Players.Classes;
using CSharpRPG.Items.Weapons;
using CSharpRPG.Items.Armors;
using CSharpRPG.Players;
using CSharpRPG.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG
{
    public class Game
    {
        private bool running = false;
        /// <summary>
        /// Run provides the user with a welcome message, then creates a Player with the CreateCharacter() method.
        /// When a player is created the user is provided with a menu while the program is running.
        /// </summary>
        public void Run()
        {
            Console.WriteLine("#################");
            Console.WriteLine("#    Welcome    #");
            Console.WriteLine("#     To The    #");
            Console.WriteLine("#      Game     #");
            Console.WriteLine("#################");
            Console.WriteLine();

            Player player = CreateCharacter();
            
            running = true; 
                
            while(running)
            {
                Console.WriteLine("1: Fight Enemies | 2: View Inventory | 3: View Stats | 4: Exit");
                string input = Console.ReadLine();
                
                Menu(input, player);
            }
            
        }

        /// <summary>
        /// Menu takes in the users input to provide the user with the ability to do actions.
        /// it takes in the player object and use it to either fight, print inventory or print stats.
        /// user is also given the option to exit the application.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="_player"></param>
        public static void Menu(string input, Player _player)
        {
            Player player = _player;
            
            if(input == "1")
            {
                Fight(_player, _enemyName: "Some monster");
            }
            if(input == "2")
            {
                player.PrintInventory();
            }
            if(input == "3")
            {
                player.PrintStats();
            }
            if(input == "4")
            {
                Console.WriteLine("Are you sure? 1: Yes | 2: No");
                string confirmation = Console.ReadLine();
                if(confirmation == "1")
                {
                    Environment.Exit(0);
                }  
            }
        }
        
        /// <summary>
        /// Fight takes in the player object and a string for the enemy name.
        /// It creates an enemy with the given name and enemy object based on players level.
        /// The user the provides input to either fight the monster and deal dmg, use potion or flee.
        /// If the user is above level 3 and enemies health reaches 0 or below the user is provided with a weapon or armor drop.
        /// </summary>
        /// <param name="_player"></param>
        /// <param name="_enemyName"></param>
        public static void Fight(Player _player, string _enemyName)
        {
            Enemy _enemy = new Enemy(_enemyName, _player);
            while (_enemy.Health > 0 && _player.Health > 0)
            {
                Console.WriteLine($"Player hp: {_player.Health}/{_player.MaxHealth} | Enemy hp: {_enemy.Health}");
                Console.WriteLine("1: Attack | 2: Use Potion | 3: Flee ");
                string input = Console.ReadLine();
                if(input == "1")
                {
                    Console.WriteLine($"You did {_player.GetDamage()} to {_enemy.Name}");
                    _enemy.Health -= _player.GetDamage();
                    _player.Health -= _enemy.Damage;
                }
                if(input == "2")
                {
                    _player.UsePotion();
                }
                if(input == "3")
                {
                    break;
                }
            }

            if (_enemy.Health <= 0)
            {
                _player.LevelUp();

                if (_player.Level >= 3)
                {
                    Random rnd = new Random();
                    int dropType = rnd.Next(2);
                    if (dropType == 1) GetWeaponDrop(_player);
                    else GetArmorDrop(_player);
                }
            }
        }

        /// <summary>
        /// GetArmorDrop returns an armor which can be equipped by the player.
        /// It provides the user with information about what dropped, and gives the user the decision to equip or not.
        /// </summary>
        /// <param name="_player"></param>
        public static void GetArmorDrop(Player _player)
        {
            Armor[] al = new ArmorList().GetList();
            bool canEquip = false;
            Armor armorDrop = null;

            while (!canEquip)
            {
                Random rnd = new Random();
                int drop = rnd.Next(al.Length);
                bool canEquipType = al[drop].CanEquipArmor(_player, al[drop]);
                bool canEquipLvl = al[drop].CanEquipLevel(_player, al[drop]);

                if (canEquipLvl && canEquipType)
                {
                    canEquip = true;
                }

                armorDrop = al[drop];
            }
            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine($"You got a drop!");
            Console.WriteLine($"Name: {armorDrop.Name} | lvl: {armorDrop.Level} | type: {armorDrop.Type}");
            Console.WriteLine($"Slot: {armorDrop.Slot} | Defense: {armorDrop.ArmorValue}");
            Console.WriteLine($"Int: {armorDrop.Intellect} | Str: {armorDrop.Strength} | Dex: {armorDrop.Dexterity}");
            Console.WriteLine("----------------------");

            Console.WriteLine("Want to equip this item? 1: yes | 2: no");
            string input = Console.ReadLine();

            if (input == "1") _player.EquipArmor(_player, armorDrop);
            if (input == "2") return;
        }
        /// <summary>
        /// GetWeaponDrop returns a weapon which can be equipped by the player.
        /// It provides the user with information about what dropped, and gives the user the decision to equip or not.
        /// </summary>
        /// <param name="_player"></param>
        public static void GetWeaponDrop(Player _player)
        {
            
                Weapon[] wl = new WeaponList().GetList();
                bool canEquip = false;
                Weapon weaponDrop = null;

                while (!canEquip)
                {
                    Random rnd = new Random();
                    int drop = rnd.Next(wl.Length);
                    bool canEquipType = wl[drop].CanEquipWeapon(_player, wl[drop]);
                    bool canEquipLvl = wl[drop].CanEquipLevel(_player, wl[drop]);

                    if (canEquipLvl && canEquipType)
                    {
                        canEquip = true;
                    }

                    weaponDrop = wl[drop];
                }

                Console.WriteLine();
                Console.WriteLine("----------------------");
                Console.WriteLine($"You got a drop!");
                Console.WriteLine($"Name: {weaponDrop.Name} | lvl: {weaponDrop.Level} | type: {weaponDrop.Type}");
                Console.WriteLine($"Dmg: {weaponDrop.Damage} | Att. speed: {weaponDrop.AttackSpeed}");
                Console.WriteLine($"Int: {weaponDrop.Intellect} | Str: {weaponDrop.Strength} | Dex: {weaponDrop.Dexterity}");
                Console.WriteLine("----------------------");

                Console.WriteLine("Want to equip this item? 1: yes | 2: no");
                string input = Console.ReadLine();

                if (input == "1") _player.EquipWeapon(_player, weaponDrop);
                if (input == "2") return;

        }

        /// <summary>
        /// CreateCharacter uses the console to get the users name and their chosen class.
        /// It then creates the player class based on input given by user and returns the player.
        /// </summary>
        /// <returns></returns>
        public static Player CreateCharacter()
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Choose your class! enter number 1-4");

            string classNumber = "";
            Player player = new Player(name);
            
            while (classNumber != "1" || classNumber != "2" || classNumber != "3" || classNumber != "4")
            {
                Console.WriteLine("1: Mage | 2: Ranger | 3: Rogue | 4: Warrior");
                classNumber = Console.ReadLine();
                if (classNumber == "1")
                {
                    player = new Mage(name);
                    break;
                }
                if (classNumber == "2")
                {
                    player = new Ranger(name);
                    break;
                }
                if (classNumber == "3")
                {
                    player = new Rogue(name);
                    break;
                }
                if (classNumber == "4")
                {
                    player = new Warrior(name);
                    break;
                }
            }
            return player;
        }
    }
 
}
