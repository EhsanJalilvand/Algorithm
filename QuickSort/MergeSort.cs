using System;
namespace QuickSort
{
    public static class SortStrategyMerge
    {
        public static int[] MergerSort(this int[] array)
        {
             SortArray(array,0,array.Length-1);
            return array;
        }
        static void SortArray(int[] array, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                SortArray(array, low, mid);
                SortArray(array, mid + 1, high);
                Merge(array, low, mid, high);
            }
        }
        static void Merge(int[] array, int low, int mid, int high)
        {
            int i, j, k;
            i = low;
            j = mid + 1;//اول عنصر ارایه دوم
            int[] b = new int[high - low + 1];
            k = 0;
            while(i<=mid && j<=high)
            {
                if (array[i] <= array[j])
                {
                    b[k] = array[i];
                    i++;
                    k++;
                }
                else
                {
                    b[k] = array[j];
                    j++;
                    k++;
                }
            }
            if(i>mid)
            {
                for (;j<= high; j++)
                {
                    b[k] = array[j];
                    k++;
                }
            }
            if (j > high)
            {
                for (; i <= mid; i++)
                {
                    b[k] = array[i];
                    k++;
                }
            }


            for (int z = low,l=0; z <= high; z++,l++)
            {
                array[z] = b[l];
            }

        }
    }
}

