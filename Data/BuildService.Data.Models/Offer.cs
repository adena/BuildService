namespace BuildService.Data.Models
{
    using System;
    using System.Collections.Generic;

    using BuildService.Data.Common.Models;

    public class Offer : BaseModel<string>
    {
        public Offer()
        {
            this.AdditionalConstructionWorks = new List<ConstructionWork>();
            this.RemovedConstructionWorks = new List<ConstructionWork>();
            this.Bonus = new List<ConstructionWork>();
        }

        public int Number { get; set; }

        public DateTime Created { get; set; }

        public bool Contracted { get; set; }

        public string AssessmentId { get; set; }

        public Assessment Assessment { get; set; }

        public IEnumerable<ConstructionWork> RemovedConstructionWorks { get; set; }

        public IEnumerable<ConstructionWork> AdditionalConstructionWorks { get; set; }

        public IEnumerable<ConstructionWork> Bonus { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
