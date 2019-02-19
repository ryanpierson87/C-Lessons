﻿using System;
namespace Interfaces
{
   class Vehicle : IDrivable
    {
        public string Brand { get; set; }
        public Vehicle(string brand = "No Brand",
                       int wheels = 0,
                       double speed = 0)
        {
            Brand = brand;
            Wheels = wheels;
            Speed = speed;
        }

        public int Wheels { get; set; }
        public double Speed { get; set; }

        public void Move()
        {
            Console.WriteLine($"The {Brand} Moves Forward at {Speed} MPH");
        }

        public void Stop()
        {
            Console.WriteLine($"The {Brand} Stops");
            Speed = 0;
        }
    }
}
