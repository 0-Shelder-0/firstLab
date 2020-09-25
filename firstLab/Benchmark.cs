using System;
using System.Collections.Generic;
using System.Reflection;

namespace firstLab
{
    public class Benchmark
    {
        public static void Run(List<int> itemCountList, MethodInfo methodInfo)
        {
            Console.WriteLine($"Время {methodInfo.Name} на листе, состоящем из");
            foreach (var count in itemCountList)
            {
                var generator = new GeneratorList();
                var list = generator.Generate(count);
                var measurer = new Measurer();

                Console.WriteLine($"{count} элементов: {measurer.Measure(methodInfo, list).TotalMilliseconds}");
            }
            Console.WriteLine();
        }
    }
}
