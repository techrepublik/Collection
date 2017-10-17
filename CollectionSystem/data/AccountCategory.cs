namespace CollectionSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AccountCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccountCategory()
        {
            Particulars = new HashSet<Particular>();
        }

        public int AccountCategoryId { get; set; }

        public int? AccountOwnerId { get; set; }

        [StringLength(150)]
        public string AccountCategoryName { get; set; }

        public string AccountCategoryDescription { get; set; }

        public bool? AccountCategoryIsActive { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public virtual AccountOwner AccountOwner { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Particular> Particulars { get; set; }
    }
}
