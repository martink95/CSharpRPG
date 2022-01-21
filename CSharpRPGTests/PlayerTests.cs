using CSharpRPG.Items.Weapons;
using CSharpRPG.Players;
using CSharpRPG.Players.Classes;
using System;
using Xunit;
using Xunit.Sdk;

namespace CSharpRPGTests
{
    public class PlayerTests
    {

        [Fact]
        public void EquipWeaponLevelPlayer_LevelOne_ReturnsTrue()
        {
            Player player = new Player("CharacterName");
            Weapon weapon = new Weapon(_name: "Test Wand", _slot: "Weapon", _type: "Wand", _lvl: 1, _int: 2, _str: 0, _dex: 0, _dmg: 12, _aspeed: 1);

            Assert.True(weapon.CanEquipLevel(player, weapon));
        }
        [Fact]
        public void EquipWeaponLevelPlayer_LevelTwo_ReturnsFalse()
        {
            Player player = new Player("CharacterName");
            Weapon weapon = new Weapon(_name: "Test Wand", _slot: "Weapon", _type: "Wand", _lvl: 2, _int: 2, _str: 0, _dex: 0, _dmg: 12, _aspeed: 1);

            Assert.False(weapon.CanEquipLevel(player, weapon));
        }

        [Theory]
        [InlineData("Test Staff", "Weapon", "Staff", 1, 1, 1, 1, 1, 1, true)]
        [InlineData("Test Wand", "Weapon", "Wand", 1, 1, 1, 1, 1, 1, true)]
        [InlineData("Test Sword", "Weapon", "Sword", 1, 1, 1, 1, 1, 1, false)]
        [InlineData("Test Hammer", "Weapon", "Hammer", 1, 1, 1, 1, 1, 1, false)]
        [InlineData("Test Axe", "Weapon", "Axe", 1, 1, 1, 1, 1, 1, false)]
        [InlineData("Test Dagger", "Weapon", "Dagger", 1, 1, 1, 1, 1, 1, false)]
        [InlineData("Test Bow", "Weapon", "Bow", 1, 1, 1, 1, 1, 1, false)]
        public void EquipWeaponTypeMage_AllWeapons_ReturnsSameValue(string name, string slot, string type, int lvl, int inte, int str, int dex, int dmg, int aspeed, bool expected)
        {

            Player player = new Mage("CharacterName");
            Weapon weapon = new Weapon(name, slot, type, lvl, inte, str, dex, dmg, aspeed);
            Assert.Equal(expected, weapon.CanEquipWeapon(player, weapon));
        }

        [Theory]
        [InlineData("Test Staff", "Weapon", "Staff", 1, 1, 1, 1, 1, 1, false)]
        [InlineData("Test Wand", "Weapon", "Wand", 1, 1, 1, 1, 1, 1, false)]
        [InlineData("Test Sword", "Weapon", "Sword", 1, 1, 1, 1, 1, 1, true)]
        [InlineData("Test Hammer", "Weapon", "Hammer", 1, 1, 1, 1, 1, 1, true)]
        [InlineData("Test Axe", "Weapon", "Axe", 1, 1, 1, 1, 1, 1, true)]
        [InlineData("Test Dagger", "Weapon", "Dagger", 1, 1, 1, 1, 1, 1, false)]
        [InlineData("Test Bow", "Weapon", "Bow", 1, 1, 1, 1, 1, 1, false)]
        public void EquipWeaponTypeWarrior_AllWeapons_ReturnsSameValue(string name, string slot, string type, int lvl, int inte, int str, int dex, int dmg, int aspeed, bool expected)
        {

            Player player = new Warrior("CharacterName");
            Weapon weapon = new Weapon(name, slot, type, lvl, inte, str, dex, dmg, aspeed);
            Assert.Equal(expected, weapon.CanEquipWeapon(player, weapon));
        }

