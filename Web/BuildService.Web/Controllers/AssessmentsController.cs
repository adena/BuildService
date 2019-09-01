namespace BuildService.Web.Controllers
{
    using BuildService.Services.Data.Assessments;
    using BuildService.Services.Data.ConstructionWorks;
    using BuildService.Web.ViewModels.Assessments;
    using BuildService.Web.ViewModels.ConstructionWorks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

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

            var assessmentId = this.assessmentsService.CreatePartialAssessment(input);
            
            if (input != null)
            {
                return this.RedirectToAction("AddWorks", "Assessments", new { id = assessmentId });
            }

            return this.Redirect("/Assessments/Create");
        }

        [HttpGet]
        [Authorize]
        // [Route("Assessments/AddWorks/{id}")]
        public IActionResult AddWorks(int id)
        {
            this.TempData["Id"] = id;

            var works = this.constructionWorksService.GetAllConstructionWorks<ConstructionWorkViewModel>();
            return this.View(works);
        }

        [HttpPost]
        [Authorize]
        [Route("Assessments/AddWorks/{id}")]
        public IActionResult AddWorks(int id, List<ConstructionWorkViewModel> input)
        {
            this.ViewData["Id"] = this.TempData["Id"];

            var assessmentId = (int)this.ViewData["Id"];

            var assessmentViewModel = this.assessmentsService.GetAssessmentById(assessmentId);

            foreach (var item in input)
            {
                if (item.Quantity > 0)
                {
                    assessmentViewModel.ConstructionWorks.Add(item);
                }
            }

            var result = this.assessmentsService.AddWorksToAssessment(assessmentViewModel);
            
            return this.RedirectToAction("Details", new { assessmentid = assessmentId });
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var assessment = this.assessmentsService.GetAssessmentById(id);

            return this.View(assessment);
        }
    }
}
