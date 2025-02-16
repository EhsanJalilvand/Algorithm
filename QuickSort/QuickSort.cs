using System;
namespace QuickSort
{
	public static class SortStrategyQuick
	{
		public static int[] QuickSort(this int[] array)
		{
            return SortArray(array, 0, array.Length - 1);
		}
        static int[]  SortArray(int[] array, int leftindex, int rightIndex)
        {
            int i = leftindex;
            int j = rightIndex;
            int pivot = array[leftindex];
            while (i <= j)
            {
                while (array[i] < pivot)
                    i++;
                while (array[j] > pivot)
                    j--;
                if (i <= j)
                {
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }
            if (leftindex < j)
                SortArray(array, leftindex, j);
            if (i < rightIndex)
                SortArray(array, i, rightIndex);

            return array;

        }
    }
}

