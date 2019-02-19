using System;
using System.Collections;

namespace CollectionsExerciseDo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IFileParser parse = new FileParser();
            string[] result = parse.Read("data.txt");
            //Print Array Contents
            foreach(var i in result)
            {
                Console.WriteLine(i);
            }

            result.Where();

        }
    }
}
