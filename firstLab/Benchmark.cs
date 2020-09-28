using System;
using System.Collections.Generic;
using System.Reflection;

namespace firstLab
{
    public class Benchmark
    {
        public static void Run(MethodInfo methodInfo,
                                  IGeneratorCollection generator,
                                  IEnumerable<int> itemCountList)
        {
            Console.WriteLine($"Время {methodInfo.Name} на листе, состоящем из");
            foreach (var count in itemCountList)
            {
                var measurer = new Measurer();
                var parameters = generator.Generate(count);

                Console.WriteLine($"{count} элементов: {measurer.Measure(methodInfo, parameters).TotalMilliseconds}");
            }
            Console.WriteLine();
        }
    }
}
