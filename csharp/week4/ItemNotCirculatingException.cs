using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    internal class ItemNotCirculatingException: Exception
    {
        public ItemNotCirculatingException() { }
        public ItemNotCirculatingException(string message) : base(message) { }
    }
}
