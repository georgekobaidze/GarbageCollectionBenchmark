using BenchmarkDotNet.Running;
using GarbageCollectionBenchmark.Benchmarks;
using GarbageCollectionBenchmark.Models;

BenchmarkRunner.Run<ReusableArrayListBenchmarks>();