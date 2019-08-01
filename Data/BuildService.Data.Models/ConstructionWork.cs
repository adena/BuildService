namespace BuildService.Data.Models
{
    using BuildService.Data.Common.Models;
    using BuildService.Data.Models.Enum;

    public class ConstructionWork : BaseDeletableModel<string>
    {
        public decimal Price { get; set; }

        public MetricsType Metric { get; set; }

        public decimal Quantity { get; set; }

        public ConstructionCategory ConstructionCategory { get; set; }

        public decimal TotalWorkPrice => this.Price * this.Quantity;
    }
}