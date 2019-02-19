using System;

namespace WeekThreeAssignment
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MPC live = new MPC();

            live.Sample(30);

            double audio = live.Sample(30.0);

            Console.WriteLine("The sample is " + audio);



        }
    }
}
