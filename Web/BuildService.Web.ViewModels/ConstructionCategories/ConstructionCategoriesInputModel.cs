namespace BuildService.Web.ViewModels.ConstructionCategories
{
    using BuildService.Data.Models;
    using BuildService.Services.Mapping;

    public class ConstructionCategoriesInputModel : IMapTo<ConstructionCategory>
    {
        public string Name { get; set; }
    }
}
