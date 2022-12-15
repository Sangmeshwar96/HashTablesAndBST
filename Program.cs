using System;

namespace BinarySearchTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---Welcome To Binary Search Tree Program---");
            Console.WriteLine(" ");
            
            BinaryTree<int> binaryTree = new BinaryTree<int>(56);

           
            binaryTree.Insert(30);
            binaryTree.Insert(70);
            binaryTree.Insert(22);
            binaryTree.Insert(40);
            binaryTree.Insert(11);
            binaryTree.Insert(18);
            binaryTree.Insert(3);
            binaryTree.Insert(60);
            binaryTree.Insert(95);
            binaryTree.Insert(65);
            binaryTree.Insert(63);
            binaryTree.Insert(67);
         
            binaryTree.Display();
            binaryTree.GetSize();
            binaryTree.Search(63);
        }
    }
    
}