using System;
using System.Collections.Generic;

namespace firstLab
{
    public class GeneratorList : IGeneratorCollection
    {
        public object[] Generate(int count)
        {
            var list = new List<int>();
            var rnd = new Random();

            for (var i = 0; i < count; i++)
            {
                list.Add(rnd.Next(int.MinValue, int.MaxValue));
            }

            return new object[] {list};
        }
    }
}
