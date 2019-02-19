using System;
using System.IO;
using System.Text;

namespace BanasFileIO
{
    class MainClass
    {
        public static void Main()
        {
            #region Introduction
            DirectoryInfo currDir = new DirectoryInfo(".");

            //           DirectoryInfo dereksDir = new DirectoryInfo(@"")

            Console.WriteLine(currDir.FullName);
            Console.WriteLine(currDir.Name);
            Console.WriteLine(currDir.Parent);
            Console.WriteLine(currDir.Attributes);
            Console.WriteLine(currDir.CreationTime);
            Console.WriteLine();


            DirectoryInfo dataDir = new DirectoryInfo(@"/Users/ryanpierson/Desktop/C#Data");

            //DirectoryInfo.Delete(dataDir);

            string[] customers =
            {
                "Bob Smith",
                "Sally Smith",
                "Robert Smith"

            };

            var x = CreateDirect("/Users/ryanpierson/Desktop/DirectoryTest");
            Console.WriteLine(x);

            string textFilePath = x + "/testfile1.txt";

            File.WriteAllLines(textFilePath, customers);

            Console.WriteLine("This code has ran");

            foreach(string cust in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine($"Customer : {cust}");
            }

            //Console.WriteLine("This code has ended");

            DirectoryInfo myDataDir = new DirectoryInfo(x);

            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);

            Console.WriteLine("Matches : {0}", txtFiles.Length);

            foreach(FileInfo file in txtFiles)
            {
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Length);
                Console.WriteLine();
            }
            #endregion


            #region ByteArray

            string textFilePath2 = @"/Users/ryanpierson/Desktop/DirectoryTest/testfile2.txt";

            FileStream fs = File.Open(textFilePath2, FileMode.Create);

            string randString = "This is a random string";

            byte[] rsByteArray = Encoding.Default.GetBytes(randString);

            fs.Write(rsByteArray, 0, rsByteArray.Length);

            fs.Position = 0;

            byte[] fileByteArray = new byte[rsByteArray.Length];

            for(int i = 0; i < rsByteArray.Length; i++)
            {
                fileByteArray[i] = (byte)fs.ReadByte();
            }

            Console.WriteLine(Encoding.Default.GetString(fileByteArray));

            fs.Close();

            #endregion


            #region StreamWriter

            string textFilePath3 = @"/Users/ryanpierson/Desktop/DirectoryTest/testfile3.txt";

            StreamWriter sw = File.CreateText(textFilePath3);

            sw.Write("This is a random ");
            sw.WriteLine("sentence");
            sw.WriteLine("This is another sentence");

            sw.Close();


            StreamReader sr = File.OpenText(textFilePath3);

            Console.WriteLine("Peek : {0}", Convert.ToChar(sr.Peek()));

            Console.WriteLine("1st String: {0}", sr.ReadLine());

            Console.WriteLine("Everything : {0}", sr.ReadToEnd());

            sr.Close();

            #endregion

            #region BinaryWriter

            string textFilePath4 = "/Users/ryanpierson/Desktop/DirectoryTest/testfile4.dat";

            FileInfo datFile = new FileInfo(textFilePath4);

            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

            string randText = "Random Text";
            int myAge = 42;
            double height = 6.25;

            bw.Write(randText);
            bw.Write(myAge);
            bw.Write(height);

            bw.Close();

            BinaryReader br = new BinaryReader(datFile.OpenRead());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());

            br.Close();

            #endregion

        }
        public static string CreateDirect(string path)
        {
            if (!Directory.Exists(path))
            {
                var x = Directory.CreateDirectory(path);
                return x.FullName;
            }
            return path;
        }
    }
}
