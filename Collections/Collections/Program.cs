using System;
using System.Collections.Generic;
namespace Collections
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Cell[][] sheet = new Cell[100][];

            //sheet[0] = new Cell[10];


            //for(int rowIndex = 0; rowIndex < sheet.Length; rowIndex++)
            //{
            //    sheet[rowIndex] = new Cell[10]; //Create a row of 10 Cells 
            //    for(int colIndex = 0; colIndex < sheet[rowIndex].Length; colIndex++)
            //    {
            //        sheet[rowIndex][colIndex] = new Cell();
            //    }

            //}
            //foreach(Cell[] row in sheet)
            //{
            //    foreach(Cell cell in row)
            //    { System.Console.Write(cell); }
            //}
            //Console.WriteLine();

            //Cell[,] sheet = new Cell[100, 10];
            //Console.WriteLine(sheet.Length);

            //Console.WriteLine(sheet[0, 0]);

            //for(int rowIndex = 0; rowIndex < sheet.GetLength(0); rowIndex++)
            //{
            //    for(int colIndex = 0; colIndex < sheet.GetLength(1); colIndex++)
            //    {
            //        sheet[rowIndex, colIndex] = new Cell();
            //    }
            //}

            //Console.WriteLine(sheet[2, 3]);

            //List<string> students;
            List<string> students = new List<string>();

            students.Add("Sue");
            System.Console.WriteLine(students);
            students.Add("Bill");
            students.Add("Allen");
            System.Console.WriteLine(students.Count);

            List<string> more_students = new List<string>() {"Ryan", "Andrew", "James", "Linda" };
            string[] studentArray = more_students.ToArray();

            //Inserts the item at the specified location
            students.Insert(1, "Frank");
            students.RemoveAt(1);

            students.Remove("Ryan");

            students.Sort(); 

            Student newStudent = newStudent Student() { Name = "Joe", GradeLevel = 2};
            int index = students.BinarySearch(newStudent);
            if(index < 0)
            {
                students.Insert(~index, newStudent);
            }

            foreach(Student student in students)
            {
                Console.WriteLine()
            }
        }
    }
}
