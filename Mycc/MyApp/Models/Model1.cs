namespace MyApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=TestModel")
        {
        }

        public virtual DbSet<C_支付方式> C_支付方式 { get; set; }
        public virtual DbSet<C_代理> C_代理 { get; set; }
        public virtual DbSet<C_貨品> C_貨品 { get; set; }
        public virtual DbSet<INM> INM { get; set; }
        public virtual DbSet<INM_1> INM_1 { get; set; }
        public virtual DbSet<INM_BUP> INM_BUP { get; set; }
        public virtual DbSet<MY_db> MY_db { get; set; }
        public virtual DbSet<OutM> OutM { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<貨品表> 貨品表 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C_代理>()
                .HasMany(e => e.INM)
                .WithOptional(e => e.C_代理)
                .HasForeignKey(e => e.代理);

            modelBuilder.Entity<C_貨品>()
                .Property(e => e.價格)
                .HasPrecision(19, 4);

            modelBuilder.Entity<C_貨品>()
                .HasMany(e => e.INM)
                .WithOptional(e => e.C_貨品)
                .HasForeignKey(e => e.產品);

            modelBuilder.Entity<INM>()
                .Property(e => e.價格)
                .HasPrecision(19, 4);

            modelBuilder.Entity<INM_1>()
                .Property(e => e.價格)
                .HasPrecision(19, 4);

            modelBuilder.Entity<INM_BUP>()
                .Property(e => e.價格)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MY_db>()
                .Property(e => e.價格)
                .HasPrecision(19, 4);
        }
    }
}
