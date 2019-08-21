namespace BuildService.Web.ViewModels.ConstructionCategories
{
    using System.Collections.Generic;

    using BuildService.Data.Models;
    using BuildService.Services.Mapping;
    using BuildService.Web.ViewModels.ConstructionWorks;

    public class ConstructionCategoryViewModel : IMapFrom<ConstructionCategory>
    {
        public ConstructionCategoryViewModel()
        {
            this.ConstructionWorks = new List<ConstructionWorkViewModel>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public List<ConstructionWorkViewModel> ConstructionWorks { get; set; }
    }
}
