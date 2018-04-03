using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace app1
{
    class Program
    {      
        static void Main(string[] args)
        {
            Queue myqueue=new Queue();
            myqueue.Enqueue(1);
            myqueue.Enqueue(2);
            myqueue.Enqueue(3);
            myqueue.Enqueue(4);
            myqueue.Enqueue(5);
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{myqueue.data[i]}");
            }
            //Console.ReadKey();
            //myqueue.Enqueue(6);
            Console.WriteLine();
            Console.WriteLine($"{myqueue.Dequeue()}");
            Console.WriteLine($"{myqueue.Dequeue()}");
            Console.WriteLine($"{myqueue.Dequeue()}");
            Console.WriteLine($"{myqueue.Dequeue()}");
            Console.WriteLine($"{myqueue.Dequeue()}");
            //Console.WriteLine($"{myqueue.Dequeue()}");


        }
    }
}