        [Theory]
        [InlineData("Test Staff", "Weapon", "Staff", 1, 1, 1, 1, 1, 1, false)]
        [InlineData("Test Wand", "Weapon", "Wand", 1, 1, 1, 1, 1, 1, false)]
        [InlineData("Test Sword", "Weapon", "Sword", 1, 1, 1, 1, 1, 1, true)]
        [InlineData("Test Hammer", "Weapon", "Hammer", 1, 1, 1, 1, 1, 1, false)]
        [InlineData("Test Axe", "Weapon", "Axe", 1, 1, 1, 1, 1, 1, false)]
        [InlineData("Test Dagger", "Weapon", "Dagger", 1, 1, 1, 1, 1, 1, true)]
        [InlineData("Test Bow", "Weapon", "Bow", 1, 1, 1, 1, 1, 1, false)]
        public void EquipWeaponTypeRogue_AllWeapons_ReturnsSameValue(string name, string slot, string type, int lvl, int inte, int str, int dex, int dmg, int aspeed, bool expected)
        {

            Player player = new Rogue("CharacterName");
            Weapon weapon = new Weapon(name, slot, type, lvl, inte, str, dex, dmg, aspeed);
            Assert.Equal(expected, weapon.CanEquipWeapon(player, weapon));
        }

        [Theory]
        [InlineData("Test Staff", "Weapon", "Staff", 1, 1, 1, 1, 1, 1, false)]
        [InlineData("Test Wand", "Weapon", "Wand", 1, 1, 1, 1, 1, 1, false)]
        [InlineData("Test Sword", "Weapon", "Sword", 1, 1, 1, 1, 1, 1, false)]
        [InlineData("Test Hammer", "Weapon", "Hammer", 1, 1, 1, 1, 1, 1, false)]
        [InlineData("Test Axe", "Weapon", "Axe", 1, 1, 1, 1, 1, 1, false)]
        [InlineData("Test Dagger", "Weapon", "Dagger", 1, 1, 1, 1, 1, 1, false)]
        [InlineData("Test Bow", "Weapon", "Bow", 1, 1, 1, 1, 1, 1, true)]
        public void EquipWeaponType_Ranger_ReturnsSameValue(string name, string slot, string type, int lvl, int inte, int str, int dex, int dmg, int aspeed, bool expected)
        {
            Player player = new Ranger("CharacterName");
            Weapon weapon = new Weapon(name, slot, type, lvl, inte, str, dex, dmg, aspeed);
            Assert.Equal(expected, weapon.CanEquipWeapon(player, weapon));
        }

        [Theory]
        [InlineData(13, "Intellect")]
        [InlineData(2, "Strength")]
        [InlineData(2, "Dexterity")]
        public void LevelUpMage_CorrectStats_ReturnsSameValue(int expectedValue, string thingToTest)
        {
            Player player = new Mage("CharacterName");
            int actualValue = 0;
            player.LevelUp();
            
            if (thingToTest == "Intellect")
            {
                 actualValue = player.Intellect;
            }
            if (thingToTest == "Strength")
            {
                actualValue = player.Strength;
            }
            if (thingToTest == "Dexterity")
            {
                actualValue = player.Dexterity;
            }

            Assert.Equal(expectedValue, actualValue);
        }

        [Theory]
        [InlineData(2, "Intellect")]
        [InlineData(8, "Strength")]
        [InlineData(4, "Dexterity")]
        public void LevelUpWarrior_CorrectStats_ReturnsSameValue(int expectedValue, string thingToTest)
        {
            Player player = new Warrior("CharacterName");
            player.LevelUp();
            int actualValue = 0;

            if (thingToTest == "Intellect")
            {
                actualValue = player.Intellect;
            }
            if (thingToTest == "Strength")
            {
                actualValue = player.Strength;
            }
            if (thingToTest == "Dexterity")
            {
                actualValue = player.Dexterity;
            }

            Assert.Equal(expectedValue, actualValue);
        }

