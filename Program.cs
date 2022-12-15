using HashTable;
using System;

namespace HashTables
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HashTable and Binary search Tree programs");
            Console.WriteLine(" ");

            MyMapNode<int, string> myMapNode = new MyMapNode<int, string>(5);
            myMapNode.Add(1, "to");
            myMapNode.Add(2, "be");
            myMapNode.Add(3, "or");
            myMapNode.Add(4, "not");
            myMapNode.Add(5, "to");
            myMapNode.Add(6, "be");
            myMapNode.Frequency("to");
        }
    }
}