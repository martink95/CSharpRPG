using CSharpRPG.Items.Weapons;
using CSharpRPG.Players;
using CSharpRPG.Players.Classes;
using System;
using Xunit;

namespace CSharpRPGTests
{
    public class PlayerEquipmentTests
    {
        [Fact]
        public void Player_can_equip_weapon_level_test()
        {
            // Arrange
            // Character
            Player player = new Player("CharacterName");
            // Weapons
            Weapon weaponLvl1 = new Weapon("Test Wand", "Weapon", "Wand", 1, 2, 0, 0, 12, 1);
            Weapon weaponLvl2 = new Weapon("Test Sword", "Weapon", "Sword", 2, 0, 2, 1, 12, 1.2);

            // Act
            bool bWeaponLvl1 = weaponLvl1.CanEquipLevel(player, weaponLvl1);
            bool bWeaponLvl2 = weaponLvl2.CanEquipLevel(player, weaponLvl2);
            // Assert  Expected output if lvl is above player level = false
            Assert.True(bWeaponLvl1);
            Assert.False(bWeaponLvl2);
        }

        [Fact]
        public void Mage_can_equip_weapon_type_test()
        {
            // Arrange
            // Character
            Player player = new Mage("CharacterName");

            // Weapons
            Weapon staff  = new Weapon("Test Staff", "Weapon", "Staff", 1, 1, 1, 1, 1, 1);
            Weapon wand   = new Weapon("Test Wand", "Weapon", "Wand", 1, 1, 0, 1, 1, 1);
            Weapon sword  = new Weapon("Test Sword", "Weapon", "Sword", 1, 1, 1, 1, 1, 1);
            Weapon hammer = new Weapon("Test Hammer", "Weapon", "Hammer", 1, 1, 1, 1, 1, 1);
            Weapon axe    = new Weapon("Test Axe", "Weapon", "Axe", 1, 1, 1, 1, 1, 1);
            Weapon dagger = new Weapon("Test Dagger", "Weapon", "Dagger", 1, 1, 1, 1, 1, 1);
            Weapon bow    = new Weapon("Test Bow", "Weapon", "Bow", 1, 1, 1, 1, 1, 1);
            // Act
            bool bStaff = staff.CanEquipWeapon(player, staff);
            bool bWand = wand.CanEquipWeapon(player, wand);
            bool bSword = sword.CanEquipWeapon(player, sword);
            bool bHammer = hammer.CanEquipWeapon(player, hammer);
            bool bAxe = axe.CanEquipWeapon(player, axe);
            bool bDagger = dagger.CanEquipWeapon(player, dagger);
            bool bBow = bow.CanEquipWeapon(player, bow);

            // Expected to return false if player is not allowed to wear that type of weapon
            // Assert True
            Assert.True(bStaff);
            Assert.True(bWand);
            // Assert False
            Assert.False(bSword);
            Assert.False(bHammer);
            Assert.False(bAxe);
            Assert.False(bDagger);
            Assert.False(bBow);
        }

