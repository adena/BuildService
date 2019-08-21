namespace BuildService.Web.ViewModels.Assessments
{
    using System;
    using System.Collections.Generic;

    using BuildService.Data.Models;
    using BuildService.Services.Mapping;
    using BuildService.Web.ViewModels.ConstructionWorks;

    public class AssessmentViewModel : IMapFrom<Assessment>
    {
        public AssessmentViewModel()
        {
            this.ConstructionWorks = new List<ConstructionWorkViewModel>();
        }

        public int Id { get; set; }

        public int Number { get; set; }

        public DateTime VisitedOn { get; set; } = DateTime.UtcNow;

        public string SiteAdress { get; set; }

        public string PotentialClientFirstName { get; set; }

        public string PotentialClientLastName { get; set; }

        public string PotentialClientEmail { get; set; }

        public string PotentialClientPhone { get; set; }

        public string Details { get; set; }

        public IList<ConstructionWorkViewModel> ConstructionWorks { get; set; }
    }
}
