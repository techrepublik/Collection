namespace CollectionSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Surcharge
    {
        public int SurchargeId { get; set; }

        public double? SurchargeAmount { get; set; }

        public double? SurchargePercent { get; set; }

        public bool? SurchargeIsPercent { get; set; }

        public bool? SurchargeIsAmount { get; set; }
    }
}
