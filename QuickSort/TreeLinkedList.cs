using System;
namespace QuickSort
{
    public class TreeLinkedList
    {
        private int index = 1;
        Node head = null;
        public void Insert(int value)
        {
            if (head == null)
            {
                head = new Node(value);
                return;
            }
            var pointer = head;
            while (true)
            {
                if (value < pointer.Value)
                {
                    if (pointer.Left == null)
                    {
                        pointer.Left = new Node(value);
                        break;
                    }
                    else
                        pointer = pointer.Left;
                }
                else if (value > pointer.Value)
                {
                    if (pointer.Right == null)
                    {
                        pointer.Right = new Node(value);
                        break;
                    }
                    else
                        pointer = pointer.Right;
                }
                else
                    break;
            }
        }
    }
    class Node
    {
        public Node(int value)
        {
            Value = value;
        }
        public int Value { get; init; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}

