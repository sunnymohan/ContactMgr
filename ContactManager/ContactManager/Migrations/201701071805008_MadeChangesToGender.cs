namespace ContactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeChangesToGender : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.People", "Gender_Id", "dbo.Genders");
            DropIndex("dbo.People", new[] { "Gender_Id" });
            RenameColumn(table: "dbo.People", name: "Gender_Id", newName: "GenderId");
            AlterColumn("dbo.People", "GenderId", c => c.Byte(nullable: false));
            CreateIndex("dbo.People", "GenderId");
            AddForeignKey("dbo.People", "GenderId", "dbo.Genders", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "GenderId", "dbo.Genders");
            DropIndex("dbo.People", new[] { "GenderId" });
            AlterColumn("dbo.People", "GenderId", c => c.Byte());
            RenameColumn(table: "dbo.People", name: "GenderId", newName: "Gender_Id");
            CreateIndex("dbo.People", "Gender_Id");
            AddForeignKey("dbo.People", "Gender_Id", "dbo.Genders", "Id");
        }
    }
}
