namespace WebApplication5.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelEmployeedbContext : DbContext
    {
        public ModelEmployeedbContext()
            : base("name=ModelEmployeedbContext")
        {
        }

        public virtual DbSet<tblDepartmnet> tblDepartmnets { get; set; }
        public virtual DbSet<tblEmployee> tblEmployees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblDepartmnet>()
                .HasMany(e => e.tblEmployees)
                .WithOptional(e => e.tblDepartmnet)
                .HasForeignKey(e => e.DepartmnetId);
        }
    }
}
