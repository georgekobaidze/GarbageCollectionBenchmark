using System.Text;

namespace GarbageCollectionBenchmark.Models;

public class StringConcatenation
{
    public string NonOptimalConcat()
    {
        var builder = new StringBuilder();
        for (var i = 0; i < 10000; i++)
            builder.Append(i + "KB");

        return builder.ToString();
    }

    public string OptimizedConcat()
    {
        var builder = new StringBuilder();
        for (var i = 0; i < 10000; i++)
        {
            builder.Append(i);
            builder.Append("KB");
        }

        return builder.ToString();
    }
}