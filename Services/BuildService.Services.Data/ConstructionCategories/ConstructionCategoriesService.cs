namespace BuildService.Services.Data.ConstructionCategories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BuildService.Data;
    using BuildService.Data.Models;
    using BuildService.Services.Mapping;
    using BuildService.Web.ViewModels.ConstructionCategories;

    public class ConstructionCategoriesService : IConstructionCategoriesService
    {
        private readonly ApplicationDbContext context;

        public ConstructionCategoriesService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task CreateNewWorkAsync(ConstructionCategoriesInputModel input)
        {
            var category = input.To<ConstructionCategory>();

            await this.context.ConstructionCategories.AddAsync(category);
            await this.context.SaveChangesAsync();
        }

        public IEnumerable<TViewModel> GetAllConstructionCategories<TViewModel>()
        {
            var constructionCategories = this.context.ConstructionCategories.To<TViewModel>().ToList();

            return constructionCategories;
        }
    }
}
