namespace BuildService.Web.ViewModels.ConstructionWorks
{
    using System.Collections.Generic;

    using BuildService.Data.Models;
    using BuildService.Services.Mapping;

    public class CategoryViewModel : IMapFrom<ConstructionCategory>, IMapTo<ConstructionCategory>
    {
        public CategoryViewModel()
        {
            this.ConstructionWorks = new List<ConstructionWorkViewModel>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public List<ConstructionWorkViewModel> ConstructionWorks { get; set; }
    }
}
