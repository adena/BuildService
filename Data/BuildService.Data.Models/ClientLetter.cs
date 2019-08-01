
namespace BuildService.Data.Models
{
    using BuildService.Data.Common.Models;

    public class ClientLetter : BaseModel<string>
    {
        public int Number { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public string OfferId { get; set; }

        public Offer LinkedOffer { get; set; }

        public string Content { get; set; }
    }
}
