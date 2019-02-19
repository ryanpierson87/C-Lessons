using System;
namespace WeekOne
{
    public class Bird : Animal
    {
        public string Feathers;
        public Bird(string name, string feather_color) : base(name, "bird")
        {
            Name = name;
            Feathers = feather_color;

        }
        public void Fly()
        {
            Console.WriteLine(Name + " is flying away!");
        }

    }
}
