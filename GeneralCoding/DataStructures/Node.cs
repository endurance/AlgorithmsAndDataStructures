using System;

namespace DataStructures
{
    public class Node<T> where T : IComparable<T>
    {
        public Node<T> LeftNode;
        public T Payload;
        public Node<T> RightNode;
    }
}