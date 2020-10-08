using System;
using System.Collections.Generic;
using System.Linq;

namespace firstLab.Generators
{
    public class GeneratorWorstList : IGeneratorCollection
    {
        public List<List<int>> GenerateList(int itemsCount, int collectionCount)
        {
            var result = new List<HashSet<int>>();
            var rnd = new Random();
            for (var i = 0; i < collectionCount; i++)
            {
                result.Add(new HashSet<int>());
                while (result[i].Count < itemsCount)
                {
                    result[i].Add(rnd.Next(int.MinValue, int.MaxValue));
                }
            }

            return result.Select(set => set.ToList()).ToList();
        }
    }
}