        [Fact]
        public void Warrior_can_equip_weapon_type_test()
        {
            // Arrange
            // Character
            Player player = new Warrior("CharacterName");
            // Weapons
            Weapon staff = new Weapon("Test Staff", "Weapon", "Staff", 1, 1, 1, 1, 1, 1);
            Weapon wand = new Weapon("Test Wand", "Weapon", "Wand", 1, 1, 0, 1, 1, 1);
            Weapon sword = new Weapon("Test Sword", "Weapon", "Sword", 1, 1, 1, 1, 1, 1);
            Weapon hammer = new Weapon("Test Hammer", "Weapon", "Hammer", 1, 1, 1, 1, 1, 1);
            Weapon axe = new Weapon("Test Axe", "Weapon", "Axe", 1, 1, 1, 1, 1, 1);
            Weapon dagger = new Weapon("Test Dagger", "Weapon", "Dagger", 1, 1, 1, 1, 1, 1);
            Weapon bow = new Weapon("Test Bow", "Weapon", "Bow", 1, 1, 1, 1, 1, 1);
            // Act
            bool bStaff = staff.CanEquipWeapon(player, staff);
            bool bWand = wand.CanEquipWeapon(player, wand);
            bool bSword = sword.CanEquipWeapon(player, sword);
            bool bHammer = hammer.CanEquipWeapon(player, hammer);
            bool bAxe = axe.CanEquipWeapon(player, axe);
            bool bDagger = dagger.CanEquipWeapon(player, dagger);
            bool bBow = bow.CanEquipWeapon(player, bow);

            // Expected to return false if player is not allowed to wear that type of weapon
            // Assert True
            Assert.True(bSword);
            Assert.True(bHammer);
            Assert.True(bAxe);
            // Assert False
            Assert.False(bStaff);
            Assert.False(bWand);
            Assert.False(bDagger);
            Assert.False(bBow);
        }
        [Fact]
        public void Rogue_can_equip_weapon_type_test()
        {
            // Arrange
            // Character
            Player player = new Rogue("CharacterName");
            // Weapons
            Weapon staff = new Weapon("Test Staff", "Weapon", "Staff", 1, 1, 1, 1, 1, 1);
            Weapon wand = new Weapon("Test Wand", "Weapon", "Wand", 1, 1, 0, 1, 1, 1);
            Weapon sword = new Weapon("Test Sword", "Weapon", "Sword", 1, 1, 1, 1, 1, 1);
            Weapon hammer = new Weapon("Test Hammer", "Weapon", "Hammer", 1, 1, 1, 1, 1, 1);
            Weapon axe = new Weapon("Test Axe", "Weapon", "Axe", 1, 1, 1, 1, 1, 1);
            Weapon dagger = new Weapon("Test Dagger", "Weapon", "Dagger", 1, 1, 1, 1, 1, 1);
            Weapon bow = new Weapon("Test Bow", "Weapon", "Bow", 1, 1, 1, 1, 1, 1);
            // Act
            bool bStaff = staff.CanEquipWeapon(player, staff);
            bool bWand = wand.CanEquipWeapon(player, wand);
            bool bSword = sword.CanEquipWeapon(player, sword);
            bool bHammer = hammer.CanEquipWeapon(player, hammer);
            bool bAxe = axe.CanEquipWeapon(player, axe);
            bool bDagger = dagger.CanEquipWeapon(player, dagger);
            bool bBow = bow.CanEquipWeapon(player, bow);

            // Expected to return false if player is not allowed to wear that type of weapon
            // Assert True
            Assert.True(bSword);
            Assert.True(bDagger);
            // Assert False
            Assert.False(bHammer);
            Assert.False(bAxe);
            Assert.False(bStaff);
            Assert.False(bWand);
            Assert.False(bBow);
        }
        [Fact]
        public void Ranger_can_equip_weapon_type_test()
        {
            // Arrange
            // Character
            Player player = new Ranger("CharacterName");
            // Weapons
            Weapon staff = new Weapon("Test Staff", "Weapon", "Staff", 1, 1, 1, 1, 1, 1);
            Weapon wand = new Weapon("Test Wand", "Weapon", "Wand", 1, 1, 0, 1, 1, 1);
            Weapon sword = new Weapon("Test Sword", "Weapon", "Sword", 1, 1, 1, 1, 1, 1);
            Weapon hammer = new Weapon("Test Hammer", "Weapon", "Hammer", 1, 1, 1, 1, 1, 1);
            Weapon axe = new Weapon("Test Axe", "Weapon", "Axe", 1, 1, 1, 1, 1, 1);
            Weapon dagger = new Weapon("Test Dagger", "Weapon", "Dagger", 1, 1, 1, 1, 1, 1);
            Weapon bow = new Weapon("Test Bow", "Weapon", "Bow", 1, 1, 1, 1, 1, 1);
            // Act
            bool bStaff = staff.CanEquipWeapon(player, staff);
            bool bWand = wand.CanEquipWeapon(player, wand);
            bool bSword = sword.CanEquipWeapon(player, sword);
            bool bHammer = hammer.CanEquipWeapon(player, hammer);
            bool bAxe = axe.CanEquipWeapon(player, axe);
            bool bDagger = dagger.CanEquipWeapon(player, dagger);
            bool bBow = bow.CanEquipWeapon(player, bow);

            // Expected to return false if player is not allowed to wear that type of weapon
            // Assert True
            Assert.True(bBow);
            // Assert False
            Assert.False(bSword);
            Assert.False(bDagger);
            Assert.False(bHammer);
            Assert.False(bAxe);
            Assert.False(bStaff);
            Assert.False(bWand);
            
        }
    }
}
