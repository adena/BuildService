namespace BuildService.Data.Models
{
    using System;

    using BuildService.Data.Common.Models;

    public class Contract : BaseDeletableModel<int>
    {
        public int Number { get; set; }

        public DateTime SignedOn { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }

        public int AssessmentId { get; set; }

        public Assessment Assessment { get; set; }

        public int OfferId { get; set; }

        public Offer LinkedOffer { get; set; }
    }
}
