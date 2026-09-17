using Streans.Basics;
using System;
using System.IO;
using System.Text;

//// Data in RAM
//byte[] writeBuffer = { 65, 66, 67 }; 
//// Open a file in Write Mode
//using (FileStream writeStream = new FileStream("data.txt", FileMode.Create, FileAccess.Write))
//{
//    // push the data into file
//    writeStream.Write(writeBuffer, 0, writeBuffer.Length);
//}
//Console.WriteLine("Data sent through the write pipe!");

//// --- STEP 2: READ FROM FILE ---
//byte[] readBuffer;
//using (FileStream readStream = new FileStream("data.txt", FileMode.Open, FileAccess.Read))
//{
//    // Create a buffer matching the file size
//    readBuffer = new byte[readStream.Length];

//    // Pull the bytes into our readBuffer
//    readStream.Read(readBuffer, 0, readBuffer.Length);
//}
//Console.WriteLine("Data pulled back through the read pipe!");

//// --- STEP 3: CONVERT TO TEXT & DISPLAY ---
//// Convert bytes back to readable text
//string result = Encoding.ASCII.GetString(readBuffer);
//Console.WriteLine($"The bytes converted back to text: {result}"); 




// open data.txt file (already present) - cannot perform write
//using (FileStream fs = new FileStream("data.txt", FileMode.Open, FileAccess.Read))
//using (BufferedStream bs = new BufferedStream(fs))
//using (FileStream fsOut = new FileStream("output.txt", FileMode.Create, FileAccess.Write))
//{
//    int byteData;
//    while ((byteData = bs.ReadByte()) != -1)
//    {
//        fsOut.WriteByte((byte)byteData);
//    }
//};

// create output.txt file to store result

namespace Streans;
class Program
{
    public static void Main(string[] args)
    {
        Class1 obj = new Class1();
        //obj.ReadFile();
        //obj.WriteFile();
        //obj.ReadLargeFile();
        //obj.CopyingFile("C:\\Users\\chuch\\OneDrive\\Desktop\\file\\input.txt", "C:\\Users\\chuch\\OneDrive\\Desktop\\file\\output.txt");

        Class2 obj2 = new Class2();
        //obj2.ReadFileUsingStreamReader();
        //obj2.ReadFileLineByLine();
        //obj2.WriterFileUsingStreamWriter();
        //obj2.AppendText();
        //obj2.CountLines();
        //obj2.CountLinesContainingWord("fruit");
        //obj2.CountWordsInFile();
        obj2.PrintStudents(80);
    }
}
