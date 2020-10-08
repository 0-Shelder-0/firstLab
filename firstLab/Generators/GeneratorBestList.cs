using System.Collections.Generic;
using System.Linq;

namespace firstLab.Generators
{
    public class GeneratorBestList : IGeneratorCollection
    {
        public List<List<int>> GenerateList(int itemsCount, int collectionCount)
        {
            var result = new List<List<int>>();
            for (var i = 0; i < collectionCount; i++)
            {
                result.Add(new List<int>());
                result[i] = Enumerable.Repeat(0, itemsCount).ToList();
            }

            return result;
        }
    }
}
