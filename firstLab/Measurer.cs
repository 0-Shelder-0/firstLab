using System;
using System.Diagnostics;
using System.Reflection;

namespace firstLab
{
    public class Measurer
    {
        public TimeSpan Measure(MethodInfo methodInfo, object[] parameters)
        {
            var stopwatch = new Stopwatch();
            methodInfo.Invoke(new TestMethods(), new object[methodInfo.GetParameters().Length]);

            stopwatch.Start();
            methodInfo.Invoke(new TestMethods(), parameters);
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }
    }
}
