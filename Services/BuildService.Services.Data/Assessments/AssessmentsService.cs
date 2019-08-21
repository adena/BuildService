namespace BuildService.Services.Data.Assessments
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BuildService.Data;
    using BuildService.Data.Models;
    using BuildService.Services.Mapping;
    using BuildService.Web.ViewModels.Assessments;

    public class AssessmentsService : IAssessmentsService
    {
        private readonly ApplicationDbContext context;

        public AssessmentsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task CreateNewAssessmentAsync(AssessmentInputModel input)
        {
            var assessment = input.To<Assessment>();

            await this.context.Assessments.AddAsync(assessment);
            await this.context.SaveChangesAsync();
        }

        public IEnumerable<TViewModel> GetAllAssessments<TViewModel>()
        {
            var assessments = this.context.Assessments.To<TViewModel>().ToList();

            return assessments;
        }

    }
}
