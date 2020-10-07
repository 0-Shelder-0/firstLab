using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace firstLab
{
    static class Program
    {
        private static void Main()
        {
            var itemCountList = GetItemCountList();
            var generator = new GeneratorList();
            foreach (var method in GetTestMethods())
            {
                using (var stream = new FileStream(GetFilePath(method), FileMode.Create, FileAccess.Write))
                {
                    Benchmark.Run(stream, method, generator, itemCountList);
                }
            }
        }

        private static List<int> GetItemCountList()
        {
            return Enumerable.Range(1, 100)
                             .Select(item => item * 1000)
                             .ToList();
        }

        private static string GetFilePath(MethodInfo method)
        {
            return $"C:/Users/{Environment.UserName}/Desktop/{method.Name}.txt";
        }

        private static IEnumerable<MethodInfo> GetTestMethods()
        {
            return typeof(TestMethods)
                  .GetMethods()
                  .Where(info => info.GetCustomAttribute<TestMethodAttribute>() != null);
        }
    }
}
