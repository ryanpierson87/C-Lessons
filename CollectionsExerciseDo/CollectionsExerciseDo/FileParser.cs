using System;
using System.IO;

namespace CollectionsExerciseDo
{
    public class FileParser : IFileParser
    {
        //string Path;
        int arraySize;
        string[] array;
        string x;

        public string[] Read(string path)
        {

            int i = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                while (true)
                {
                    if (i == 0)
                    {
                        arraySize = int.Parse(reader.ReadLine());
                        array = new string[arraySize];
                        //Console.WriteLine("Initialize");
                        //Console.WriteLine();
                    }
                    else
                    {
                        x = reader.ReadLine();
                        array[i - 1] = x;
                        //Console.WriteLine(x);
                    }

                    i++;
                    if(i > arraySize)
                    {
                        break;
                    }
                }

            }

            return array;
            //StreamReader reader = File.OpenText(path);


        }


        public FileParser()
        {

        }
    }
}
