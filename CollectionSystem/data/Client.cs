namespace CollectionSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            ClientBusinesses = new HashSet<ClientBusiness>();
        }

        public int ClientId { get; set; }

        public int? ClientNo { get; set; }

        [StringLength(50)]
        public string ClientLastName { get; set; }

        [StringLength(50)]
        public string ClientFristName { get; set; }

        [StringLength(50)]
        public string ClientMiddleName { get; set; }

        public string ClientCommonName { get; set; }

        public string ClientAddress { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ClientBirthDate { get; set; }

        [StringLength(50)]
        public string ClientContactNo { get; set; }

        [Column(TypeName = "image")]
        public byte[] ClientPicture { get; set; }

        [StringLength(50)]
        public string ClientSex { get; set; }

        public string ClientNote { get; set; }

        public bool? ClientIsActive { get; set; }

        public int? BusinessTypeId { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientBusiness> ClientBusinesses { get; set; }
    }
}
