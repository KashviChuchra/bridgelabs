using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Streans.Basics
{
    internal class Class1
    {
        public void ReadFile()
        {
            FileStream fs = new FileStream("C:\\Users\\chuch\\OneDrive\\Desktop\\file\\input.txt", FileMode.Open);
            byte[] buffer = new byte[1024];
            int bytesData=fs.Read(buffer, 0, buffer.Length);
            string text=Encoding.UTF8.GetString(buffer,0,bytesData);
            Console.WriteLine(text);
            fs.Close();
        }

        public void WriteFile()
        {
            FileStream fs = new FileStream("C:\\Users\\chuch\\OneDrive\\Desktop\\file\\output.txt", FileMode.Create);
            string text = "File created using FileStream";
            byte[] buffer=Encoding.UTF8.GetBytes(text);
            fs.Write(buffer,0,buffer.Length);
            fs.Close();
        }

        public void ReadLargeFile()
        {
            FileStream fs = new FileStream("C:\\Users\\chuch\\OneDrive\\Desktop\\file\\input.txt", FileMode.Open);
            byte[] buffer = new byte[10];
            int bytesData;
            string text = "";
            Console.WriteLine("File Reading Display: ");

            while ((bytesData = fs.Read(buffer, 0, buffer.Length)) > 0){
                 text = Encoding.UTF8.GetString(buffer, 0, bytesData);
                Console.WriteLine(text);

            }
            fs.Close();
        }

        public void CopyingFile(string sourcepath, string destinationpath) {

            FileStream reader= new FileStream(sourcepath, FileMode.Open);
            FileStream writer = new FileStream(destinationpath, FileMode.Create);

            byte[] buffer = new byte[1024];
            int byteData;

            // copy source to destination file
            while ((byteData = reader.Read(buffer, 0, buffer.Length)) > 0)
            {
                writer.Write(buffer, 0, byteData);

            }
            reader.Close();
            writer.Close();

            //FileMode.Create is not for Reading files, you can't perform .Read operation with writer file stream

            // If want to Read file, create another file stream
            FileStream destinationFileReader = new FileStream(destinationpath, FileMode.Open);

            int destinationFileRead;
            Console.WriteLine("Copied File Content: ");
            while ((destinationFileRead = destinationFileReader.Read(buffer, 0, buffer.Length)) > 0)
            {
                string text = Encoding.UTF8.GetString(buffer, 0, destinationFileRead);
                Console.Write(text + " ");
            }
            destinationFileReader.Close();
        }
        // file stream -> byte -> readByte -> string -> read string
        // string -> byte -> write -> file stream save


    }
}
