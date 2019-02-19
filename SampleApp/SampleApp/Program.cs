using System;

namespace SampleApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for(int i = 0; i < args.Length; i++) 
            {
                Console.WriteLine("Arg {0} : {1}", i, args[i]);   
            }
            Console.ReadLine();
        }
    }
}
