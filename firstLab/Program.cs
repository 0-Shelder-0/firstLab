using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;

namespace firstLab
{
    static class Program
    {
        [SuppressMessage("ReSharper.DPA", "DPA0003: Excessive memory allocations in LOH", MessageId = "type: System.Int32[]")]
        [SuppressMessage("ReSharper.DPA", "DPA0003: Excessive memory allocations in LOH", MessageId = "type: Slot[System.Int32][]")]
        private static void Main()
        {
            var itemCountList = Enumerable.Range(0, 101)
                                          .Select(item => item * 1000)
                                          .ToList();
            itemCountList[0] = 50;
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
