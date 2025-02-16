using System;
namespace QuickSort
{
	public static class SearchStrategyBinary
	{
		public static int BinarySearch(this int[] array,int x)
		{
            array=array.MergerSort();
            return Search(array, 0, array.Length - 1, x);
        }
        private static int Search(int[] array,int low,int high,int x)
        {
            if(low<=high)
            {
                var mid = (low + high) / 2;
                if (array[mid] == x)
                    return mid;
                if (x < array[mid])
                    return Search(array, low, mid - 1,x);
                else 
                    return Search(array, mid+1,high, x);
            }
            return -1;
        }
    }
}

