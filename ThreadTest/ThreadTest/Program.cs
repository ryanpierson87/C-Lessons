using System;
using System.Threading;

namespace ThreadTest
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(() => CountTo(10));
            t.Start();

            // You can use multiline lambdas
            new Thread(() =>
            {
                CountTo(5);
                CountTo(6);
            }).Start();

            Console.ReadLine();
        }

        static void CountTo(int maxNum)
        {
            for (int i = 0; i <= maxNum; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}