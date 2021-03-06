﻿using System.Collections;
using System.Collections.Generic;

namespace ArtificialIntelligence
{
    public class PriorityQueue<T> : IEnumerable
    {
        private List<T> items;
        private List<float> priorities;

        public PriorityQueue()
        {
            items = new List<T>();
            priorities = new List<float>();
        }

        public IEnumerator GetEnumerator() { return items.GetEnumerator(); }
        public int Count { get { return items.Count; } }

        /// <returns>Index of new element</returns>
        public int Enqueue(T item, float priority)
        {
            for (int i = 0; i < priorities.Count; i++)
            {
                if (priorities[i] > priority)
                {
                    items.Insert(i, item);
                    priorities.Insert(i, (int)priority);

                    return i;
                }
            }

            items.Add(item);
            priorities.Add(priority);

            return items.Count - 1;
        }

        public T Dequeue()
        {
            T item = items[0];
            priorities.RemoveAt(0);
            items.RemoveAt(0);

            return item;
        }

        public T Peek()
        {
            return items[0];
        }

        public T Peek2()
        {
            return items[1];
        }

        public float PeekPriority()
        {
            return priorities[0];
        }
    }
}