using BenchmarkDotNet.Running;

namespace EFPerformanceComparison.EFCoreSix
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchMarks>();
        }
    }
}
