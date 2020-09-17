using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace SDK_08_2020_MVC_App.Models
{
    public partial class StudentContext2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentTable",
                s => new
                {
                    id = s.Int(nullable: false, identity: true),
                    Name = s.String(),
                    Age = s.String()
                }
                )
                .PrimaryKey(pk => pk.id);
        }

        public override void Down()
        {
            DropTable("dbo.StudentTable");
        }
    }
}