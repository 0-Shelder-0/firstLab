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
            var generator = new GeneratorList();

            foreach (var method in GetTestMethods())
            {
                Benchmark.Run(method, generator, itemCountList);
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
