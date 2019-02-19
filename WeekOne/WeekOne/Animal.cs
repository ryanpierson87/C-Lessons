using System;
namespace WeekOne
{
    public class Animal
    {
        public string Name;
        public string Type;

        public bool Living = true;
        public Animal(string name, string type)
        {
            Name = name;
            Type = type;
            Console.WriteLine("Hello, " + name + " the " + type + "!");
        }

        public void Deceased()
        {
            Living = false;
        }

        public void Eat(string food)
        {
            Console.WriteLine(Name + " just ate " + food);
        }

        public void Eat()
        {
            Console.WriteLine(Name + " just ate.");
        }
    }
}
