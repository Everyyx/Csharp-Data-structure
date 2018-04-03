using System;
using Datastructure;

namespace BuildTree
{
    class Program
    {

        static void Main(string[] args)
        {
            Tree<char> tree = null;
            InsertIntoTree<char>(ref tree, 'm', 'n', 's', 'd', 'a', 'g', 'g');
            Console.WriteLine($"sorted data is {tree.WalkTree()}");
            Console.ReadKey();
        }

        static void InsertIntoTree<TItem>(ref Tree<TItem> tree,params TItem[]data) where TItem:IComparable<TItem>
        {
            foreach (var datum in data)
            {
                if (tree==null)
                {
                    tree = new Tree<TItem>(datum);  
                }
                else
                {
                    tree.Insert(datum);
                }
            }
        }
    }
}
