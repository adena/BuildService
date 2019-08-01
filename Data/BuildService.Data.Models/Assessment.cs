namespace BuildService.Data.Models
{
    using System;
    using System.Collections.Generic;

    using BuildService.Data.Common.Models;

    public class Assessment : BaseModel<string>
    {
        public Assessment()
        {
            this.ConstructionWorks = new List<ConstructionWork>();
        }

        public int Number { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public string SiteAdress { get; set; }

        public string PotentialClientId { get; set; }

        public PotentialClient PotentialClient { get; set; }

        public DateTime VisitedOn { get; set; }

        public IEnumerable<ConstructionWork> ConstructionWorks { get; set; }

        public string Details { get; set; }
    }
}
