using System;
namespace Inheritance_Exer
{
    public class Animal         
    {
        public bool Living { get; set; } = true;
        public string Name { get; set; }
        public int Age { get; protected set; }
        public string Voice { get; }

        public Animal(string name, int? age, string voice) 
        {
            Name = name;
            if (age == null) {
                Age = 1;
            }
            else
            {
                Age = (int)age;
            }
            Voice = voice;
        }
       
        public void Birthday()
        {
            Age += 1;
            Console.WriteLine("Happy Birthday " + Name);
        }

        public void Call()
        {
            Console.WriteLine(Voice);
        }


    }
}
