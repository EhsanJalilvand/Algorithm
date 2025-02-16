using System;
namespace QuickSort
{
    public class Tree
    {
        private List<int> list = new List<int>();
        private int index = 1;
        public void Insert(int value)
        {
            while (true)
            {
                if (index > list.Count)
                    Resize(index);
                if (list[index] == -1)
                {
                    list[index] = value;
                    break;
                }
                else if (value < list[index])
                    index = index * 2;
                else if (value > list[index])
                    index = (index * 2) + 1;
                else
                    break;

            }
            void Resize(int i)
            {
                while (list.Count < i+1)
                {
                    list.Add(-1);
                }
            }
        }
    }
}

