using System;
using System.Linq;
using System.Net.Mail;
using StartUp.Models.CandidateFolder;
using StartUp.Services.Data;
using StartUp.Services.DbInteractions;
using StartUp.Models;

namespace StartUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main starting...");

            //AppDbContext app = new AppDbContext();
            //Gender.GenderMaker();

            //Sample Candidates
            //DateTime test = new DateTime(2000, 1, 1);
            //Create.CreateCandidate("BAbis", "Sougias");
            //Create.CreateCandidate("petros", "P", "Petras", 1, "english", test, "Passport", 1220, test, "Petros@hotmmail.gr", "", "", "Greek", "Attica", "Athens",82100,"","");
            //----------------
            //Sample Certificates
            //Create.CreateCertificate("SoftwareDevelopmentSkills: Foundation", "C# and stuff like that");
            //Create.CreateCertificate("SoftwareDevelopmentSkills: Advanced", "More C# and more of everything IT");
            //Create.CreateCertificate("MolecularGastronomy: Foundation", "Chemistry of Cooking and more chemistry");
            //Create.CreateCertificate("MolecularGastronomy: Advanced", "Some chemistry..  more cooking");
            //Create.CreateCertificate("Rocket Science for dummies:foundation", "Safe rocket making for eastern");
            //Create.CreateCertificate("Quantum programming in Q# : Foundation ", "No comments");
            //----------------


            Scores score = new Scores(10, 10, 10, 10);

            Console.WriteLine(score.sum);







            Console.WriteLine("------------------------");
           
            

          


            Console.WriteLine("The End");



            //Create.TotalCandidateCreation();
        }

      
    }
}