        [Theory]
        [InlineData(2, "Intellect")]
        [InlineData(3, "Strength")]
        [InlineData(10, "Dexterity")]
        public void LevelUpRogue_CorrectStats_ReturnsSameValue(int expectedValue, string thingToTest)
        {
            Player player = new Rogue("CharacterName");
            player.LevelUp();
            int actualValue = 0;

            if (thingToTest == "Intellect")
            {
                actualValue = player.Intellect;
            }
            if (thingToTest == "Strength")
            {
                actualValue = player.Strength;
            }
            if (thingToTest == "Dexterity")
            {
                actualValue = player.Dexterity;
            }

            Assert.Equal(expectedValue, actualValue);
        }

        [Theory]
        [InlineData(2, "Intellect")]
        [InlineData(2, "Strength")]
        [InlineData(12, "Dexterity")]
        public void LevelUpRanger_CorrectStats_ReturnsSameValue(int expectedValue, string thingToTest)
        {
            Player player = new Ranger("CharacterName");
            player.LevelUp();
            int actualValue = 0;

            if (thingToTest == "Intellect")
            {
                actualValue = player.Intellect;
            }
            if (thingToTest == "Strength")
            {
                actualValue = player.Strength;
            }
            if (thingToTest == "Dexterity")
            {
                actualValue = player.Dexterity;
            }

            Assert.Equal(expectedValue, actualValue);
        }

        [Theory]
        [InlineData(8, "Intellect")]
        [InlineData(1, "Strength")]
        [InlineData(1, "Dexterity")]
        public void CreateMage_CorrectStats_ReturnsSameValue(int expectedValue, string thingToTest)
        {
            Player player = new Mage("CharacterName");
            int actualValue = 0;

            if (thingToTest == "Intellect")
            {
                actualValue = player.Intellect;
            }
            if (thingToTest == "Strength")
            {
                actualValue = player.Strength;
            }
            if (thingToTest == "Dexterity")
            {
                actualValue = player.Dexterity;
            }

            Assert.Equal(expectedValue, actualValue);
        }

        [Theory]
        [InlineData(1, "Intellect")]
        [InlineData(5, "Strength")]
        [InlineData(2, "Dexterity")]
        public void CreateWarrior_CorrectStats_ReturnsSameValue(int expectedValue, string thingToTest)
        {
            Player player = new Warrior("CharacterName");
            int actualValue = 0;

            if (thingToTest == "Intellect")
            {
                actualValue = player.Intellect;
            }
            if (thingToTest == "Strength")
            {
                actualValue = player.Strength;
            }
            if (thingToTest == "Dexterity")
            {
                actualValue = player.Dexterity;
            }

            Assert.Equal(expectedValue, actualValue);
        }

        [Theory]
        [InlineData(1, "Intellect")]
        [InlineData(2, "Strength")]
        [InlineData(6, "Dexterity")]
        public void CreateRogue_CorrectStats_ReturnsSameValue(int expectedValue, string thingToTest)
        {
            Player player = new Rogue("CharacterName");
            int actualValue = 0;

            if (thingToTest == "Intellect")
            {
                actualValue = player.Intellect;
            }
            if (thingToTest == "Strength")
            {
                actualValue = player.Strength;
            }
            if (thingToTest == "Dexterity")
            {
                actualValue = player.Dexterity;
            }

            Assert.Equal(expectedValue, actualValue);
        }

        [Theory]
        [InlineData(1, "Intellect")]
        [InlineData(1, "Strength")]
        [InlineData(7, "Dexterity")]
        public void CreateRanger_CorrectStats_ReturnsSameValue(int expectedValue, string thingToTest)
        {
            Player player = new Ranger("CharacterName");
            int actualValue = 0;

            if (thingToTest == "Intellect")
            {
                actualValue = player.Intellect;
            }
            if (thingToTest == "Strength")
            {
                actualValue = player.Strength;
            }
            if (thingToTest == "Dexterity")
            {
                actualValue = player.Dexterity;
            }

            Assert.Equal(expectedValue, actualValue);
        }

    }
}
