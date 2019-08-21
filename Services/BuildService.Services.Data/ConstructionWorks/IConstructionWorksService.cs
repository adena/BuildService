namespace BuildService.Services.Data.ConstructionWorks
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using BuildService.Web.ViewModels.ConstructionWorks;

    public interface IConstructionWorksService
    {
        IEnumerable<TViewModel> GetAllConstructionWorks<TViewModel>();

        IEnumerable<TViewModel> GetMetricsTypes<TViewModel>();

        IEnumerable<TViewModel> GetAllCategories<TViewModel>();

        Task CreateNewWorkAsync(ConstructionWorksInputModel input);
    }
}
