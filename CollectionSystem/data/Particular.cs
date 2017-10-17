namespace CollectionSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Particular
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Particular()
        {
            BilllDetails = new HashSet<BilllDetail>();
        }

        public int ParticularId { get; set; }

        public int? AccountCategoryId { get; set; }

        [StringLength(50)]
        public string ParticularCode { get; set; }

        [StringLength(100)]
        public string ParticularName { get; set; }

        public double? ParticularFrom { get; set; }

        public double? ParticularTo { get; set; }

        public double? ParticularIsPercent { get; set; }

        [StringLength(10)]
        public string ParticularAmount { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public virtual AccountCategory AccountCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BilllDetail> BilllDetails { get; set; }
    }
}
