namespace BuildService.Services.Data.Assessments
{
    using BuildService.Web.ViewModels.Assessments;

    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IAssessmentsService
    {
        IEnumerable<TViewModel> GetAllAssessments<TViewModel>();

        AssessmentViewModel GetAssessmentById(int id);

        Task<int> CreatePartialAssessmentAsync(AssessmentViewModel input);

        Task AddWorksToAssessment(AssessmentViewModel viewModel);

    }
}
