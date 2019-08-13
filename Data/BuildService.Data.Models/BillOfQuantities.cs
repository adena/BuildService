namespace BuildService.Data.Models
{
    using System.Collections.Generic;
    using System.Linq;

    using BuildService.Data.Common.Models;

    public class BillOfQuantities : BaseDeletableModel<int>
    {
        public BillOfQuantities()
        {
            this.ExecutedWorks = new List<ConstructionWork>();
        }

        public int Number { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }

        public int OfferId { get; set; }

        public Offer LinkedOffer { get; set; }

        public int ContractId { get; set; }

        public Contract Contract { get; set; }

        public IEnumerable<ConstructionWork> ExecutedWorks { get; set; }

        public decimal Total => this.ExecutedWorks.Sum(x => x.Price * x.Quantity);

        public decimal ReceivedPayments { get; set; }

        public decimal AmountDue { get; set; }
    }
}
