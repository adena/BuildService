namespace BuildService.Data.Models
{
    using BuildService.Data.Common.Models;

    public class MetricsType : BaseModel<int>
    {
        public string Name { get; set; }
    }
}
