using System;
using System.Collections.Generic;
using System.Linq;

namespace firstLab
{
    class Program
    {
        static void Main()
        {
            var generator = new GeneratorList();
            var list = generator.Generate(5);

            var measurer = new Measurer();
            Console.WriteLine(
                $"Время Distinct на листе, состоящим из 5 элементов: {measurer.Measure(list, Distinct)}");
        }

        private static List<int> Distinct(List<int> list)
        {
            var hashSet = new HashSet<int>();

            foreach (var element in list)
            {
                hashSet.Add(element);
            }

            return hashSet.ToList();
        }
    }
}
