using System;
namespace QuickSort
{
	public static class Heap
    {
		public static int[] HeapSort(this int[] array)
		{
            return SortArray(array);
		}
        static int[]  SortArray(int[] array)
        {
            int[] t = new int[array.Length+1];
            for (int i = 0; i < array.Length; i++)
            {
                Add_Max_Heap(t, array[i]);
            }
            for (int i = array.Length-1; i >=0; i--)
            {
               array[i]= Delete_Max_Heap(t);
            }

            return array;
        }
        static void Add_Max_Heap(int[] array,int x)
        {
            array[0] = array[0] + 1;
            int num = array[0];
            array[num] = x;
            int j = num;
            int i = num / 2;
            while(i>0 && array[j] > array[i])
            {
                var temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                j = i;
                i = j / 2;
            }
        }
        static int Delete_Max_Heap(int[] array)
        {
            int x = array[1];
            array[0] = array[0] - 1;
            int num = array[0];
            array[1] = array[num];
            int i = 1;
            int j=0;
            while (true)
            {
                if (array.Length<2*i  || array.Length < 2 * i+1)
                    break;

                    if (array[2 * i + 1] > array[2 * i])
                    j = 2 * i + 1;
                else
                    j = 2 * i;



                if (array[i] > array[j])
                    break;
                var temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i = j;
            }
            if (array.Length-1==2*i && array[i] < array[2*i])
            {
                var temp = array[i];
                array[i] = array[2*i];
                array[i] = temp;
            }
            return x;
        }
    }
  
}

