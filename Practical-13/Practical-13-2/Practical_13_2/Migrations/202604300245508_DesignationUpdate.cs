namespace Practical_13_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignationUpdate : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Employee", new[] { "DesignationId" });
            AlterColumn("dbo.Employee", "DesignationId", c => c.Int());
            CreateIndex("dbo.Employee", "DesignationId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Employee", new[] { "DesignationId" });
            AlterColumn("dbo.Employee", "DesignationId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employee", "DesignationId");
        }
    }
}
