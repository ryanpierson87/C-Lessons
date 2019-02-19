using System;
namespace OOPGame
{
    class Battle
    {
        //Warrior Warrior1;
        //Warrior Warrior2;
        /// <summary>
        /// StartFight
        /// Warrior1 Warrior2
        /// 
        /// Loop giving each warrior a chance to attack and block each turn until one dies
        /// 
        /// GetAttackResults
        /// WarriorA, WarriorB
        /// 
        /// Calculations
        ///Calculate 1 warriors attack and the others block
        /// Subtract block from attack
        /// 
        /// If there was damage, subtract that from the health
        /// 
        /// Print inf on who attacked who and for how much damage
        /// Provide the output on the change in health
        /// 
        /// Check if the warriors hea;th fell below 0 and if so print a message and then 
        /// send response that will end the loop
        ///
        /// </summary>
        //public static Battle(Warrior warrior1, Warrior warrior2)
        //{
        //    Warrior1 = warrior1;
        //    Warrior2 = warrior2;
        //}

        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            int i = 0;
            while (true)
            {

                //Console.WriteLine(i);
                if(i % 2 == 0)
                {
                    Attack(warrior1, warrior2);
                    if (GameOverCheck(warrior2))
                    {
                        Console.WriteLine($"{warrior1.Name} has Died and {warrior2.Name} is Victorious");
                        break;
                    }
                }
                else
                {
                    Attack(warrior2, warrior1);
                    if (GameOverCheck(warrior1))
                    {
                        Console.WriteLine($"{warrior2.Name} has Died and {warrior1.Name} is Victorious");
                        break;
                    }
                }
                i++;
            }
        }

        public static void Attack(Warrior warriorA, Warrior warriorB)
        {
            int attack = warriorA.Attack();
            int block = warriorB.Block();
            int damage;
            if((attack - block) < 0)
            {
                damage = 0;
            }else
            {
                damage = attack - block;
            }
            warriorB.Health -= damage;
            Console.WriteLine($"{warriorA.Name} attacked {warriorB.Name} dealing {damage} damage");
            Console.WriteLine($"{warriorB.Name} has {warriorB.Health} Health");
            Console.WriteLine();
        }

        public static bool GameOverCheck(Warrior warrior)
        {
            if(warrior.Health <= 0)
            {
                return true;
            }
            return false;
        }

    }
}
