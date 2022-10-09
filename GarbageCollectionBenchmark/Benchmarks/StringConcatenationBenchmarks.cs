using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using GarbageCollectionBenchmark.Models;

namespace GarbageCollectionBenchmark.Benchmarks;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class StringConcatenationBenchmarks
{
    private static readonly StringConcatenation StringConcatenation = new StringConcatenation();

    [Benchmark]
    public void NonOptimalConcat() => StringConcatenation.NonOptimalConcat();
    
    [Benchmark]
    public void OptimalConcat() => StringConcatenation.OptimizedConcat();
}