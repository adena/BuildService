namespace BuildService.Services.Data.Assessments
{
    using BuildService.Web.ViewModels.Assessments;

    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IAssessmentsService
    {
        IEnumerable<TViewModel> GetAllAssessments<TViewModel>();

        Task CreateNewAssessmentAsync(AssessmentInputModel input);
    }
}
