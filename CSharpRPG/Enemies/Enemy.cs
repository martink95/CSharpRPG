using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpRPG.Players;

namespace CSharpRPG.Enemies
{
    public class Enemy
    {

        public string Name { get; set; }
        public int Health  { get; set; }
        public int Damage { get; set; }

        public Enemy(string _name, Player _player)
        {
            Name = _name;
            double enemyDamage = _player.Level * 5 / 1.2;
            Damage = (int)enemyDamage;
            double enemyHealth = _player.Level * 80 / 1.15;
            Health = (int)enemyHealth;
        }

    }
}
