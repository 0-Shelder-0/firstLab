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
            var itemCountList = Enumerable.Range(1, 100)
                                          .Select(item => item * 50)
                                          .ToList();
            var generator = new GeneratorList();

            foreach (var method in GetTestMethods())
            {
                var stream = new FileStream($"C:/Users/{Environment.UserName}/Desktop/{method.Name}.txt",
                                            FileMode.Create,
                                            FileAccess.Write);
                Benchmark.Run(stream, method, generator, itemCountList);
                stream.Close();
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
