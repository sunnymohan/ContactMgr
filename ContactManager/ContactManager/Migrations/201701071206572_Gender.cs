namespace ContactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gender : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        GenderType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.People", "Gender_Id", c => c.Byte());
            CreateIndex("dbo.People", "Gender_Id");
            AddForeignKey("dbo.People", "Gender_Id", "dbo.Genders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Gender_Id", "dbo.Genders");
            DropIndex("dbo.People", new[] { "Gender_Id" });
            DropColumn("dbo.People", "Gender_Id");
            DropTable("dbo.Genders");
        }
    }
}
