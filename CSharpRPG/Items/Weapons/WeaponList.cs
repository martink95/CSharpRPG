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
        Weapon weapon1 = new Weapon(_name: "Bronze Sword", _slot: "Weapon", _type: "Sword", _lvl: 3, _int: 0, _str: 2, _dex: 1, _dmg: 12, _aspeed: 1.2);
        Weapon weapon2 = new Weapon(_name: "Bronze Dagger", _slot: "Weapon", _type: "Dagger", _lvl: 3, _int: 0, _str: 0, _dex: 3, _dmg: 9, _aspeed: 1.5);
        Weapon weapon3 = new Weapon(_name: "Bronze Hammer", _slot: "Weapon", _type: "Hammer", _lvl: 3, _int: 0, _str: 3, _dex: 0, _dmg: 10, _aspeed: 1.1);
        Weapon weapon4 = new Weapon(_name: "Bronze Axe", _slot: "Weapon", _type: "Axe", _lvl: 3, _int: 0, _str: 2, _dex: 0, _dmg: 12, _aspeed: 1.2);
        Weapon weapon5 = new Weapon(_name: "Longbow", _slot: "Weapon", _type: "Bow", _lvl: 3, _int: 0, _str: 0, _dex: 2, _dmg: 12, _aspeed: 1.2);
        Weapon weapon6 = new Weapon(_name: "Greater Wand", _slot: "Weapon", _type: "Wand", _lvl: 3, _int: 2, _str: 0, _dex: 0, _dmg: 12, _aspeed: 1.2);

        // Lvl 6 Weapons
        Weapon weapon7 = new Weapon(_name: "Bronze Sword", _slot: "Weapon", _type: "Sword", _lvl: 6, _int: 0, _str: 20, _dex: 5, _dmg: 17, _aspeed: 1.1);
        Weapon weapon8 = new Weapon(_name: "Bronze Dagger", _slot: "Weapon", _type: "Dagger", _lvl: 6, _int: 0, _str: 0, _dex: 20, _dmg: 12, _aspeed: 1.6);
        Weapon weapon9 = new Weapon(_name: "Bronze Hammer", _slot: "Weapon", _type: "Hammer", _lvl: 6, _int: 0, _str: 20, _dex: 0, _dmg: 15, _aspeed: 1.1);
        Weapon weapon10 = new Weapon(_name: "Bronze Axe", _slot: "Weapon", _type: "Axe", _lvl: 6, _int: 0, _str: 20, _dex: 0, _dmg: 16, _aspeed: 1.2);
        Weapon weapon11 = new Weapon(_name: "Longbow", _slot: "Weapon", _type: "Bow", _lvl: 6, _int: 0, _str: 0, _dex: 20, _dmg: 16, _aspeed: 1.2);
        Weapon weapon12 = new Weapon(_name: "Greater Staff", _slot: "Weapon", _type: "Wand", _lvl: 6, _int: 20, _str: 0, _dex: 0, _dmg: 16, _aspeed: 1.2);
        Weapon weapon13 = new Weapon(_name: "Meme Wand", _slot: "Weapon", _type: "Wand", _lvl: 6, _int: 50, _str: 0, _dex: 0, _dmg: 25, _aspeed: 1.8);
        Weapon weapon14 = new Weapon(_name: "Meme Staff", _slot: "Weapon", _type: "Staff", _lvl: 6, _int: 50, _str: 0, _dex: 0, _dmg: 25, _aspeed: 1.8);
        Weapon weapon15 = new Weapon(_name: "Meme Bow", _slot: "Weapon", _type: "Bow", _lvl: 6, _int: 0, _str: 0, _dex: 50, _dmg: 25, _aspeed: 1.8);
        Weapon weapon16 = new Weapon(_name: "Meme Axe", _slot: "Weapon", _type: "Axe", _lvl: 6, _int: 0, _str: 50, _dex: 0, _dmg: 25, _aspeed: 1.8);
        Weapon weapon17 = new Weapon(_name: "Meme Dagger", _slot: "Weapon", _type: "Dagger", _lvl: 6, _int: 0, _str: 0, _dex: 50, _dmg: 25, _aspeed: 1.8);
        Weapon weapon18 = new Weapon(_name: "Meme Sword", _slot: "Weapon", _type: "Sword", _lvl: 6, _int: 0, _str: 50, _dex: 0, _dmg: 25, _aspeed: 1.8);
        Weapon weapon19 = new Weapon(_name: "Meme Hammer", _slot: "Weapon", _type: "Hammer", _lvl: 6, _int: 0, _str: 50, _dex: 0, _dmg: 25, _aspeed: 1.8);




        public Weapon[] GetList()
        {
            Weapon[] weaponList =
            {
                weapon1, 
                weapon2, 
                weapon3, 
                weapon4, 
                weapon5, 
                weapon6, 
                weapon7, 
                weapon8, 
                weapon9, 
                weapon10, 
                weapon11, 
                weapon12, 
                weapon13, 
                weapon14, 
                weapon15, 
                weapon16, 
                weapon17, 
                weapon18, 
                weapon19
            };
            return weaponList;
        }

    }

    
}
