using EFPerformanceComparison.Core.Abstractions;
using EFPerformanceComparison.Core.Tests;
using EFPerformanceComparison.EFCoreThree.Data;

namespace EFPerformanceComparison.EFCoreThree
{
    public class BenchMarks : BenchMarksBase
    {
        public override IUnitOfWork GetUnitOfWork()
        {
            return new UnitOfWork();
        }
    }
}
