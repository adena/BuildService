namespace BuildService.Web.ViewModels.ConstructionWorks
{
    using BuildService.Data.Models;
    using BuildService.Services.Mapping;

    public class ConstructionWorksInputModel : IMapTo<ConstructionWork>, IMapFrom<ConstructionWork>, IMapFrom<ConstructionWorkViewModel>, IMapTo<ConstructionWorkViewModel>
    {
        public string Title { get; set; }

        public decimal Price { get; set; }

        public string Metric { get; set; }

        public string ConstructionCategory { get; set; }
    }
}
