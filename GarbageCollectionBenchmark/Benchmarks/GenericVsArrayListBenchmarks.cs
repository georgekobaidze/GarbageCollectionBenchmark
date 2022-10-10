using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using GarbageCollectionBenchmark.Models;

namespace GarbageCollectionBenchmark.Benchmarks;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class GenericVsArrayListBenchmarks
{
    private static readonly GenericVsArrayList GenericVsArrayList = new GenericVsArrayList();

    [Benchmark]
    public void StoreInArrayList() => GenericVsArrayList.StoreInArrayList();

    [Benchmark]
    public void StoreInGenericList() => GenericVsArrayList.StoreInGenericList();
}