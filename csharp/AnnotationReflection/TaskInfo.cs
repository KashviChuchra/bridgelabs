using System;
using System.Collections.Generic;
using System.Text;

namespace AnnotationReflection.Annotation
{
    internal class TaskInfoAttribute: Attribute
    {
        public string Priority { get; set; }
        public string AssignedPerson { get; set; }

        public TaskInfoAttribute(string priority, string assignedPerson)
        {
            Priority=priority;
            AssignedPerson=assignedPerson;
        }
    }

    internal class TaskManager
    {
        [TaskInfo("High", "Kashvi")]
        public void ProcessTask()
        {
            Console.WriteLine("Task is Processed!");
        }
    }

}
