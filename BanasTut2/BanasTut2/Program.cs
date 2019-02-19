using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

using System.Globalization;

namespace BanasTut2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long num1 = 1234;
            int num2 = (int)num1;

            Console.WriteLine("Orig : {0} Cast : {1}", num1.GetType(), num2.GetType());
        }

    }
}
