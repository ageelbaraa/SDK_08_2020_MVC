namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberShipTypes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberShipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "MemberShipTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "MemberShipTypes_Id", c => c.Byte());
            CreateIndex("dbo.Customers", "MemberShipTypes_Id");
            AddForeignKey("dbo.Customers", "MemberShipTypes_Id", "dbo.MemberShipTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberShipTypes_Id", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MemberShipTypes_Id" });
            DropColumn("dbo.Customers", "MemberShipTypes_Id");
            DropColumn("dbo.Customers", "MemberShipTypeId");
            DropTable("dbo.MemberShipTypes");
        }
    }
}
