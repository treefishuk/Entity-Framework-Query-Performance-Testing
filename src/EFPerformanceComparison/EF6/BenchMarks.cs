using EFPerformanceComparison.Core.Abstractions;
using EFPerformanceComparison.Core.Tests;
using EFPerformanceComparison.EFSix.Data;

namespace EFPerformanceComparison.EFSix
{
    public class BenchMarks : BenchMarksBase
    {
        public override IUnitOfWork GetUnitOfWork()
        {
            return new UnitOfWork();
        }
    }
}
