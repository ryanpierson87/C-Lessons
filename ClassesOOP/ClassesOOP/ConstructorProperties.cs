using System;

namespace ClassesOOP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Animal cat = new Animal();

            cat.SetName("Whiskers");
            cat.Sound = "Meow";

            Console.WriteLine("The cat is named {0} and says {1}",
                cat.GetName(), cat.Sound);
            //int? randNum = null;

            //if(randNum == null)
            //{
            //    Console.WriteLine("randNum is null");
            //}

            //if (!randNum.HasValue)
            //{
            //    Console.WriteLine("randNum is null");
            //}

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
