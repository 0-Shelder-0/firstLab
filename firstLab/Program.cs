using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using firstLab.Generators;

namespace firstLab
{
    static class Program
    {
        private static void Main()
        {
            var itemCountList = GetItemCountList(100);
            var generator = new GeneratorWorstList();
            foreach (var method in GetTestMethods())
            {
                using (var stream = new FileStream(GetFilePath(method), FileMode.Create, FileAccess.Write))
                {
                    Benchmark.Run(stream, method, generator, itemCountList);
                }
            }
        }

        private static List<int> GetItemCountList(int count)
        {
            return Enumerable.Range(1, count)
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
