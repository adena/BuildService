namespace BuildService.Services.Data.ConstructionWorks
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BuildService.Data;
    using BuildService.Data.Models;
    using BuildService.Services.Mapping;
    using BuildService.Web.ViewModels.ConstructionWorks;

    public class ConstructionWorksService : IConstructionWorksService
    {
        private readonly ApplicationDbContext context;

        public ConstructionWorksService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<TViewModel> GetAllConstructionWorks<TViewModel>()
        {
            var constructionWorks = this.context.ConstructionWorks.To<TViewModel>().ToList();

            return constructionWorks;
        }

        public IEnumerable<TViewModel> GetMetricsTypes<TViewModel>()
        {
            var metrics = this.context.MetricsTypes.To<TViewModel>().ToList();

            return metrics;
        }

        public IEnumerable<TViewModel> GetAllCategories<TViewModel>()
        {
            var categories = this.context.ConstructionCategories.To<TViewModel>().ToList();

            return categories;
        }

        public async Task CreateNewWorkAsync(ConstructionWorksInputModel input)
        {
            ConstructionCategory category = this.context.ConstructionCategories.SingleOrDefault(x => x.Name == input.ConstructionCategory);

            MetricsType metric = this.context.MetricsTypes.SingleOrDefault(x => x.Name == input.Metric);

            ConstructionWork work = new ConstructionWork()
            {
                Title = input.Title,
                Metric = metric,
                Price = input.Price,
                ConstructionCategory = category,
            };

            await this.context.ConstructionWorks.AddAsync(work);
            await this.context.SaveChangesAsync();
        }
    }
}
