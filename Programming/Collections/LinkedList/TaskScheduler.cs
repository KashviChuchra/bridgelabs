using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class TaskNode
    {
        public int TaskId;
        public string TaskName;
        public int Priority;
        public DateTime DueDate;
        public TaskNode Next;

        public TaskNode(int taskId, string taskName, int priority, DateTime dueDate)
        {
            TaskId = taskId;
            TaskName = taskName;
            Priority = priority;
            DueDate = dueDate;
            Next = null;
        }
    }
    internal class TaskScheduler
    {
        TaskNode head;
        TaskNode current;
        public bool IsTaskIdUnique(int taskId)
        {
            if (head == null) return true;
            TaskNode temp = head;
            do
            {
                if (temp.TaskId == taskId)
                {
                    Console.WriteLine("Task ID already exist. Can't insert");
                    return false;
                }
                temp = temp.Next;
            }
            while (temp != head);
            return true;
        }
        public void InsertAtBeginning(int taskId, string taskName, int priority, DateTime dueDate)
        {
            if (IsTaskIdUnique(taskId))
            {
                TaskNode newNode = new TaskNode(taskId, taskName, priority, dueDate);
                if (head == null)
                {
                    head = newNode;
                    newNode.Next = head;
                    current = head;
                    return;
                }
                else
                {
                    TaskNode temp = head;
                    while (temp.Next != head)
                    {
                        temp= temp.Next;
                    }
                    newNode.Next = head;
                    temp.Next = newNode;
                    head = newNode;
                }
            }
        }

        public void InsertAtEnd(int taskId, string taskName, int priority, DateTime dueDate)
        {
            if (IsTaskIdUnique(taskId))
            {
                TaskNode newNode = new TaskNode(taskId, taskName, priority, dueDate);

                if (head == null)
                {
                    head = newNode;
                    newNode.Next = head;
                    current = head;

                    return;
                }
                TaskNode temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
                newNode.Next = head;
            }

        }

        public void InsertAtPosition(int position,int taskId, string taskName, int priority, DateTime dueDate)
        {

            int count = 0;
            if (head != null)
            {
                TaskNode temp = head;
                do
                {
                    count++;
                    temp = temp.Next;

                } while (temp != head);
            }
            if (position == 1) InsertAtBeginning(taskId, taskName, priority, dueDate);
            else if (position == count + 1) InsertAtEnd(taskId, taskName, priority, dueDate);
            else if (position > count || position <= 0) Console.WriteLine("Position Doesn't exist");
            else
            {
                TaskNode temp = head;

                if (IsTaskIdUnique(taskId))
                {
                    temp = head;
                    for (int i = 1; i < position - 1; i++)
                    {
                        temp = temp.Next;
                    }
                    TaskNode newNode = new TaskNode(taskId, taskName, priority, dueDate);
                    newNode.Next = temp.Next;
                    temp.Next = newNode;
                }
            }

        }
        public void RemoveTaskById(int taskId)
        {
            TaskNode temp = head;
            TaskNode prev = null;

            if (head == null) return;
            if(head.Next==head && head.TaskId == taskId)
            {
                head = null;
                current = null;
                return;
            }
            do
            {
                if (temp.TaskId == taskId) break;
                prev = temp;
                temp = temp.Next;
            }
            while (temp != head && temp.TaskId != taskId);
            if (temp == head)
            {
                Console.WriteLine("TaskID doesn't exist");
                return;
            }
            if (prev == null)
            {
                head = temp.Next;
                TaskNode last = head;

                while (last.Next != temp)
                {
                    last = last.Next;
                }

                last.Next = head;
            }
            else
            {
                prev.Next = temp.Next;
            }
            if (current == temp)
            {
                current = temp.Next;
            }

        }

        public void SearchTask(int taskId)
        {
            TaskNode temp = head;
            bool isFound = false;
            if (head == null)
            {
                Console.WriteLine("No tasks available");
                return;
            }
            do
            {
                if (temp.TaskId == taskId)
                {
                    Console.WriteLine(temp.TaskId + " " + temp.TaskName + " " + temp.Priority + " " + temp.DueDate);
                    isFound = true;
                }
                temp = temp.Next;

            }
            while (temp != head);
            if(!isFound)    Console.WriteLine("TaskId doesn't exist");
        }
        public void ViewCurrentTask()
        {
            if (current == null)
            {
                Console.WriteLine("No current task");
                return;
            }

            Console.WriteLine("Current Task:");
            Console.WriteLine(current.TaskId + " " +current.TaskName + " " +current.Priority + " " +current.DueDate);
        }

        // Move current to the next task
        public void MoveToNextTask()
        {
            if (current == null)
            {
                Console.WriteLine("No tasks available");
                return;
            }

            current = current.Next;

            Console.WriteLine("Moved to next task.");
        }
        public void Display()
        {
            TaskNode temp = head;
            Console.WriteLine("=========================");
            if (temp == null) return;
            do
            {
                Console.WriteLine(temp.TaskId + " " + temp.TaskName + " " + temp.Priority + " " + temp.DueDate);
                temp = temp.Next;
            }
            while (temp != head);
        }

    }
}
