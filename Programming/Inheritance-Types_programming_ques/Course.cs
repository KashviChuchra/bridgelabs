using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Course
    {
        public string CourseName { get; set; }
        public int Duration { get; set; }
        
        public Course()
        {
            CourseName = string.Empty;
            Duration = 0;
        }
        public Course(string courseName, int duration)
        {
            CourseName = courseName;
            this.Duration = duration;
        }
        public void DisplayCourse()
        {
            Console.WriteLine($"Course Name: { CourseName}");
            Console.WriteLine($"Duration: {Duration}");
        }

    }
    internal class OnlineCourse: Course
    {
        public string Platform { get; set; }
        public bool IsRecorded { get; set; }

        public OnlineCourse()
        {
            Platform = string.Empty;
            IsRecorded = false;
        }
        public OnlineCourse(string courseName, int duration, string platform, bool isRecorded) : base(courseName, duration)
        {
            Platform = platform;
            IsRecorded = isRecorded;
        }
        public void DisplayOnlineCourse()
        {
            base.DisplayCourse();
            Console.WriteLine($"Platform Name: {Platform}");
            if( IsRecorded)
            {
                Console.WriteLine("Course is Recorded");
            }
            else
            {
                Console.WriteLine("Course is not Recorded");

            }
        }
    }
    internal class PaidOnlineCourse: OnlineCourse
    {
        public double Fee { get; set; }
        public double Discount { get; set; }

        public PaidOnlineCourse()
        {
            Fee = 0;
            Discount = 0;
        }
        public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount) : base(courseName, duration, platform, isRecorded)
        {
            Fee = fee;
            Discount = discount;
        }
        public void DisplayPaidOnlineCourse()
        {
            base.DisplayOnlineCourse();
            Console.WriteLine($"Fee: {Fee}");
            Console.WriteLine($"Discount: {Discount}");
            Console.WriteLine($"Total Fee: {Fee-Fee*Discount/100}");
        }

    }
}
