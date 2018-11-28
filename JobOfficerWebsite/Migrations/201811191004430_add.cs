namespace JobOfficerWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Jobs", "category_Id", "dbo.Categories");
            DropIndex("dbo.Jobs", new[] { "category_Id" });
            DropColumn("dbo.Jobs", "catId");
            RenameColumn(table: "dbo.Jobs", name: "category_Id", newName: "catId");
            AlterColumn("dbo.Jobs", "catId", c => c.Int(nullable: false));
            CreateIndex("dbo.Jobs", "catId");
            AddForeignKey("dbo.Jobs", "catId", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jobs", "catId", "dbo.Categories");
            DropIndex("dbo.Jobs", new[] { "catId" });
            AlterColumn("dbo.Jobs", "catId", c => c.Int());
            RenameColumn(table: "dbo.Jobs", name: "catId", newName: "category_Id");
            AddColumn("dbo.Jobs", "catId", c => c.Int(nullable: false));
            CreateIndex("dbo.Jobs", "category_Id");
            AddForeignKey("dbo.Jobs", "category_Id", "dbo.Categories", "Id");
        }
    }
}
