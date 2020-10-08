using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using firstLab.Generators;

namespace firstLab
{
    public static class Benchmark
    {
        public static void Run(FileStream stream,
                               MethodInfo methodInfo,
                               IGeneratorCollection generator,
                               List<int> itemCountList)
        {
            var maxCount = generator.GenerateList(itemCountList.Max(), methodInfo.GetParameters().Length);
            var measurer = new Measurer();
            measurer.Measure(methodInfo, GetParameters(maxCount, 100)); //Test run
            WriteText(stream, $"Время {methodInfo.Name} на листе, состоящем из");
            foreach (var count in itemCountList)
            {
                var time = measurer.Measure(methodInfo, GetParameters(maxCount, count)).TotalMilliseconds;
                WriteText(stream, $"{count} : {time} ms");
            }
        }

        private static List<int>[] GetParameters(IEnumerable<List<int>> maxCount, int count)
        {
            return maxCount.Select(list => list.Take(count).ToList())
                           .ToArray();
        }

        private static void WriteText(Stream stream, string text)
        {
            stream.Write(Encoding.Default.GetBytes(text));
            stream.Write(Encoding.Default.GetBytes("\r\n"));
        }
    }
}
