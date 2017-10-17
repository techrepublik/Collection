namespace CollectionSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Receipt
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReceiptId { get; set; }

        public int? BillId { get; set; }

        public int? ReceiptNo { get; set; }

        public DateTime? ReceiptDate { get; set; }

        public double? ReceiptAmount { get; set; }

        public bool? ReceiptIsCash { get; set; }

        public bool? ReceiptIdCheck { get; set; }

        public bool? ReceiptIdActive { get; set; }

        public bool? ReceiptIsCancelled { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual Bill Bill { get; set; }
    }
}
