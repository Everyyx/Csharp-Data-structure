using System;
using Datastructure;

namespace BinaryTreeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree1 = new Tree<int>(10);
            tree1.Insert(5);
            tree1.Insert(3);
            tree1.Insert(1);
            tree1.Insert(-1);
            tree1.Insert(-2);

            tree1.Insert(-3);
            tree1.Insert(-4);
            tree1.Insert(-5);
            tree1.Insert(-6);
            tree1.Insert(-11);


            string sortedData = tree1.WalkTree();
            Console.WriteLine($"{sortedData}");
            Console.ReadKey();
        }
    }
}
