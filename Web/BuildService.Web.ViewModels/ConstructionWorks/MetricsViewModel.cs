namespace BuildService.Web.ViewModels.ConstructionWorks
{
    using BuildService.Data.Models;
    using BuildService.Services.Mapping;

    public class MetricsViewModel : IMapFrom<MetricsType>
    {
        public string Name { get; set; }
    }
}
