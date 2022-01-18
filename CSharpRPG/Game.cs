using CSharpRPG.Classes;
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

        public static void Menu(string input, Player _player)
        {
            Player player = _player;
            
            if(input == "1")
            {
                Console.WriteLine("Menu item 1");
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
