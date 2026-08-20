using System;
using System.Collections.Generic;
using System.Text;

namespace Streans.Basics
{
    // This class contains streamreader/streamwriter
    internal class Class2
    {
        public void ReadFileUsingStreamReader()
        {
            StreamReader reader = new StreamReader("C:\\Users\\chuch\\OneDrive\\Desktop\\file\\input.txt");
            //string text = reader.ReadToEnd();
            string text = reader.ReadLine();
            Console.WriteLine(text);
            reader.Close();

        }

        public void ReadFileLineByLine()
        {
            StreamReader reader = new StreamReader("C:\\Users\\chuch\\OneDrive\\Desktop\\file\\input.txt");
            string line = "";
            while ( (line=reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            reader.Close();
        }

        public void WriterFileUsingStreamWriter()
        {
            StreamWriter writer = new StreamWriter("C:\\Users\\chuch\\OneDrive\\Desktop\\file\\input.txt");
            writer.WriteLine("Writing using stream writer");
            writer.WriteLine("Writing using stream writer-2");
            writer.Close();
        }

        public void AppendText()
        {
            StreamWriter writer = new StreamWriter("C:\\Users\\chuch\\OneDrive\\Desktop\\file\\input.txt", true);
            writer.WriteLine("Text Appended");
            writer.WriteLine("Text Appended1");
            writer.Close();
        }

        public void CountLines()
        {
            StreamReader reader = new StreamReader("C:\\Users\\chuch\\OneDrive\\Desktop\\file\\input.txt");
            int count = 0;
            string line;
            while((line=reader.ReadLine()) != null){
                count++;
            }
            Console.WriteLine($"Total no of lines: {count}");
        }

        public void CountLinesContainingWord(string word)
        {
            StreamReader reader = new StreamReader("C:\\Users\\chuch\\OneDrive\\Desktop\\file\\input.txt");
            int count = 0;
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Contains(word))
                {
                    count++;
                }
            }
            Console.WriteLine($"Total no of lines containing {word}: {count}");
        }

        public void CountWordsInFile()
        {
            StreamReader reader = new StreamReader("C:\\Users\\chuch\\OneDrive\\Desktop\\file\\input.txt");
            int count = 0;
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] strArray = line.Split(" ");
                count += strArray.Length;
            }
            Console.WriteLine($"Total no of words in a file: {count}");
        }

        public void PrintStudents(int marks)
        {
            Console.WriteLine($"Printing students whose marks are greater than {marks}");
            StreamReader reader = new StreamReader("C:\\Users\\chuch\\OneDrive\\Desktop\\file\\input.txt");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] strArray=line.Split(' ', StringSplitOptions.RemoveEmptyEntries);                
                if ((int.Parse(strArray[1])) > marks)
                {
                    Console.WriteLine(line);
                }

            }
            reader.Close();
        }
    }
}
