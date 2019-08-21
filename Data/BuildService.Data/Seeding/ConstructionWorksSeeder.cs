
namespace BuildService.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BuildService.Data.Models;

    public class ConstructionWorksSeeder : ISeeder
    {
        public Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (!dbContext.ConstructionWorks.Any())
            {
                dbContext.ConstructionWorks.AddRangeAsync(new ConstructionWork { Title = "Циментова замазка до 2,5 см.", MetricId = 1, Price = 12.00m, ConstructionCategoryId = 1 }, new ConstructionWork { Title = "Боядисване с латекс", MetricId = 1, Price = 25.00m, ConstructionCategoryId = 2 }, new ConstructionWork { Title = "Варова мазилка", MetricId = 1, Price = 20.00m, ConstructionCategoryId = 1 });
            }

            return Task.CompletedTask;
        }
    }
}
