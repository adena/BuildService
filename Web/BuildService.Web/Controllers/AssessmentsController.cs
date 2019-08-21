namespace BuildService.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;

    using BuildService.Data.Models;
    using BuildService.Services.Data.Assessments;
    using BuildService.Services.Data.ConstructionWorks;
    using BuildService.Services.Mapping;
    using BuildService.Web.ViewModels.Assessments;
    using BuildService.Web.ViewModels.ConstructionWorks;
    using BuildService.Web.Areas.Identity.Pages.Account;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class AssessmentsController : BaseController
    {
        private readonly IAssessmentsService assessmentsService;
        private readonly IConstructionWorksService constructionWorksService;

        public AssessmentsController(IAssessmentsService assessmentsService, IConstructionWorksService constructionWorksService)
        {
            this.assessmentsService = assessmentsService;
            this.constructionWorksService = constructionWorksService;
        }

        public IActionResult All()
        {
            var assessments = this.assessmentsService.GetAllAssessments<AssessmentViewModel>();

            return this.View(assessments);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Create(AssessmentViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var works = this.constructionWorksService.GetAllConstructionWorks<ConstructionWorkViewModel>();

            if (input != null && works.Count() > 0)
            {
                return this.RedirectToAction("AddWorks", "Assessments", works);
            }

            return this.Redirect("Assessments/Create");
        }

        [HttpGet]
        [Authorize]
        public IActionResult AddWorks(AssessmentViewModel input)
        {
            this.ViewBag.AssessmentInput = input;

            return this.View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddWorks(List<ConstructionWorkViewModel> input)
        {
            (this.ViewBag.AssessmentInput as AssessmentInputModel).ConstructionWorks.ToList().AddRange(input);

            var assessment = this.assessmentsService.CreateNewAssessmentAsync(this.ViewBag.AssessmentInput as AssessmentInputModel);

            return this.View();
        }
    }
}
