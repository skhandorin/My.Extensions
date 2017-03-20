using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace My.Extensions.Advanced.Demo1
{
    public static class InstrumentationExtensions
    {
        private static Dictionary<Guid, Stopwatch> _StopWatches = new Dictionary<Guid, Stopwatch>();

        public static double GetPreciseElapsedTime(this Instrumentation instrumentation)
        {
            var fieldInfo = typeof(Instrumentation).GetField("startedAt", BindingFlags.Instance | BindingFlags.NonPublic);
            var startedAt = (DateTime)fieldInfo.GetValue(instrumentation);
            return new TimeSpan(DateTime.Now.Ticks - startedAt.Ticks).TotalSeconds;
        }

        public static void StartWithPrecision(this Instrumentation instrumentation)
        {
            _StopWatches[instrumentation.Id] = Stopwatch.StartNew();
        }

        public static long GetReallyPreciseElapsedTime(this Instrumentation instrumentation)
        {
            return _StopWatches[instrumentation.Id].ElapsedMilliseconds;
        }
    }
}
