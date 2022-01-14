namespace EFPerformanceComparison.Core.Entities
{
    public class Copy
    {
        public int CopyId { get; set; }
        public virtual Book Book { get; set; }
        public decimal Price { get; set; }
    }
}
