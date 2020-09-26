using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace firstLab
{
    static class Program
    {
        private static void Main()
        {
            var itemCountList = new List<int> {100, 10000, 1000000};

            foreach (var method in GetTestMethods())
            {
                Benchmark.Run(itemCountList, method);
            }
        }

        private static IEnumerable<MethodInfo> GetTestMethods()
        {
            return typeof(TestMethods)
                  .GetMethods()
                  .Where(info => info.GetCustomAttribute<TestMethodAttribute>() != null);
        }
    }
}
