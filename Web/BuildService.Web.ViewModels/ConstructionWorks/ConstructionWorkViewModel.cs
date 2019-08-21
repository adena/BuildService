namespace BuildService.Web.ViewModels.ConstructionWorks
{
    using BuildService.Data.Models;
    using BuildService.Services.Mapping;

    public class ConstructionWorkViewModel : IMapFrom<ConstructionWork>, IMapTo<ConstructionWork>
    {
        public string Title { get; set; }

        public decimal Price { get; set; }

        public string MetricName { get; set; }

        public string ConstructionCategoryName { get; set; }

        public decimal Quantity { get; set; }
    }
}
