using System;
namespace QuickSort
{
	public static class SortStrategyQuick
	{
		public static int[] QuickSort(this int[] array)
		{
            return Sort(array, 0, array.Length - 1);
		}
        public static int[] Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // پیدا کردن اندیس pivot
                int pivotIndex = Partition(arr, low, high);

                // مرتب‌سازی بازه‌های چپ و راست pivot
                Sort(arr, low, pivotIndex - 1);  // بازه چپ
                Sort(arr, pivotIndex + 1, high); // بازه راست
            }
            return arr;
        }

        // تابع Partition برای تقسیم آرایه بر اساس pivot
        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[low]; // انتخاب اولین عنصر به عنوان pivot
            int i = low + 1;      // شروع از عنصر بعدی pivot
            int j = high;

            while (i <= j)
            {
                // پیدا کردن عنصری بزرگتر از pivot
                while (i <= j && arr[i] <= pivot)
                    i++;

                // پیدا کردن عنصری کوچکتر از pivot
                while (i <= j && arr[j] > pivot)
                    j--;

                // اگر i و j هم‌پوشانی نداشته باشند، عناصر را جابجا می‌کنیم
                if (i < j)
                {
                    Swap(arr, i, j);
                }
            }

            // جابجایی pivot به موقعیت صحیح
            Swap(arr, low, j);
            return j; // بازگشت اندیس pivot
        }

        // تابع کمکی برای جابجایی دو عنصر
        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}

