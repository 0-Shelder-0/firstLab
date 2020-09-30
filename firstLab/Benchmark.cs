using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace firstLab
{
    public static class Benchmark
    {
        public static void Run(FileStream stream,
                               MethodInfo methodInfo,
                               IGeneratorCollection generator,
                               List<int> itemCountList)
        {
            var maxCount = generator.Generate(itemCountList.Max(), methodInfo.GetParameters().Length);
            var measurer = new Measurer();
            
            WriteText(stream, $"Время {methodInfo.Name} на листе, состоящем из\n");
            foreach (var count in itemCountList)
            {
                var parameters = maxCount.Select(list => list.Take(count).ToList())
                                         .ToArray();

                WriteText(stream, $"{measurer.Measure(methodInfo, parameters).TotalMilliseconds}\n");
            }

            WriteText(stream, "\n");
        }

        private static void WriteText(Stream stream, string text)
        {
            stream.Write(Encoding.Default.GetBytes(text));
        }
    }
}
