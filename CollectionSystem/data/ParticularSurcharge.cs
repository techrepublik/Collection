namespace CollectionSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ParticularSurcharge
    {
        [Key]
        public int PartcticularSurchargeId { get; set; }

        public int? ParticularId { get; set; }

        public int? SurchargeId { get; set; }

        public bool? ParticularSurchargeIsActive { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }
    }
}
