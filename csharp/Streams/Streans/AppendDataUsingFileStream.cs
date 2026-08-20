using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Streans
{
    internal class AppendDataUsingFileStream
    {
        public void func()
        {
           
            using(FileStream fs= new FileStream("log.txt", FileMode.Append, FileAccess.Write))
            {
                string message = "New Log entry added";
                byte[] buffer = Encoding.UTF8.GetBytes(message);
                fs.Write(buffer, 0, buffer.Length);
            }
            Console.WriteLine("Data appended Successfully!");
        }
    }
}
