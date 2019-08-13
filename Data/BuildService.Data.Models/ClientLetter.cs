namespace BuildService.Data.Models
{
    using System;

    using BuildService.Data.Common.Models;

    public class ClientLetter : BaseDeletableModel<int>
    {
        public int Number { get; set; }

        public DateTime SentOn { get; set; }

        public int UserId { get; set; }

        public ApplicationUser User { get; set; }

        public int OfferId { get; set; }

        public Offer LinkedOffer { get; set; }

        public string Content { get; set; }
    }
}
