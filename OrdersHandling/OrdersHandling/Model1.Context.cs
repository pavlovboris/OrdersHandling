//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrdersHandling
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OrdersHandlingEntities : DbContext
    {
        public OrdersHandlingEntities()
            : base("name=OrdersHandlingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CoatingGroup> CoatingGroup { get; set; }
        public virtual DbSet<Codes> Codes { get; set; }
        public virtual DbSet<MU> MU { get; set; }
        public virtual DbSet<OrderLines> OrderLines { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Partners> Partners { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<SubTypes> SubTypes { get; set; }
        public virtual DbSet<Surface> Surface { get; set; }
        public virtual DbSet<Systems> Systems { get; set; }
        public virtual DbSet<Types> Types { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Colors> Colors { get; set; }
        public virtual DbSet<UploadedFiles> UploadedFiles { get; set; }
        public virtual DbSet<CoatingPrices> CoatingPrices { get; set; }
        public virtual DbSet<PartnerCoatingGroup> PartnerCoatingGroup { get; set; }
    }
}
