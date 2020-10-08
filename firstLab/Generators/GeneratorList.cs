using System;
using System.Collections.Generic;

namespace firstLab.Generators
{
    public class GeneratorList : IGeneratorCollection
    {
        public List<List<int>> GenerateList(int count, int collectionCount)
        {
            var collectionList = new List<List<int>>();
            var rnd = new Random();

            for (var i = 0; i < collectionCount; i++)
            {
                collectionList.Add(new List<int>());
                for (var k = 0; k < count; k++)
                {
                    collectionList[i].Add(rnd.Next(0, 10000000));
                }
            }

            return collectionList;
        }
    }
}
