namespace CollectionSystem.data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CollectionModel : DbContext
    {
        public CollectionModel()
            : base("name=CollectionModel")
        {
        }

        public virtual DbSet<AccountCategory> AccountCategories { get; set; }
        public virtual DbSet<AccountOwner> AccountOwners { get; set; }
        public virtual DbSet<BilllDetail> BilllDetails { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BusinessLine> BusinessLines { get; set; }
        public virtual DbSet<BusinessType> BusinessTypes { get; set; }
        public virtual DbSet<ClientBusiness> ClientBusinesses { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Interest> Interests { get; set; }
        public virtual DbSet<ParticularInterest> ParticularInterests { get; set; }
        public virtual DbSet<Particular> Particulars { get; set; }
        public virtual DbSet<ParticularSurcharge> ParticularSurcharges { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<Surcharge> Surcharges { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountCategory>()
                .Property(e => e.AccountCategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<AccountCategory>()
                .Property(e => e.AccountCategoryDescription)
                .IsUnicode(false);

            modelBuilder.Entity<AccountCategory>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<AccountCategory>()
                .HasMany(e => e.Particulars)
                .WithOptional(e => e.AccountCategory)
                .WillCascadeOnDelete();

            modelBuilder.Entity<AccountOwner>()
                .Property(e => e.AccountOwnerName)
                .IsUnicode(false);

            modelBuilder.Entity<AccountOwner>()
                .Property(e => e.AccountOwnerDescription)
                .IsUnicode(false);

            modelBuilder.Entity<AccountOwner>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<AccountOwner>()
                .HasMany(e => e.AccountCategories)
                .WithOptional(e => e.AccountOwner)
                .WillCascadeOnDelete();

            modelBuilder.Entity<BilllDetail>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .Property(e => e.BillNote)
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .HasMany(e => e.BilllDetails)
                .WithOptional(e => e.Bill)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Bill>()
                .HasMany(e => e.Receipts)
                .WithOptional(e => e.Bill)
                .WillCascadeOnDelete();

            modelBuilder.Entity<BusinessLine>()
                .Property(e => e.BusinessLineName)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessLine>()
                .Property(e => e.BusinessLineDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessType>()
                .Property(e => e.BusinessTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessType>()
                .Property(e => e.BusinessTypeDesctiption)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessType>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ClientBusiness>()
                .Property(e => e.ClientBusinessName)
                .IsUnicode(false);

            modelBuilder.Entity<ClientBusiness>()
                .Property(e => e.ClientBusinessAddress)
                .IsUnicode(false);

            modelBuilder.Entity<ClientBusiness>()
                .Property(e => e.ClientBusinessPermitNo)
                .IsUnicode(false);

            modelBuilder.Entity<ClientBusiness>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ClientBusiness>()
                .HasMany(e => e.Bills)
                .WithOptional(e => e.ClientBusiness)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientLastName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientFristName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientMiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientCommonName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientContactNo)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientSex)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientNote)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.ClientBusinesses)
                .WithOptional(e => e.Client)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ParticularInterest>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Particular>()
                .Property(e => e.ParticularCode)
                .IsUnicode(false);

            modelBuilder.Entity<Particular>()
                .Property(e => e.ParticularName)
                .IsUnicode(false);

            modelBuilder.Entity<Particular>()
                .Property(e => e.ParticularAmount)
                .IsFixedLength();

            modelBuilder.Entity<Particular>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Particular>()
                .HasMany(e => e.BilllDetails)
                .WithOptional(e => e.Particular)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ParticularSurcharge>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserPassword)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserFullName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);
        }
    }
}
