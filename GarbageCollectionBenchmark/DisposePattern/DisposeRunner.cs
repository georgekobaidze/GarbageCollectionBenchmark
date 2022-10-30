namespace GarbageCollectionBenchmark.DisposePattern;

public class DisposeRunner
{
    public static long FinalizedObjectsCount = 0;
    public static long TotalTime = 0;

    public void Run()
    {
        for (var i = 0; i < 500000; i++)
        {
            using var obj = new WithDispose();
            obj.DoWork();
        }

        var avgLifeTime = 1.0 * TotalTime / FinalizedObjectsCount;
        
        Console.WriteLine("Number of finalized objects: {0}k", FinalizedObjectsCount / 1000);
        Console.WriteLine("Average resource lifetime: {0}ms", avgLifeTime);
    }
}