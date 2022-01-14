using EFPerformanceComparison.Core.Abstractions;
using EFPerformanceComparison.Core.Tests;
using EFPerformanceComparison.EFCoreSix.Data;

namespace EFPerformanceComparison.EFCoreSix
{
    public class BenchMarks : BenchMarksBase
    {
        public override IUnitOfWork GetUnitOfWork()
        {
            return new UnitOfWork();
        }
    }
}
