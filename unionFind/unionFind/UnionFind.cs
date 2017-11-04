using System;
using System.Collections.Generic;

namespace unionFind
{
    public class UnionFind
    {
        private readonly Random rnd;
        private readonly int sampleSize;
        private readonly int[] siteIds;
        private int component;

        public UnionFind(int sampleSize)
        {
            this.sampleSize = sampleSize;
            component = sampleSize;
            siteIds = new int [sampleSize];
            rnd = new Random();
            Pairs = new List<Tuple<int, int>>();
            GenerateSites();
        }

        public List<Tuple<int, int>> Pairs { get; }

        public int ComponentCount()
        {
            return component;
        }

        public bool IsConnected(int p, int q)
        {
            return Find(p) == Find(q);
        }

        public void PrintSiteInfo()
        {
            for (var i = 0; i < siteIds.Length; i++)
                Console.WriteLine($"Site = {i}, Value = {siteIds[i]}");
        }

        private int Find(int x)
        {
            return siteIds[x];
        }

        private int Find2(int x)
        {
            while (x != siteIds[x])
                x = siteIds[x];
            return x;
        }

        public void Union2(int p, int q)
        {
            // to put in same component, give p and q same root
            var proot = Find2(p);
            var qroot = Find2(q);

            if (proot == qroot) return;

            siteIds[proot] = qroot;
            component--;
        }


        public void Union(int p, int q)
        {
            var pid = Find(p);
            var qid = Find(q);

            if (pid == qid) return;

            for (var i = 0; i < siteIds.Length; i++)
                // rename pIds to qIds to 'connect' them
                if (siteIds[i] == pid) siteIds[i] = qid;

            component--;
        }

        private void GenerateSites()
        {
            for (var i = 0; i < sampleSize; i++)
            {
                siteIds[i] = i;
                Console.WriteLine($"i - {i}  siteId - {siteIds[i]}");
            }
        }

        public void GenerateRandomPair(int max)
        {
            for (var i = 0; i < max; i++)
            {
                var left = rnd.Next(max - 1);
                var right = rnd.Next(max - 1);

                Pairs.Add(new Tuple<int, int>(left, right));
            }
        }

        public void PrintPairs()
        {
            foreach (var tuple in Pairs)
                Console.WriteLine($"{tuple.Item1} {tuple.Item2}");
        }
    }
}