namespace BuildService.Web.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using BuildService.Services.Data.ConstructionCategories;
    using BuildService.Web.ViewModels.ConstructionCategories;
    using BuildService.Web.ViewModels.ConstructionWorks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class ConstructionCategoriesController : BaseController
    {
        private readonly IConstructionCategoriesService constructionCategoriesService;

        public ConstructionCategoriesController(IConstructionCategoriesService constructionCategoriesService)
        {
            this.constructionCategoriesService = constructionCategoriesService;
        }

        public IActionResult All()
        {
            this.ViewData["Categories"] = this.constructionCategoriesService.GetAllConstructionCategories<CategoryViewModel>();

            return this.View();
        }

        public IActionResult GetCategoryWorks(int categoryId)
        {
            var works = this.constructionCategoriesService.GetAllConstructionCategories<ConstructionCategoryViewModel>().FirstOrDefault(x => x.Id == categoryId).ConstructionWorks.ToList();

            return this.Json(works);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(ConstructionCategoriesInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.constructionCategoriesService.CreateNewWorkAsync(input);

            return this.Redirect("/ConstructionCategories/All");
        }
    }
}
