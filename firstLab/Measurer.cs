using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace firstLab
{
    public class Measurer
    {
        public TimeSpan Measure(List<int> list, Func<List<int>, List<int>> func)
        {
            var stopwatch = new Stopwatch();
            func(new List<int>());
            
            stopwatch.Start();
            func(list);
            stopwatch.Stop();
            
            var resultTime = stopwatch.Elapsed;
            return resultTime;
        }
    }
}
