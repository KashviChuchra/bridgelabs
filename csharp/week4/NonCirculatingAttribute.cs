using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class NonCirculatingAttribute: Attribute
    {
        public string Message { get; set; }
        public NonCirculatingAttribute(string message){
            Message=message;
        }
    }
}
