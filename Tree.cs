using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructure
{
    public class Tree<TItem>where TItem:IComparable<TItem>//指定类型参数必须是实现了该泛型接口的类型
    {
        public Tree(TItem nodeValue)//构造器的名称不能包含类型参数
        {
            this.NodeData = nodeValue;
            this.LeftTree = null;
            this.RightTree = null;
        }

        public void Insert(TItem newItem)//递归
        {
            TItem currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(newItem)>0)
            {
                //插入左子树
                if (this.LeftTree==null)
                {
                    this.LeftTree = new Tree<TItem>(newItem);
                }
                else
                {
                    this.LeftTree.Insert(newItem);
                }
            }
            else
            {
                //插入右子树
                if (this.RightTree==null)
                {
                    this.RightTree = new Tree<TItem>(newItem);              
                }
                else
                {
                    this.RightTree.Insert(newItem);
                }
            }
        }
        public string WalkTree()
        {
            string result = "";
            if (this.LeftTree!=null)
            {
                result = this.LeftTree.WalkTree();
            }
            result += $"{this.NodeData.ToString()}";
            if (this.RightTree!=null)
            {
                result += this.RightTree.WalkTree();
            }
            return result;
        }
        public TItem NodeData { get; set; }
        public Tree<TItem> LeftTree { get; set; }
        public Tree<TItem> RightTree { get; set; }
    }
    
}
