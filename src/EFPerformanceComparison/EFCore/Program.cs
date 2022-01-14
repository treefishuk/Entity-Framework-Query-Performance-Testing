using BenchmarkDotNet.Running;

namespace EFPerformanceComparison.EFCoreThree
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchMarks>();
        }
    }
}
