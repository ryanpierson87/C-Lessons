using System;
namespace Inheritance_Exer
{
    public class Bird : Animal
    {
        public Bird(string name, int? age, string? voice) : base(name, age)
        {}
        public void Fly() 
        {
            Console.WriteLine(Name + " is flying");
        }
    }
}
