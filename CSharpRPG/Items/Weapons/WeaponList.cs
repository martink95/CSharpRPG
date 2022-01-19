using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG.Items.Weapons
{
    public class WeaponList
    {
        
        // LVL 3 Weapons
        Weapon weapon1 = new Weapon("Bronze Sword", "Weapon", "Sword", 3, 0, 2, 1, 12, 1.2);
        Weapon weapon2 = new Weapon("Bronze Dagger", "Weapon", "Dagger", 3, 0, 0, 3, 9, 1.5);
        Weapon weapon3 = new Weapon("Bronze Hammer", "Weapon", "Hammer", 3, 0, 3, 0, 10, 1.1);
        Weapon weapon4 = new Weapon("Bronze Axe", "Weapon", "Axe", 3, 0, 2, 0, 12, 1.2);
        Weapon weapon5 = new Weapon("Longbow", "Weapon", "Bow", 3, 0, 0, 2, 12, 1.2);
        Weapon weapon6 = new Weapon("Greater Wand", "Weapon", "Wand", 3, 2, 0, 0, 12, 1.2);

        // Lvl 6 Weapons
        Weapon weapon7 = new Weapon("Bronze Sword", "Weapon", "Sword", 6, 0, 4, 2, 17, 1.1);
        Weapon weapon8 = new Weapon("Bronze Dagger", "Weapon", "Dagger", 6, 0, 0, 4, 12, 1.6);
        Weapon weapon9 = new Weapon("Bronze Hammer", "Weapon", "Hammer", 6, 0, 5, 0, 15, 1.1);
        Weapon weapon10 = new Weapon("Bronze Axe", "Weapon", "Axe", 6, 0, 5, 0, 16, 1.2);
        Weapon weapon11 = new Weapon("Longbow", "Weapon", "Bow", 6, 0, 0, 5, 16, 1.2);
        Weapon weapon12 = new Weapon("Greater Staff", "Weapon", "Wand", 6, 5, 0, 0, 16, 1.2);
        // LVL 9 Weapons

        public WeaponList()
        {
            List<Weapon> weaponList = new List<Weapon>() { weapon1, weapon2, weapon3, weapon4, weapon5, weapon6, weapon7, weapon8, weapon9, weapon10, weapon11, weapon12 };
 
        }

        




    }

    
}
