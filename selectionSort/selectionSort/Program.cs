using System;

namespace selectionSort
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var items = new int[10];
            var r = new Random();

            for (var i = 0; i < items.Length; i++)
                items[i] = r.Next(10);

            var s = new SelectionSort(items);

            Console.WriteLine("before");
            s.Print(items);

            Console.WriteLine("after");
            s.Sort();
            s.Print(null);

            Console.ReadLine();
        }
    }
}