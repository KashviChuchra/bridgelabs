using IO_Programming.CSV_Handling;
using System;
namespace IO_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            string filePath = @"C:\Users\chuch\OneDrive\Desktop\file\students.csv"; 
            obj.ReadEntireFile(filePath);
            obj.ReadTextLineByLine(filePath);

            Console.WriteLine();
            obj.ReadTextExceptSeperator(filePath);
            Console.WriteLine();
            obj.ReadFileSkipHeader(filePath);
            Console.WriteLine();
            List<Student> result=obj.ConvertCSVData_IntoObject(filePath);
            foreach (Student stu in result)
            {
                Console.WriteLine(stu);
            }
        }   
    }
}