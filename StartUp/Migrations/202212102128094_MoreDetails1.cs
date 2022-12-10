namespace StartUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreDetails1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        GenderId = c.Int(nullable: false, identity: true),
                        GenderName = c.String(),
                    })
                .PrimaryKey(t => t.GenderId);
            
            AddColumn("dbo.CandidateDetails", "Gender_GenderId", c => c.Int());
            CreateIndex("dbo.CandidateDetails", "Gender_GenderId");
            AddForeignKey("dbo.CandidateDetails", "Gender_GenderId", "dbo.Genders", "GenderId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CandidateDetails", "Gender_GenderId", "dbo.Genders");
            DropIndex("dbo.CandidateDetails", new[] { "Gender_GenderId" });
            DropColumn("dbo.CandidateDetails", "Gender_GenderId");
            DropTable("dbo.Genders");
        }
    }
}
