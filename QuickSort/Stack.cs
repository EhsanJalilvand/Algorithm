using System;
namespace QuickSort
{
	public  class Stack
	{
		private int[] _array;
		private int top = -1;
		public Stack(int capacity)
		{
			_array = new int[capacity];
		}
		public void Add(int value)
		{
			if(top==_array.Length-1)
			{
				Console.WriteLine("Stack Is Full");
				return;
			}
			top++;
			_array[top] = value;
		}
		public int Remove()
		{
			if(top==-1)
			{
				Console.WriteLine("Stack Is Empty");
				return -1;
			}
			var x= _array[top];
            top--;
			return x;
        }
	}
}

