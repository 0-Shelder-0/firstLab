using System;
using System.Collections.Generic;
using System.Reflection;

namespace firstLab
{
    public class Benchmark
    {
        public static void Run(List<int> itemCountList, MethodInfo methodInfo)
        {
            var nameFunc = methodInfo.Name;
            foreach (var count in itemCountList)
            {
                var generator = new GeneratorList();
                var list = generator.Generate(count);
                var measurer = new Measurer();

                Console.WriteLine(
                    $"Время {nameFunc} на листе, состоящем из {count} элементов: {measurer.Measure(methodInfo, list)}");
            }
        }
    }
}
