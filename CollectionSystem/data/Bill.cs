namespace CollectionSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            BilllDetails = new HashSet<BilllDetail>();
            Receipts = new HashSet<Receipt>();
        }

        public int BillId { get; set; }

        public int? ClientBusinessId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BillDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BillDateFrom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BillDateTo { get; set; }

        public string BillNote { get; set; }

        public bool? BillIsActive { get; set; }

        public bool? BillIsCancelled { get; set; }

        public DateTime? BillCancelledDate { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BilllDetail> BilllDetails { get; set; }

        public virtual ClientBusiness ClientBusiness { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipt> Receipts { get; set; }
    }
}
