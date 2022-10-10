using BenchmarkDotNet.Running;
using GarbageCollectionBenchmark.Benchmarks;

BenchmarkRunner.Run<GenericVsArrayListBenchmarks>();