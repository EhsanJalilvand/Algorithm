using System;
namespace QuickSort
{
	public static class SortStrategyBubble
	{
		public static int[] BubbleSort(this int[] array)
		{
            return SortArray(array);
		}
        static int[]  SortArray(int[] array)
        {
            var n = array.Length - 1;
            for (int i = n; i >0; i--)
            {
                for (int j = 0; j <i ; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
    }
}

