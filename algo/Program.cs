using AlgoLibrary.QuickFindUF;
using System;

namespace algo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            QuickFindUF quickFindUF = new QuickFindUF(10);
            quickFindUF.Union(1, 2);
            quickFindUF.Union(3, 4);
            quickFindUF.Union(4, 6);
            quickFindUF.Union(6, 5);
            quickFindUF.AreConnected(3, 6);
            //BinaryTree binaryTree = new BinaryTree();

            //binaryTree.Add(4);
            //binaryTree.Add(2);
            //binaryTree.Add(7);
            //binaryTree.Add(3);
            //binaryTree.Add(10);
            //binaryTree.Add(5);
            //binaryTree.Add(8);

            //Node node = binaryTree.Find(5);
            //int depth = binaryTree.GetTreeDepth();

            //Console.WriteLine("PreOrder Traversal:");
            //binaryTree.TraversePreOrder(binaryTree.Root);
            //Console.WriteLine();

            //Console.WriteLine("InOrder Traversal:");
            //binaryTree.TraverseInOrder(binaryTree.Root);
            //Console.WriteLine();

            //Console.WriteLine("PostOrder Traversal:");
            //binaryTree.TraversePostOrder(binaryTree.Root);
            //Console.WriteLine();

            //binaryTree.Remove(7);
            //binaryTree.Remove(8);

            //Console.WriteLine("PreOrder Traversal After Removing Operation:");
            //binaryTree.TraversePreOrder(binaryTree.Root);
            //Console.WriteLine();

            Console.ReadLine();
        }
    }
}