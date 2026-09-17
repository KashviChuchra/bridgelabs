using System;
using System.Collections.Generic;
using System.Text;

namespace AnnotationReflection.Annotation
{
    [AttributeUsage(AttributeTargets.Method,AllowMultiple = true)]
    internal class BugReportAttribute : Attribute
    {
        public string Description { get; set; }
        public BugReportAttribute(string description)
        {
            Description=description;
        }
    }

    internal class Bug
    {
        [BugReport("A")]
        [BugReport("B")]
        public void PrintBugReport()
        {
            Console.WriteLine("Bug reports.. ");
        }
    }
}
