namespace SDK_08_2020_MVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelCounties : DbContext
    {
        public ModelCounties()
            : base("name=ModelCounties")
        {
        }

        public virtual DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .Property(e => e.Iso)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.Iso3)
                .IsUnicode(false);
        }
    }
}
