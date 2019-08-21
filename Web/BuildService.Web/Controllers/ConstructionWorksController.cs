namespace BuildService.Web.Controllers
{
    using System.Threading.Tasks;

    using BuildService.Services.Data.ConstructionWorks;
    using BuildService.Web.ViewModels.ConstructionCategories;
    using BuildService.Web.ViewModels.ConstructionWorks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class ConstructionWorksController : BaseController
    {
        private readonly IConstructionWorksService constructionWorksService;

        public ConstructionWorksController(IConstructionWorksService constructionWorksService)
        {
            this.constructionWorksService = constructionWorksService;
        }

        [Authorize]
        public IActionResult All()
        {
            var constructionWorks = this.constructionWorksService.GetAllConstructionWorks<ConstructionWorkViewModel>();

            return this.View(constructionWorks);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            this.ViewData["Metrics"] = this.constructionWorksService.GetMetricsTypes<MetricsViewModel>();
            this.ViewData["Categories"] = this.constructionWorksService.GetAllCategories<CategoryViewModel>();

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ConstructionWorksInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.constructionWorksService.CreateNewWorkAsync(input);

            return this.Redirect("/ConstructionWorks/All");
        }
    }
}
