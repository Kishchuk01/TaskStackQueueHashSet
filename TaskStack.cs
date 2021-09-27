using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskStackQueueHashSet
{
    class TaskStack<T>
    {
        private T[] taskStack;
        public int Count { get; private set; } = -1;
        public int Length { 
            get 
            {
                return taskStack.Length;
            } 
        }

        public TaskStack()
        {
            taskStack = new T[4];
        }

        public TaskStack(int Count)
        {
            taskStack = new T[Count];
        }
        
        public void Push(T item)
        {
            if (Count + 1 == Length)
            {
                Array.Resize<T>(ref taskStack, Length * 2);
            }
            taskStack[++Count] = item;
        }
        
        public T Pop()
        {
            if (Count <= 0)
            {
                throw new InvalidOperationException();
            }
            var value = taskStack[Count];
            taskStack[Count] = default;
            --Count;
            return value;
        }

        public T Peek() 
        {
            if (Count < 0) 
            {
                throw new InvalidOperationException();
            }
            return taskStack[Count];
        }
    }
}
