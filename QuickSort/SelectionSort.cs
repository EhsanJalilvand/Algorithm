using System;
namespace QuickSort
{
	public static class SortStrategySelection
    {
		public static int[] SelectionSort(this int[] array)
		{
            return SortArray(array);
		}
        static int[]  SortArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var min = array[i];
                int k = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if(array[j]< min)
                    {
                        k = j;
                        min = array[j];
                    }
                }
                array[k] = array[i];
                array[i] =min ;

            }
            return array;
        }
    }
}

