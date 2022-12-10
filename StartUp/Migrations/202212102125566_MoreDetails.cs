namespace StartUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreDetails : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Attempts", new[] { "candidate_CandidateId" });
            DropIndex("dbo.Attempts", new[] { "certificate_CertificateId" });
            CreateTable(
                "dbo.CandidateDetails",
                c => new
                    {
                        DetailsId = c.Int(nullable: false, identity: true),
                        details = c.String(),
                    })
                .PrimaryKey(t => t.DetailsId);
            
            AddColumn("dbo.Candidates", "CandidateDetails_DetailsId", c => c.Int());
            CreateIndex("dbo.Attempts", "Candidate_CandidateId");
            CreateIndex("dbo.Attempts", "Certificate_CertificateId");
            CreateIndex("dbo.Candidates", "CandidateDetails_DetailsId");
            AddForeignKey("dbo.Candidates", "CandidateDetails_DetailsId", "dbo.CandidateDetails", "DetailsId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Candidates", "CandidateDetails_DetailsId", "dbo.CandidateDetails");
            DropIndex("dbo.Candidates", new[] { "CandidateDetails_DetailsId" });
            DropIndex("dbo.Attempts", new[] { "Certificate_CertificateId" });
            DropIndex("dbo.Attempts", new[] { "Candidate_CandidateId" });
            DropColumn("dbo.Candidates", "CandidateDetails_DetailsId");
            DropTable("dbo.CandidateDetails");
            CreateIndex("dbo.Attempts", "certificate_CertificateId");
            CreateIndex("dbo.Attempts", "candidate_CandidateId");
        }
    }
}
