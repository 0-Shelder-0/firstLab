using System.Collections.Generic;
using System.Linq;

namespace firstLab
{
    class Program
    {
        static void Main()
        {
            var itemCountList = new List<int> {100, 10000, 1000000};

            foreach (var method in typeof(TestMethods).GetMethods()
                                                      .Where(info => info.ReturnType.IsGenericType))
            {
                Benchmark.Run(itemCountList, method);
            }
        }
    }
}
