using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskStackQueueHashSet
{
    class TaskHashSet<Tkey, TValue>
    {
        private List<TValue>[] Hashtable;

        public TaskHashSet(int Size)
        {
            Hashtable = new List<TValue>[Size];
        }

        public void Add(Tkey key, TValue value) 
        {
            var k = GetHash(key);
            if (Hashtable[k] == null)
            {
                Hashtable[k] = new List<TValue>() { value };
            }
            else { 
                Hashtable[k].Add(value);
            }
        }

        public bool Search(Tkey key, TValue value)
        {
            var k = GetHash(key);
            return Hashtable[k].Contains(value);
        }

        public int GetHash(Tkey key)
        {
            return Convert.ToInt32(key.ToString().Substring(0, 1));
        }
        
    }
}
