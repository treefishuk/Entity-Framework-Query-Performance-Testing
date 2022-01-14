using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using EFPerformanceComparison.Core.Abstractions;

namespace EFPerformanceComparison.Core.Tests
{
    [SimpleJob(RunStrategy.Throughput, launchCount: 1, warmupCount: 5, invocationCount: 50, targetCount: 10)]
    [MedianColumn]
    public abstract class BenchMarksBase
    {
        public abstract IUnitOfWork GetUnitOfWork();

        [Benchmark]
        public void LoadAllBookBooks() => new LoadAllRecordsTest(GetUnitOfWork()).LoadAllBooks();

        [Benchmark]
        public void LoadAllBooksUntracked() => new LoadAllRecordsTest(GetUnitOfWork()).LoadAllBooksUntracked();

        [Benchmark]
        public void LoadAllBookBooksIncludingAuthor() => new LoadAllRecordsTest(GetUnitOfWork()).LoadAllBooksWithAuthor();

        [Benchmark]
        public void LoadAllBooksWithAuthorProjection() => new LoadAllRecordsTest(GetUnitOfWork()).LoadAllBooksWithAuthorProjection();

        [Benchmark]
        public void LoadAllBooksWithAuthorProjectionUntracked() => new LoadAllRecordsTest(GetUnitOfWork()).LoadAllBooksWithAuthorProjectionUntracked();

        [Benchmark]
        public void LoadAllBooksWithAuthorOrderedByAuthor() => new SortingTests(GetUnitOfWork()).LoadAllBooksOrderedByAuthor();

        [Benchmark]
        public void LoadAllBooksOrderedByAuthorProjection() => new SortingTests(GetUnitOfWork()).LoadAllBooksOrderedByAuthorProjection();

        [Benchmark]
        public void LoadAllBooksOrderedByAuthorProjectionUntracked() => new SortingTests(GetUnitOfWork()).LoadAllBooksOrderedByAuthorProjectionUntracked();

    }
}
