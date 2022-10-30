using System.Diagnostics;

namespace GarbageCollectionBenchmark.DisposePattern;

public class WithoutDispose
{
    private readonly Stopwatch _stopwatch;

    public WithoutDispose()
    {
        _stopwatch = new Stopwatch();
        _stopwatch.Start();
    }
    
    public void DoWork()
    {
        double j = 0;
        for (var i = 0; i < 1000; i++)
            j += i * i;
    }

    ~WithoutDispose()
    {
        _stopwatch.Stop();
        Interlocked.Increment(ref DisposeRunner.FinalizedObjectsCount);
        Interlocked.Add(ref DisposeRunner.TotalTime, _stopwatch.ElapsedMilliseconds);
    }
}