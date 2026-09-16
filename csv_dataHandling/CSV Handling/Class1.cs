using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace IO_Programming.CSV_Handling
{
    internal class Class1
    {
        // Read entire file
        public void ReadEntireFile(string filePath)
        {
            string data=File.ReadAllText(filePath);
            Console.WriteLine(data);
        }

        public void ReadTextLineByLine(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int i = 1;
            foreach(string line in lines)
            {
                Console.WriteLine($"line{i}:\t{line}");
                i++;
            }
        }

        public void ReadTextExceptSeperator(string filePath)
        {
            string[] lines=File.ReadAllLines(filePath);
            foreach(string line in lines)
            {
                string[] columns = line.Split(',');
              
                Console.Write($"Id:{columns[0]}\tName:{columns[1]}\tAge:{columns[2]}");
                // Or
                //foreach(string column in columns)
                //{
                //    Console.Write(column + " ");
                //}
                
                Console.WriteLine();
            }
        }

        public void ReadFileSkipHeader(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            for(int i = 1; i < lines.Length; i++)
            {
                string[] columns = lines[i].Split(',');
                foreach(string c  in columns)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
  
        public List<Student> ConvertCSVData_IntoObject(string filePath)
        {
            // Objective: CSV -> Object(Student) -> List<Student>

            List<Student> students = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                if (!string.IsNullOrWhiteSpace(line))
                {
                    string[] columns = line.Split(',');
                    if (columns.Length >= 3)
                    {
                        Student stu = new Student();
                        stu.Id = int.Parse(columns[0].Trim('"', ' '));
                        stu.Name = columns[1].Trim('"', ' ');
                        stu.Age = int.Parse(columns[2].Trim('"', ' '));
                        students.Add(stu);

                        // or
                       //  Student student = new Student(
                      //  int.Parse(columns[0]),columns[1],int.Parse(columns[2]));
                    }
                }
            }
            return students;
        }


    }
}
