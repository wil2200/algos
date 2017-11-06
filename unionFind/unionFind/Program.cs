using System;
using System.Diagnostics;

namespace unionFind
{
    internal class Program
    {
        private static int n = 40;

        private static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            Stopwatch sw2 = new Stopwatch();
            sw.Start();
            RunUnion1();
            sw.Stop();

            sw2.Start();
            RunUnion2();
            sw2.Stop();

            Console.WriteLine($"Union1 took {sw.ElapsedMilliseconds}");
            Console.WriteLine($"Union2 took {sw2.ElapsedMilliseconds}");

            Console.ReadLine();
        }

        public static void RunUnion1()
        {
            var uf = new UnionFind(n);

            uf.GenerateRandomPair(n);
            uf.PrintPairs();

            foreach (var pair in uf.Pairs)
            {
                if (uf.IsConnected(pair.Item1, pair.Item2))
                {
                    Console.WriteLine($"Already connected {pair.Item1}, {pair.Item2}");
                    continue;
                }

                Console.WriteLine($"Unioning pair ({pair.Item1},{pair.Item2})");
                uf.Union(pair.Item1, pair.Item2);
                Console.WriteLine($"Now have {uf.ComponentCount()} components");

                uf.PrintSiteInfo();
            }
        }

        public static void RunUnion2()
        {
            var uf = new UnionFind(n);

            uf.GenerateRandomPair(n);
            uf.PrintPairs();

            foreach (var pair in uf.Pairs)
            {
                if (uf.IsConnected(pair.Item1, pair.Item2))
                {
                    Console.WriteLine($"Already connected {pair.Item1}, {pair.Item2}");
                    continue;
                }

                Console.WriteLine($"Unioning pair ({pair.Item1},{pair.Item2})");
                uf.Union2(pair.Item1, pair.Item2);
                Console.WriteLine($"Now have {uf.ComponentCount()} components");

                uf.PrintSiteInfo();
            }
        }
    }
}