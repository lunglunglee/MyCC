namespace Mycc.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Data_City> Data_City { get; set; }
        public virtual DbSet<Data_Province> Data_Province { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Data_Area> Data_Area { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Data_City>()
                .Property(e => e.CityCode)
                .IsUnicode(false);

            modelBuilder.Entity<Data_City>()
                .Property(e => e.ProvinceCode)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Province>()
                .Property(e => e.ProvinceCode)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Province>()
                .HasMany(e => e.Data_City)
                .WithRequired(e => e.Data_Province)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Data_Area>()
                .Property(e => e.AreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Area>()
                .Property(e => e.CityCode)
                .IsUnicode(false);
        }
    }
}
