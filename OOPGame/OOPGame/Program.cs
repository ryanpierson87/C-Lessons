using System;

namespace OOPGame
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Warrior maximus = new Warrior("Maximus", 1000, 120, 40);
            //name, max health, max attack, max block

            Warrior bob = new Warrior("Bob", 1000, 120, 40);

            Battle.StartFight(maximus, bob);
        }
    }
}
