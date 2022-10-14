using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using GarbageCollectionBenchmark.Models;

namespace GarbageCollectionBenchmark.Benchmarks;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class ReusableArrayListBenchmarks
{
    private readonly ReusableArrayList ReusableArrayList = new ReusableArrayList();

    [Benchmark]
    public void UseArrayList() => ReusableArrayList.UseArrayList();

    [Benchmark]
    public void ReuseArrayList() => ReusableArrayList.ReuseArrayList();
}