using System;
using System.Collections.Generic;

namespace firstLab
{
    public class GeneratorList
    {
        public List<int> Generate(int count)
        {
            var list = new List<int>();
            var rnd = new Random();
            
            for (var i = 0; i < count; i++)
            {
                list.Add(rnd.Next(int.MinValue, int.MaxValue));
            }
            
            return list;
        }
    }
}
