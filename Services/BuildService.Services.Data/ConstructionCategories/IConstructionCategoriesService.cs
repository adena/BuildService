
namespace BuildService.Services.Data.ConstructionCategories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using BuildService.Web.ViewModels.ConstructionCategories;

    public interface IConstructionCategoriesService
    {
        IEnumerable<TViewModel> GetAllConstructionCategories<TViewModel>();

        Task CreateNewWorkAsync(ConstructionCategoriesInputModel input);
    }
}
