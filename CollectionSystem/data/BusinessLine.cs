namespace CollectionSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BusinessLine
    {
        public int BusinessLineId { get; set; }

        [StringLength(100)]
        public string BusinessLineName { get; set; }

        public string BusinessLineDescription { get; set; }
    }
}
