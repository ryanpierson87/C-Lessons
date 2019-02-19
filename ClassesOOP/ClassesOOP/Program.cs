using System;

namespace ClassesOOP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrrr"
            };

            grover.Sound = "Woooooooof";

            whiskers.MakeSound();
            grover.MakeSound();

            whiskers.SetAnimalIDInfo(12345, "Sally Smith");

            grover.SetAnimalIDInfo(12346, "Paul Brown");

            whiskers.GetAnimalIDInfo();
            grover.GetAnimalIDInfo();

            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();

            Console.WriteLine("Is my animal healthy : {0}",
                getHealth.HealthyWeight(11, 46));

            //Animal cat = new Animal();

            //cat.SetName("Whiskers");
            //cat.Sound = "Meow";

            //Console.WriteLine("The cat is named {0} and says {1}",
            //    cat.GetName(), cat.Sound);

            //cat.Owner = "Derek";

            //Console.WriteLine("{0} own is {1}", cat.GetName(), cat.Owner);

            //Console.WriteLine("{0} shelter id is {1}", cat.GetName(), cat.idNum);

            //Animal fox = new Animal("Oscar", "Rawrrr");

            //Console.WriteLine("# of Animals: {0}", Animal.NumOfAnimals);

            //Console.WriteLine("Area of Rectangle : {0}",
            //ShapeMath.GetArea("rectangle", 5, 6));

            //Animal fox = new Animal()
            //{
            //    name = "Red",
            //    sound = "Raaww"

            //};

            //fox.MakeSound();

            //Console.WriteLine("# of Animals : {0}",
            //Animal.GetNumAnimals());

        }
    }
}
