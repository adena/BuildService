namespace BuildService.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BuildService.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (!dbContext.ConstructionCategories.Any())
            {
                dbContext.ConstructionCategories.AddRangeAsync(new ConstructionCategory { Name = "Замазки" }, new ConstructionCategory { Name = "Боядисване" }, new ConstructionCategory { Name = "Сухо строителство" });
            }

            return Task.CompletedTask;
        }
    }
}
