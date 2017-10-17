namespace CollectionSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Interest
    {
        public int InterestId { get; set; }

        public double? InterestPercent { get; set; }
    }
}
