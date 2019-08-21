namespace BuildService.Web.ViewModels.ConstructionWorks
{
    using BuildService.Data.Models;
    using BuildService.Services.Mapping;

    public class MetricsInputModel : IMapTo<MetricsType>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
