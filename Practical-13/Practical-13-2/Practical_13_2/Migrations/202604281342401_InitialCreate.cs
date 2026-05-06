namespace Practical_13_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Designation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Designation = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50, unicode: false),
                        MiddleName = c.String(maxLength: 50, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 50, unicode: false),
                        DOB = c.DateTime(nullable: false, storeType: "date"),
                        MobileNumber = c.String(nullable: false, maxLength: 10, unicode: false),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Address = c.String(maxLength: 100, unicode: false),
                        DesignationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Designation", t => t.DesignationId)
                .Index(t => t.DesignationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "DesignationId", "dbo.Designation");
            DropIndex("dbo.Employee", new[] { "DesignationId" });
            DropTable("dbo.Employee");
            DropTable("dbo.Designation");
        }
    }
}
