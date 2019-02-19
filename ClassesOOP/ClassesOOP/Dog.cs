using System;
namespace ClassesOOP
{
    class Dog : Animal
    {
        public Dog(string name = "No Name", string sound = "No Sound", string sound2 = "No Sound 2")
        :base(name, sound)
        {
            Sound2 = sound2;
        }

        public string Sound2 { get; set; } = "Grrrr";

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }

    }
}
