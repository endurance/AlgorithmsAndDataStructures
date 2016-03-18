using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;
using Sorting;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTreeTester();
        }

        private static void BinaryTreeTester()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            var list = RandomNumberListGenerator.GenerateRandomNumbers(10000000, i =>
            {
                tree.Insert(i);
            }).ToList();
            
            //Console.WriteLine(tree.Find(list[90]));
            var thing = tree.TraverseInOrder();
        }

        private static void bubbleSortTester()
        {
            BubbleSort sorter = new BubbleSort();
            var list = RandomNumberListGenerator.GenerateRandomNumbers(10000000, null).ToList();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var newList = sorter.Sort(list);
            watch.Stop();

            Console.WriteLine("Seconds: " + watch.Elapsed.TotalSeconds);
            Console.ReadKey();
        }
    }
}
