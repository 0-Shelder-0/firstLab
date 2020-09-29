using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace firstLab
{
    public static class Benchmark
    {
        public static void Run(FileStream stream,
                               MethodInfo methodInfo,
                               IGeneratorCollection generator,
                               IEnumerable<int> itemCountList)
        {
            WriteText(stream, $"Время {methodInfo.Name} на листе, состоящем из\n");
            foreach (var count in itemCountList)
            {
                var measurer = new Measurer();
                var parameters = generator.Generate(count, methodInfo.GetParameters().Length);

                WriteText(stream, $"{count}: {measurer.Measure(methodInfo, parameters).TotalMilliseconds}\n");
            }

            WriteText(stream, "\n");
        }

        private static void WriteText(Stream stream, string text)
        {
            stream.Write(Encoding.Default.GetBytes(text));
        }
    }
}
