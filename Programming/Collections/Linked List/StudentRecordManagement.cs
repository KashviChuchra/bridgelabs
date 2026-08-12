using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class StudentNode
    {
        public int RollNumber;
        public string Name;
        public int Age;
        public char Grade;
        public StudentNode Next;

        public StudentNode(int rollNumber, string name, int age, char grade)
        {
            RollNumber = rollNumber;
            Name = name;
            Age = age;
            Grade = grade;
        }
    }
    internal class StudentRecordManagement
    {
        StudentNode head;

        public bool IsRollNoUnique(int rollNo)
        {
            StudentNode temp = head;
            while (temp != null)
            {
                if(temp.RollNumber== rollNo)
                {
                    Console.WriteLine("Roll No already exist. Can't insert");
                    return false;
                }
                temp=temp.Next;
            }
            return true;
        }
        public void InsertAtBeginning(int rollNumber, string name, int age, char grade)
        {
            if (IsRollNoUnique(rollNumber))
            {
                StudentNode newNode = new StudentNode(rollNumber, name, age, grade);
                if (head == null) head = newNode;
                else
                {
                    newNode.Next = head;
                    head = newNode;
                }
            }
        }

        public void InsertAtEnd(int rollNumber, string name, int age, char grade)
        {
            if (IsRollNoUnique(rollNumber))
            {
                StudentNode newNode = new StudentNode(rollNumber, name, age, grade);

                if (head == null)
                {
                    head = newNode;
                    return;
                }
                StudentNode temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
                newNode.Next = null;
            }

        }

        public void InsertAtPosition(int position,int rollNumber, string name, int age, char grade)
        {
            
            int count = 0;
            StudentNode temp = head;

            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            if (position == 1) InsertAtBeginning(rollNumber, name, age, grade);
            else if (position == count + 1) InsertAtEnd(rollNumber, name, age, grade);
            else if (position > count || position<=0) Console.WriteLine("Position Doesn't exist");
            else
            {
                if (IsRollNoUnique(rollNumber))
                {
                    temp = head;
                    for (int i = 1; i < position - 1; i++)
                    {
                        temp = temp.Next;
                    }
                    StudentNode newNode = new StudentNode(rollNumber, name, age, grade);
                    newNode.Next = temp.Next;
                    temp.Next = newNode;
                }
            }

        }

        public void UpdateStudentGrade(int rollNumber, char newGrade)
        {
            StudentNode temp = head;
            while (temp != null)
            {
                if (temp.RollNumber == rollNumber)
                {
                    temp.Grade = newGrade;
                    return;
                }
                temp= temp.Next;
            }
        }
        public void SearchStudent(int rollNumber)
        {
            StudentNode temp = head;
            while (temp != null)
            {
                if(temp.RollNumber == rollNumber)
                {
                    Console.WriteLine(temp.Name + " " + temp.RollNumber + " " + temp.Grade + " " + temp.Age);
                    return;
                }
                temp= temp.Next;
            }
            Console.WriteLine("Student Roll Number doesn't exist");
        }
        public void DeleteNode(int rollnumber)
        {
            StudentNode temp = head;
            StudentNode prev = null;
            while (temp!=null && temp.RollNumber != rollnumber)
            {
                prev = temp;
                temp = temp.Next;
            }
            if (temp == null)
            {
                Console.WriteLine("Student Roll Number doesn't exist");
                return;
            }
            if (prev == null)
            {
                head = temp.Next;
            }
            else
            {
                prev.Next = temp.Next;
            }

        }
        public void Display()
        {
            StudentNode temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.RollNumber+" "+temp.Name+" "+temp.Age+" "+temp.Grade);
                temp = temp.Next;
            }
        }
    }
}

//Problem Statement: Create a program to manage student records using a singly linked list. Each node will store information about a student, including their Roll Number, Name, Age, and Grade. Implement the following operations:
//Add a new student record at the beginning, end, or at a specific position.
//Delete a student record by Roll Number.
//Search for a student record by Roll Number.
//Display all student records.
//Update a student's grade based on their Roll Number.
