using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace firstLab
{
    public class Measurer
    {
        public TimeSpan Measure(MethodInfo methodInfo, List<int> list)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            var result = methodInfo.Invoke(new TestMethods(), new object[] {list});
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }
    }
}
