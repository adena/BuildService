namespace BuildService.Web.ViewModels.Assessments
{
    using System;
    using System.Collections.Generic;

    using BuildService.Data.Models;
    using BuildService.Services.Mapping;
    using BuildService.Web.ViewModels.ConstructionWorks;

    public class AssessmentInputModel : IMapTo<Assessment>, IMapFrom<AssessmentViewModel>, IMapTo<AssessmentViewModel>
    {
        public AssessmentInputModel()
        {
            this.ConstructionWorks = new List<ConstructionWorkViewModel>();
        }

        public int Number { get; set; }

        public DateTime VisitedOn { get; set; }

        public string PotentialClientFirstName { get; set; }

        public string PotentialClientLastName { get; set; }

        public string PotentialClientEmail { get; set; }

        public string PotentialClientPhone { get; set; }

        public string SiteAdress { get; set; }

        public IList<ConstructionWorkViewModel> ConstructionWorks { get; set; }
    }
}
