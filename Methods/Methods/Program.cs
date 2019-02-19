using System;

namespace Methods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //PrintInfo(zipCode: 15147, name: "Derek");
            CarColor car1 = CarColor.Blue;
            PaintCar(car1);
        }

        enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Red,
            Yellow
        }

        static void PaintCar(CarColor cc)
        {
            Console.WriteLine("The car was painted {0} with the code {1}",
                cc, (int)cc);
        }

        //static void PrintInfo(string name, int zipCode)
        //{
        //    Console.WriteLine("{0} lives in the zip code {1}", name, zipCode);
        //}

    }

}

