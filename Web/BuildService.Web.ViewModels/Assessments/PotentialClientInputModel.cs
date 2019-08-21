namespace BuildService.Web.ViewModels.Assessments
{
    using BuildService.Data.Models;
    using BuildService.Services.Mapping;

    public class PotentialClientInputModel : IMapTo<PotentialClient>, IMapFrom<PotentialClient>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
