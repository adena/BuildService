﻿namespace BuildService.Data.Models
{
    using System.Collections.Generic;

    using BuildService.Data.Common.Models;

    public class ConstructionCategory : BaseDeletableModel<int>
    {
        public ConstructionCategory()
        {
            this.ConstructionWorks = new List<ConstructionWork>();
        }

        public string Name { get; set; }

        public IEnumerable<ConstructionWork> ConstructionWorks { get; set; }
    }
}
