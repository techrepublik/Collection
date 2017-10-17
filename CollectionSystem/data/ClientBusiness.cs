namespace CollectionSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClientBusiness
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClientBusiness()
        {
            Bills = new HashSet<Bill>();
        }

        public int ClientBusinessId { get; set; }

        public int? ClientId { get; set; }

        public int? ClientBusinessCode { get; set; }

        [StringLength(200)]
        public string ClientBusinessName { get; set; }

        public string ClientBusinessAddress { get; set; }

        [StringLength(50)]
        public string ClientBusinessPermitNo { get; set; }

        public int? ClientBusinessBranchNo { get; set; }

        public int? ClientBusinessNoPerson { get; set; }

        public double? ClientBusinessCapitalization { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ClientBusinessStatDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ClientBusinessEndDate { get; set; }

        public bool? ClientBusinessIsActive { get; set; }

        public int? BusinessLineId { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }

        public virtual Client Client { get; set; }
    }
}
