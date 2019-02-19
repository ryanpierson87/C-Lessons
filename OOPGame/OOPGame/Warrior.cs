using System;
namespace OOPGame
{
    public class Warrior
    {
        public string Name { get; }
        public int Health;
        public int MaxAttack { get; }
        public int MaxBlock { get; }
        Random random = new Random();
        /// <summary>
        /// Name Health Attack_max Block_max
        /// 
        /// Random numbers
        /// 
        /// Attack
        /// Generate a random attack from 1 to maximum attack
        /// 
        /// Block
        /// Generate a random block from 1 to maximum block
        /// 
        /// </summary>
        public Warrior(string name, int health, int attack, int block)
        {
            Name = name;
            Health = health;
            MaxAttack = attack;
            MaxBlock = block;
        }

        public int Attack()
        {
            return random.Next(1, MaxAttack);
        }

        public int Block()
        {
            return random.Next(1, MaxBlock);
        }
    }
}





    