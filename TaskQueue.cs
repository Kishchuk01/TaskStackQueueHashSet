using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskStackQueueHashSet
{
    class TaskQueue<T>
    {
        private T[] taskQueue;
        public int Count { get; private set; } = -1;
        public int Length {
            get 
            {
                return taskQueue.Length;
            }
        }
        
        public TaskQueue()
        {
            taskQueue = new T[4];
        }

        public TaskQueue(int Count)
        {
            taskQueue = new T[Count];
        }
        
        public void Enqueue(T item)
        {
            if (Count + 1 == Length)
            {
                Array.Resize(ref taskQueue, Count * 2);
            }
            taskQueue[++Count] = item;
        }

        public T Dequeue()
        {
            if (Count - 1 <= 0)
            {
                throw new InvalidCastException();
            }
            var value = taskQueue[0];
            for (int i = 0; i < Length-1; i++)
            {
                taskQueue[i] = taskQueue[i + 1];
            }
            taskQueue[Count] = default;
            --Count;
            return value;
        }

        public T Peek() 
        {
            return taskQueue[0];
        }
        
    }
}
