using selectionSort;
using System;

namespace sorting
{
    internal class Program
    {
        public void Print(int[] itemsToPrint)
        {
            foreach (var item in itemsToPrint)
                Console.WriteLine(item.ToString());
        }

        private static void Main(string[] args)
        {
            var selectionSortItems = new int[5];
            var insertionSortItems = new int[5];
            var r = new Random();

            for (var i = 0; i < selectionSortItems.Length; i++)
            {
                selectionSortItems[i] = r.Next(10);
                insertionSortItems[i] = r.Next(10);
            }

            var selectionSort = new SelectionSort(selectionSortItems);

            Console.WriteLine("before sorting");
            selectionSort.Print(selectionSortItems);
            Console.WriteLine("--------");
            selectionSort.Print(insertionSortItems);

            Console.WriteLine("after selection sort");
            selectionSort.Sort();
            selectionSort.Print(null);

            Console.WriteLine("after isertion sort");
            InsertionSort insertionSort = new InsertionSort(insertionSortItems);
            insertionSort.Sort();
            insertionSort.Print();

            Console.ReadLine();
        }
    }
}