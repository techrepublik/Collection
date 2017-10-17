namespace CollectionSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BilllDetail
    {
        [Key]
        public int BillDetailId { get; set; }

        public int? ParticularId { get; set; }

        public int? BillId { get; set; }

        public double? BillAmount { get; set; }

        public double? BillAnnual { get; set; }

        public double? BillMonthlyDue { get; set; }

        public double? BillQtrDue { get; set; }

        public double? BillTaxDue { get; set; }

        public double? BillSurcharge { get; set; }

        public double? BillInterest { get; set; }

        public double? BillTotalAmtDue { get; set; }

        public bool? BillIsActive { get; set; }

        public bool? BillIsCancelled { get; set; }

        public DateTime? BillCancelledDate { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual Bill Bill { get; set; }

        public virtual Particular Particular { get; set; }
    }
}
