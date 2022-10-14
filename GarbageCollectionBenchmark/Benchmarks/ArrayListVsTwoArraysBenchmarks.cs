using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using GarbageCollectionBenchmark.Models;

namespace GarbageCollectionBenchmark.Benchmarks;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class ArrayListVsTwoArraysBenchmarks
{
    private static readonly ArrayListVsTwoArrays ArrayListVsTwoArrays = new ArrayListVsTwoArrays();

    [Benchmark]
    public void UseArrayList() => ArrayListVsTwoArrays.UseArrayList();

    [Benchmark]
    public void UseTwoArrays() => ArrayListVsTwoArrays.UseTwoArrays();
}