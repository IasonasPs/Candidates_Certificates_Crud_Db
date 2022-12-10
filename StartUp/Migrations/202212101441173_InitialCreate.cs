namespace StartUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attempts",
                c => new
                    {
                        MainId = c.Int(nullable: false, identity: true),
                        Comments = c.String(),
                        candidate_CandidateId = c.Int(),
                        certificate_CertificateId = c.Int(),
                    })
                .PrimaryKey(t => t.MainId)
                .ForeignKey("dbo.Candidates", t => t.candidate_CandidateId)
                .ForeignKey("dbo.Certificates", t => t.certificate_CertificateId)
                .Index(t => t.candidate_CandidateId)
                .Index(t => t.certificate_CertificateId);
            
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        CandidateId = c.Int(nullable: false, identity: true),
                        fName = c.String(),
                        mName = c.String(),
                        lName = c.String(),
                    })
                .PrimaryKey(t => t.CandidateId);
            
            CreateTable(
                "dbo.Certificates",
                c => new
                    {
                        CertificateId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.CertificateId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attempts", "certificate_CertificateId", "dbo.Certificates");
            DropForeignKey("dbo.Attempts", "candidate_CandidateId", "dbo.Candidates");
            DropIndex("dbo.Attempts", new[] { "certificate_CertificateId" });
            DropIndex("dbo.Attempts", new[] { "candidate_CandidateId" });
            DropTable("dbo.Certificates");
            DropTable("dbo.Candidates");
            DropTable("dbo.Attempts");
        }
    }
}
