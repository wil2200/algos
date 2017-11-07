using System;

namespace sorting
{
    public class InsertionSort
    {
        private readonly int[] items;

        public InsertionSort(int[] items)
        {
            this.items = items;
        }

        public void Print()
        {
            foreach (var f in items)
            {
                Console.WriteLine(f.ToString());
            }
        }

        public void Sort()
        {
            for (int i = 1; i < items.Length; i++)
            {
                for (int j = i - 1; j > 0; j--)
                {
                    if (items[i] < items[j])
                    {
                        int temp = items[j];
                        items[j] = items[i];
                        items[i] = temp;
                    }
                }
            }
        }
    }
}