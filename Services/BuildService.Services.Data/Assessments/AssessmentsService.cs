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

        public int CreatePartialAssessment(AssessmentViewModel input)
        {
            var assessment = new Assessment()
            {
                Number = input.Number,
                VisitedOn = input.VisitedOn,
                SiteAdress = input.SiteAdress,
                PotentialClient = new PotentialClient ()
                {
                    FirstName = input.PotentialClient.FirstName,
                    LastName = input.PotentialClient.LastName,
                    Email = input.PotentialClient.Email,
                    Phone = input.PotentialClient.Phone,
                    SiteAdress = input.SiteAdress,
                },
                Details = input.Details,
            };

            this.context.Assessments.Add(assessment);
            this.context.SaveChanges();

            var assessmentId = assessment.Id;
            return assessmentId;
        }

        public IEnumerable<TViewModel> GetAllAssessments<TViewModel>()
        {
            var assessments = this.context.Assessments.To<TViewModel>().ToList();

            return assessments;
        }

        public AssessmentViewModel GetAssessmentById(int id)
        {
            var assessment = this.context.Assessments.SingleOrDefault(x => x.Id == id);

            var client = this.context.PotentialClients.SingleOrDefault(x => x.Id == assessment.PotentialClientId);

            var result = new AssessmentViewModel() {
                Number = assessment.Number,
                VisitedOn = assessment.VisitedOn,
                SiteAdress = assessment.SiteAdress,
                PotentialClient = new PotentialClientViewModel()
                {
                    FirstName = client.FirstName,
                    LastName = client.LastName,
                    Email = client.Email,
                    Phone = client.Phone,
                },
                Details = assessment.Details,
            };

            return result;
        }

        public Task AddWorksToAssessment(AssessmentViewModel viewModel)
        {
            var assessment = this.context.Assessments.SingleOrDefault(x => x.Id == viewModel.Id);

            foreach (var item in viewModel.ConstructionWorks)
            {
                var cw = AutoMapper.Mapper.Map<ConstructionWork>(item);

                assessment.ConstructionWorks.Add(cw);
            }

            this.context.Assessments.Update(assessment);

            return Task.CompletedTask;
        }

    }
}
