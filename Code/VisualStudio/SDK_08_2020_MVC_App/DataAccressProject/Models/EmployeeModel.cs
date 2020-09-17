namespace DataAccressProject.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EmployeeModel : DbContext
    {
        public EmployeeModel()
            : base("name=EmployeeModel")
        {
        }

        public virtual DbSet<Employee_1> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
