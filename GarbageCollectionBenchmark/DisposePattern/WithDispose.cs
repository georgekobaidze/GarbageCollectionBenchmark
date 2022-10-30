using System.Diagnostics;

namespace GarbageCollectionBenchmark.DisposePattern;

public class WithDispose : IDisposable
{
    private readonly Stopwatch _stopwatch;
    private bool _disposed = false;

    public WithDispose()
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

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            _stopwatch.Stop();
            Interlocked.Increment(ref DisposeRunner.FinalizedObjectsCount);
            Interlocked.Add(ref DisposeRunner.TotalTime, _stopwatch.ElapsedMilliseconds);

            if (disposing)
            {
                // Explicitly called from user code
                // You can do basically anything here
            }
            else
            {
                // Called from the finalizer
                // Do not access references, run quickly
            }
        }
    }
    
    ~WithDispose()
    {
        Dispose(false);
    }
}