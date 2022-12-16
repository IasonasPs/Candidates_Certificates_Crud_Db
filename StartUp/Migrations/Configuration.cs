namespace StartUp.Migrations
{
    using StartUp.Models;
    using StartUp.Models.CandidateFolder;

    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using static System.Net.Mime.MediaTypeNames;

    internal sealed class Configuration : DbMigrationsConfiguration<StartUp.Services.Data.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "StartUp.Services.Data.AppDbContext";
        }

        protected override void Seed(StartUp.Services.Data.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //-------------------------------------------------------------------------------------------------------- 
            //--------------------------------Certificates-----------------------------------------------------------------

            if (context.Certificates.Where(c => c.Title == "SoftwareDevelopmentSkills: Foundation").Count() == 0 &&
                context.Certificates.Where(c => c.Title == "SoftwareDevelopmentSkills: Advanced").Count() == 0 &&
                context.Certificates.Where(c => c.Title == "MolecularGastronomy: Foundation").Count() == 0 &&
                context.Certificates.Where(c => c.Title == "MolecularGastronomy: Advanced").Count() == 0 &&
                context.Certificates.Where(c => c.Title == "Rocket Science for dummies:Foundation").Count() == 0 &&
                context.Certificates.Where(c => c.Title == "Quantum programming in Q# : Foundation").Count() == 0 
                )
            {
                context.Certificates.Add(new Models.Certificate("SoftwareDevelopmentSkills: Foundation", "C# and stuff like that"));
                context.Certificates.Add(new Models.Certificate("SoftwareDevelopmentSkills: Advanced", "More C# and more of everything IT"));
                context.Certificates.Add(new Models.Certificate("MolecularGastronomy: Foundation", "Chemistry of Cooking and more chemistry"));
                context.Certificates.Add(new Models.Certificate("MolecularGastronomy: Advanced", "Some chemistry... more cooking"));
                context.Certificates.Add(new Models.Certificate("Rocket Science for dummies:Foundation", "Safe rocket-making for Greek eastern"));
                context.Certificates.Add(new Models.Certificate("Quantum programming in Q# : Foundation", "No comments")); 
            }
            //-------------------------------------------------------------------------------------------------------- 
            //--------------------------------GENDERS-----------------------------------------------------------------
            if (context.Genders.Where(g => g.GenderName == "Male").Count() == 0 && context.Genders.Where(g => g.GenderName == "Female").Count() == 0 
                && context.Genders.Where(g => g.GenderName == "Other").Count() == 0)
            {
                context.Genders.Add(new Gender("Male"));
                context.Genders.Add(new Gender("Female"));
                context.Genders.Add(new Gender("Other"));
                context.SaveChanges(); 
            }
            //---------------------------CANDIDATES-----AND------DETAILS----------------------------------------------
            if (context.Candidates.Where(c => c.lName == "Petras").Count() == 0 &&
                context.Candidates.Where(c => c.lName == "Kazantzakis").Count() == 0 &&
                context.Candidates.Where(c => c.lName == "Zorbas").Count() == 0 &&
                context.Candidates.Where(c => c.lName == "Papadopoulou").Count() == 0)
            {
            //--------------------------------------------------------------------------------------------------------PETRAS
                context.Candidates.Add(new Candidate("Petros", "Petrou", "Petras"));
            context.SaveChanges();
            var x1 = context.Candidates.Where(c => c.lName == "Petras").FirstOrDefault().CandidateId;
            context.CandidateDetails.Add(new CandidateDetails(x1, 1, "Greek", DateTime.Parse("12 / 12 / 1980").Date, "Passport", 1278, DateTime.Parse("12 / 12 / 2001").Date,
            "petras@gmail.com", "Petralonon 3", "", "Greece", "Attica", "Petralona", 67543, "21098765", "69087654"));
            context.SaveChanges();
            //--------------------------------------------------------------------------------------------------------KAZANTZAKIS
            context.Candidates.Add(new Candidate("Nikos", "Michalis", "Kazantzakis"));
            context.SaveChanges();
            var y = context.Candidates.Where(c => c.lName == "Kazantzakis").FirstOrDefault().CandidateId;
            context.CandidateDetails.Add(new CandidateDetails(y, 1, "Greek", DateTime.Parse("02 / 18 / 1883").Date, "Passport", 09987, DateTime.Parse("02 / 12 / 1934").Date,
              "nikos@gmail.com", "Vasilisis Sofias 280", "Hrakliou 4", "Greece", "Attica", "Kolonaki", 78654, "2108967546", "-----------"));
            context.SaveChanges();
            //--------------------------------------------------------------------------------------------------------Zorbas
            context.Candidates.Add(new Candidate("Alexis", "Michalis", "Zorbas"));
            context.SaveChanges();
            var z = context.Candidates.Where(c => c.lName == "Zorbas").FirstOrDefault().CandidateId;
            context.CandidateDetails.Add(new CandidateDetails(z, 1, "Greek", DateTime.Parse("07 / 22 / 1899").Date, "Passport", 09654, DateTime.Parse("05 / 18 / 1922").Date,
              "alexis@gmail.com", "Hraklia", "Tinos", "Greece", "Hraklia", "Hraklia", 12987, "2265398765", "6956789438"));
            context.SaveChanges();
            //--------------------------------------------------------------------------------------------------------PAPADOPOULOU
            context.Candidates.Add(new Candidate("Miranda", "Nikos", "Papadopoulou"));
            context.SaveChanges();
            var e = context.Candidates.Where(c => c.lName == "Papadopoulou").FirstOrDefault().CandidateId;
            context.CandidateDetails.Add(new CandidateDetails(e, 2, "Greek", DateTime.Parse("06/ 21 / 1997").Date, "Passport", 172834, DateTime.Parse("03 / 07 / 2008").Date,
              "miranda@gmail.com", "Psaron 27", "Andrianou 12", "Greece", "Attica", "Korydallos", 82345, "2106844697", "6940102588"));
            context.SaveChanges();
            }
            //-------------------------------------------------------------------------------------------------------- 
            //-----------------------------------ATTEMPTS------------------------------------------------------------- 
            //-------------------------------------------------------------------------------------------------------- 
            //--PETRAS------------------------------------------------------------------------------------------------
            //var q = context.Scores.Add(new Models.Scores(20, 20, 20, 20));
            //var w = context.Entry(q).Entity.sum;
            //var r = context.Attempts.Add(new Attempt(7, 1, new DateTime(2019, 12, 19), w));
            //context.SaveChanges();
            //var q1 = context.Scores.Add(new Models.Scores(20, 20, 0, 0));
            //var w1 = context.Entry(q1).Entity.sum;
            //var r1 = context.Attempts.Add(new Attempt(7, 2, new DateTime(2020, 1, 19), w1));
            //context.SaveChanges();







        }
    }
}
