using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionCode
{
    public class DatabaseConnection
    {
        public void Connect()
        {
            Console.WriteLine("Database is connected");
        }
        public void Disconnect()
        {
            Console.WriteLine("Database is disconnected");
        }
    }
}
