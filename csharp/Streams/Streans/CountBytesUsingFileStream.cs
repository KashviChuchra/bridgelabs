using System;
using System.Collections.Generic;
using System.Text;

namespace Streans
{
    internal class CountBytesUsingFileStream
    {
        public void func()
        {
            int count = 0;
            using (FileStream fs=new FileStream("data.txt",FileMode.Open,FileAccess.Read))
            {
                byte[] buffer = new byte[8];
                int bytesRead;
                while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    count+=bytesRead;
                }
            }
            Console.WriteLine(count);
        }
    }
}
