using System;
using System.Numerics;

namespace BanasTut1
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string randString = "This is a string";

            Console.WriteLine("A = a : {0}",
                String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Pad Left : {0}",
                randString.PadLeft(20, '.'));

            Console.WriteLine("Pad Right : {0}",
                randString.PadRight(20, '.'));

            Console.WriteLine("Trim : {0}",
                randString.Trim());

            Console.WriteLine("Uppercase : {0}",
                randString.ToUpper());

            Console.WriteLine("Lowercase : {0}",
                randString.ToLower());

            string newString = String.Format("{0} saw a {1} {2} in the {3}",
                "Paul", "rabbit", "eating", "field");

            Console.Write(@"Exactly What I Typed ' \");
        }
    }
}
