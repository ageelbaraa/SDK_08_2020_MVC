namespace DataAccressProject.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CompanyModel : DbContext
    {
        public CompanyModel()
            : base("name=CompanyModeldb_1")
        {
        }

        public virtual DbSet<DEPARTMENT> DEPARTMENTs { get; set; }
        public virtual DbSet<DEPT_LOCATIONS> DEPT_LOCATIONS { get; set; }
        public virtual DbSet<EMP_DEPENDENT> EMP_DEPENDENT { get; set; }
        public virtual DbSet<EMPLOYEE> EMPLOYEEs { get; set; }
        public virtual DbSet<PROJECT> PROJECTs { get; set; }
        public virtual DbSet<WORKS_ON> WORKS_ON { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DEPARTMENT>()
                .Property(e => e.Dname)
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTMENT>()
                .Property(e => e.Mgr_ssn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DEPT_LOCATIONS>()
                .Property(e => e.Dlocation)
                .IsUnicode(false);

            modelBuilder.Entity<EMP_DEPENDENT>()
                .Property(e => e.Essn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMP_DEPENDENT>()
                .Property(e => e.Dependent_name)
                .IsUnicode(false);

            modelBuilder.Entity<EMP_DEPENDENT>()
                .Property(e => e.Sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMP_DEPENDENT>()
                .Property(e => e.Relationship)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.Fname)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.Minit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.Lname)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.Ssn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.Emp_Address)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.Sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.Salary)
                .HasPrecision(10, 2);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.Super_ssn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PROJECT>()
                .Property(e => e.Pname)
                .IsUnicode(false);

            modelBuilder.Entity<PROJECT>()
                .Property(e => e.Plocation)
                .IsUnicode(false);

            modelBuilder.Entity<WORKS_ON>()
                .Property(e => e.Essn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WORKS_ON>()
                .Property(e => e.Emp_Hours)
                .HasPrecision(3, 1);
        }
    }
}
