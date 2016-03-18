using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public Node<T> RootNode;
        public int FindDivisions = 0;
        public int Count { get; private set; }

        public void Insert(T data)
        {
            RootNode = InsertWithNode(RootNode, data);
        }

        private Node<T> InsertWithNode(Node<T> node, T data)
        {
            if (node == null)
            {
                node = new Node<T>()
                {
                    Payload = data
                };
                Count++;
                return node;
            }
            var currentData = node.Payload;
            if (data.CompareTo(currentData) < 0)
            {
                node.LeftNode = InsertWithNode(node.LeftNode, data);
            }
            else
            {
                node.RightNode = InsertWithNode(node.RightNode, data);
            }

            return node;
        }

        public Node<T> Find(T data)
        {
            FindDivisions = 0;
            return FindWithNode(RootNode, data);
        }

        private Node<T> FindWithNode(Node<T> node, T data)
        {
            FindDivisions++;
            if (node == null)
            {
                return null;
            }

            if (data.CompareTo(node.Payload) < 0)
            {
                return FindWithNode(node.LeftNode, data);
            }

            if (data.CompareTo(node.Payload) > 0)
            {
                return FindWithNode(node.RightNode, data);
            }
            return node;
        }

        public IEnumerable<Node<T>> TraverseInOrder()
        {
            List<Node<T>> orderedNodes = new List<Node<T>>();
            TraverseWithNode(RootNode, orderedNodes);
            return orderedNodes;
        }

        private void TraverseWithNode(Node<T> node, List<Node<T>> nodes)
        {
            if (node.LeftNode != null)
            {
                TraverseWithNode(node.LeftNode, nodes);
            }
            nodes.Add(node);
            if (node.RightNode != null)
            {
                TraverseWithNode(node.RightNode, nodes);
            }
        }
    }
}