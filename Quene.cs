using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  app1
{
    public class Queue
    {
        private const int DEFAULTQUEUESIZE100=5;
        public int[] data;
        private int head=0,tail=0;
        private int numElements=0;

        public Queue()
        {
            this.data= new int[DEFAULTQUEUESIZE100];
        }
        public Queue(int size)
        {
            if (size>0)
            {
                this.data=new int[size];
            }
            else
            {
                throw new ArgumentOutOfRangeException("size","must be greater than zero");
            }
        }

        public void Enqueue(int item)
        {
            if (this.numElements==this.data.Length)
            {
                throw new Exception("queue full");
            }
            else
            {
                this.data[this.head]=item;
                this.head++;
                this.head%=this.data.Length;
                this.numElements++;
            }
        }

        public int  Dequeue()
        {
            if(this.numElements==0)
            {
                throw new Exception ("queue Empty");
            }
            else
            {
                int  queueItem=this.data[this.tail];
                this.tail++;
                this.tail%=this.data.Length;
                this.numElements--;
                return queueItem;
            }
        }
    }
}