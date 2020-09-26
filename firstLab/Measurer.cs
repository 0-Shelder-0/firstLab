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
            methodInfo.Invoke(new TestMethods(), new object[] {new List<int>()});

            stopwatch.Start();
            methodInfo.Invoke(new TestMethods(), new object[] {list});
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }
    }
}
