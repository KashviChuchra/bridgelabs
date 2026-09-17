using System;
using System.Collections.Generic;
using System.Text;

namespace Streans
{
    class BufferedStream
    {
        // open data.txt file (already present) - cannot perform write
        using (FileStream fs= new FileStream("data.txt", FileMode.Open, FileAccess.Read));
        using (BufferedStream bs = new BufferedStream(fs));
        
        // create output.txt file to store result
        using(FileStream fsOut= new FileStream("output.txt", FileMode.Create, FileAccess.Write))
        {
             int byteData;
             while((byteData=bs.ReadByte()) !=-1){
                fsOut.WriteByte(byteData);
             }
                Console.WriteLine("success!");
        }

       

    }
}
