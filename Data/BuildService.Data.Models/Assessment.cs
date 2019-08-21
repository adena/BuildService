namespace BuildService.Data.Models
{
    using System;
    using System.Collections.Generic;

    using BuildService.Data.Common.Models;

    public class Assessment : BaseDeletableModel<int>
    {
        public Assessment()
        {
            this.ConstructionWorks = new List<ConstructionWork>();
        }

        public int Number { get; set; }

        public string SiteAdress { get; set; }

        public int PotentialClientId { get; set; }

        public PotentialClient PotentialClient { get; set; }

        public DateTime VisitedOn { get; set; }

        public IList<ConstructionWork> ConstructionWorks { get; set; }

        public string Details { get; set; }
    }
}
