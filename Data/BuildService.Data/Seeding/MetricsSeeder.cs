namespace BuildService.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BuildService.Data.Models;

    internal class MetricsSeeder : ISeeder
    {
        public Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (!dbContext.MetricsTypes.Any())
            {
               dbContext.MetricsTypes.AddRangeAsync(new MetricsType { Name = "м2" }, new MetricsType { Name = "м" }, new MetricsType { Name = "бр." });
            }

            return Task.CompletedTask;
        }
    }
}
