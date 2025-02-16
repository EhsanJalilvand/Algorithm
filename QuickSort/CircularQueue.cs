using System;
namespace QuickSort
{
	public  class CircularQueue
	{
		private int[] _array;
		private int rear, front = -1;
		public CircularQueue(int capacity)
		{
			_array = new int[capacity];
		}
		public void Add(int value)
		{
			rear = (rear + 1) % _array.Length;
			if(rear==front)
			{
				Console.WriteLine("Queue Is Full");
				rear--;
				return;
			}
			_array[rear] = value;
		}
		public int Remove()
		{
			if(rear==front)
			{
				Console.WriteLine("Queue Is Empty");
				return -1;
			}
			front = (front + 1) % _array.Length;
			return _array[front];
		}
	}
}

