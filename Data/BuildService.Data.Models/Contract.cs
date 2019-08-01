namespace BuildService.Data.Models
{
    using System;

    using BuildService.Data.Common.Models;

    public class Contract : BaseModel<string>
    {
        public int Number { get; set; }

        public DateTime SignedOn { get; set; }

        public string ClientId { get; set; }

        public Client Client { get; set; }

        public string AssessmentId { get; set; }

        public Assessment Assessment { get; set; }

        public string OfferId { get; set; }

        public Offer LinkedOffer { get; set; }
    }
}
