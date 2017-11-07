using System;

namespace selectionSort
{
    public class SelectionSort
    {
        private readonly int[] items;

        public SelectionSort(int[] itemsIn)
        {
            items = itemsIn;
        }

        public void Print(int[] itemsToPrint)
        {
            if (itemsToPrint == null)
                foreach (var item in items)
                    Console.WriteLine(item.ToString());
            else
                foreach (var item in itemsToPrint)
                    Console.WriteLine(item.ToString());
        }

        public void Sort()
        {
            for (var i = 0; i < items.Length; i++)
            {
                for (var j = i + 1; j < items.Length; j++)
                {
                    if (items[i] < items[j]) continue;
                    var temp = items[i];
                    items[i] = items[j];
                    items[j] = temp;
                }
            }
        }
    }
}