namespace BuildService.Services.Data.Assessments
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using BuildService.Web.ViewModels.Assessments;

    public interface IAssessmentsService
    {
        IEnumerable<TViewModel> GetAllAssessments<TViewModel>();

        AssessmentViewModel GetAssessmentById(int id);

        int CreatePartialAssessment(AssessmentViewModel input);

        void AddWorksToAssessment(AssessmentViewModel viewModel);

        int DeleteAssessment(int id);

    }
}
