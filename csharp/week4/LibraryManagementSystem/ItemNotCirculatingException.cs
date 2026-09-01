using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    public class ItemNotCirculatingException: Exception
    {
        public int ItemId { get; }
        public ItemNotCirculatingException(int itemid) { ItemId = itemid; }
        public ItemNotCirculatingException(int itemid, string message) : base(message) { ItemId = itemid; }
    }
}
