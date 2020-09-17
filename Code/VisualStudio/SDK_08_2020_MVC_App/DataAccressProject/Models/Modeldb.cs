namespace DataAccressProject.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Modeldb : DbContext
    {
        public Modeldb()
            : base("name=Modeldb")
        {
        }

        public virtual DbSet<AdminTable> AdminTables { get; set; }
        public virtual DbSet<CourseInfoTable> CourseInfoTables { get; set; }
        public virtual DbSet<CourseTokenByStudentTable> CourseTokenByStudentTables { get; set; }
        public virtual DbSet<StudentLoginInfo> StudentLoginInfoes { get; set; }
        public virtual DbSet<StudentTable> StudentTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
