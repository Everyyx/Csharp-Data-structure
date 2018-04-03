using System;
using System.Collections.Generic;
using System.Text;

namespace app1
{
     class Tqueue<T>
     {
        private const int DEFAULTQUEUESIZE = 100;
        private T[] data;
        private int head = 0, tail = 0;
        private int numElements = 0;

        public Tqueue()
        {
            this.data = new T[DEFAULTQUEUESIZE];
        }
        public Tqueue(int size)
        {
            if (size > 0)
            {
                this.data = new T[size];
            }
            else
            {
                throw new ArgumentOutOfRangeException("size", "must be greater than zero");
            }
        }
        public void Enqueue(T item)
        {
            if (this.numElements == this.data.Length)
            {
                throw new Exception("queue full");
            }
            else
            {
                this.data[this.head] = item;
                this.head++;
                this.head %= this.data.Length;
                this.numElements++;
            }
        }

        public T Dequeue()
        {
            if (this.numElements == 0)
            {
                throw new Exception("queue Empty");
            }
            else
            {
                T queueItem = this.data[this.tail];
                this.tail++;
                this.tail %= this.data.Length;
                this.numElements--;
                return queueItem;
            }
        }
    }
    
}
