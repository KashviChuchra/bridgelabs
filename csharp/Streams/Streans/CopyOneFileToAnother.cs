using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Streans
{
    internal class CopyOneFileToAnother
    {
        public void func()
        {
            if (!File.Exists("source.txt"))
            {
                Console.WriteLine("Source file doesnot exist");
                return;
            }
            using(FileStream source= new FileStream("source.txt", FileMode.Open, FileAccess.Read))
            {
                using (FileStream destination = new FileStream("backup.txt", FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer= new byte[10];
                    // This only reads one chunk
                    //int bytesRead=source.Read(buffer, 0, buffer.Length); 
                    int bytesRead;
                    while ((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0){
                        destination.Write(buffer, 0, bytesRead);

                    }



                }

            }
            Console.WriteLine("File copied successfully.");
        }
    }
}
