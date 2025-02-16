using System;
namespace QuickSort
{
	public static class SortStrategyInsertion
    {
		public static int[] InsertionSort(this int[] array)
		{
            return SortArray(array);
		}
        static int[]  SortArray(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                var val = array[i];
                int j = i - 1;
                while (j>=0 && array[j] > val )
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = val;

            }
            return array;
        }
    }
}

