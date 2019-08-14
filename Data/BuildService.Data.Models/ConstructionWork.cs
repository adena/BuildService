namespace BuildService.Data.Models
{
    using BuildService.Data.Common.Models;

    public class ConstructionWork : BaseDeletableModel<int>
    {
        public ConstructionWork()
        {
            this.Quantity = 0.0m;
        }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public int MetricId { get; set; }

        public MetricsType Metric { get; set; }

        public decimal Quantity { get; set; } = 0.0m;

        public int ConstructionCategoryId { get; set; }

        public ConstructionCategory ConstructionCategory { get; set; }

        public decimal TotalWorkPrice => this.Price * this.Quantity;
    }
}
