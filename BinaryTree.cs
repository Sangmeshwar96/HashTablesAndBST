using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinaryTree<T> where T : IComparable
    {
        public T nodeData { get; set; }
        public BinaryTree<T> leftTree { get; set; }
        public BinaryTree<T> rightTree { get; set; }
        public static int leftCount;
        public static int rightCount;
  
   
        public BinaryTree(T nodeData)
        {
            this.nodeData = nodeData;
            this.leftTree = null;
            this.rightTree = null;
        }

        public void Insert(T item)
        {
            T parentValue = this.nodeData;
            int value = parentValue.CompareTo(item);

            if ((parentValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new BinaryTree<T>(item);
                    Console.WriteLine("Inserting : " + item);
                }
                else
                    this.leftTree.Insert(item);
            }

            else
            {
           
                if (this.rightTree == null)
                {
                    this.rightTree = new BinaryTree<T>(item);
                    Console.WriteLine("Inserting : " + item);
                }
                else
                {
                    this.rightTree.Insert(item);
                }

            }
        }

        public void Display()
        {
            if (this.leftTree != null)
            {
                leftCount++;
            
                this.leftTree.Display();
            }
            Console.WriteLine(this.nodeData.ToString());
            if (this.rightTree != null)
            {
                rightCount++;
                this.rightTree.Display();
            }

        }

        public void GetSize()
        {
            Console.WriteLine("Size Of BST :" + " " + (1 + leftCount + rightCount));
        }
        public void Search(T item)
        {
            T parentValue = this.nodeData;
            int value = parentValue.CompareTo(item);
            
            if (value > 0)
            {
                if (this.leftTree.nodeData.Equals(item))
                    Console.WriteLine("Found value");
                else
                    this.leftTree.Search(item);
            }
            else
            {

                if (this.rightTree.nodeData.Equals(item))
                    Console.WriteLine("Found value");
                else
                    this.rightTree.Search(item);
            }
        }
    }
}