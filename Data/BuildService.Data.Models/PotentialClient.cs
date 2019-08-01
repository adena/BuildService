namespace BuildService.Data.Models
{
    using BuildService.Data.Common.Models;

    public class PotentialClient : BaseModel<string>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string SiteAdress { get; set; }
    }
}
