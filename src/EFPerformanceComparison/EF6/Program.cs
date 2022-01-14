using BenchmarkDotNet.Running;

namespace EFPerformanceComparison.EFSix
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchMarks>();
        }
    }
}
