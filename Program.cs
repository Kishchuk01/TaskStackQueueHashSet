using System;
using System.Collections.Generic;

namespace TaskStackQueueHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack
            TaskStack<int> stack = new TaskStack<int>();
            stack.Push(7);
            stack.Push(2);
            stack.Push(3);
            stack.Push(8);
            Console.WriteLine(stack.Pop());

            //Queue
            TaskQueue<int> Queue = new TaskQueue<int>();
            Queue.Enqueue(2);
            Queue.Enqueue(7);
            Queue.Enqueue(6);
            Queue.Enqueue(7);
            Console.WriteLine(Queue.Dequeue());

            //Hashtable
            TaskHashSet<int, string> hashtable = new TaskHashSet<int, string>(12);
            hashtable.Add(2, "Test");
            hashtable.Add(2, "Exe");
        }
    }
}
