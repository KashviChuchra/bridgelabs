using System;
using System.Collections.Generic;
using System.Text;

namespace class_objects2
{
    internal class OnlineCourse
    {
        public string CourseName {  get; set; }
        public int Duration { get; set; }
        public long Fee { get; set; }

        public static string InstituteName { get; set; }

        public void DisplayCourseDetails()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine($"Course Name: {CourseName} Duration:{Duration} Fee:{Fee}");
            Console.WriteLine($"Institute Name:{InstituteName}");
        }

        public void updateInstituteName(string name)
        {
            InstituteName = name;
        }


    }
}
