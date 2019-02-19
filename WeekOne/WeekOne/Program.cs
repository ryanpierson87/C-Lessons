using System;

namespace WeekOne
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Animal benny = new Animal("Benny", "cow");
            benny.Eat("grass");
            Animal joseph = new Animal("Joseph", "llama");
            joseph.Eat();
            Bird tweety = new Bird("Tweety", "yellow");
            tweety.Fly();
        }
    }
}
