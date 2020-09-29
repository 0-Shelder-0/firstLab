using System;
using System.Collections.Generic;

namespace firstLab
{
    public class GeneratorList : IGeneratorCollection
    {
        public object[] Generate(int count, int collectionCount)
        {
            var collectionList = new List<List<int>>();
            var rnd = new Random();

            for (var i = 0; i < collectionCount; i++)
            {
                collectionList.Add(new List<int>());
                for (var k = 0; k < count; k++)
                {
                    collectionList[i].Add(rnd.Next(0, 100));
                }
            }

            return collectionList.ToArray();
        }
    }
}
