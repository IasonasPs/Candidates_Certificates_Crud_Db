using System;
using System.Linq;
using StartUp.Models.CandidateFolder;
using StartUp.Services.Data;
using StartUp.Services.DbInteractions;

namespace StartUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main starting...");

            AppDbContext app = new AppDbContext();


            //Gender.GenderMaker();

            //app.CandidateDetails.Add(new CandidateDetails());

            //var can = app.Candidates.Add(new Candidate("Nikos", "Petras"));

            //app.CandidateDetails.Add(new CandidateDetails(can.CandidateId, "Petras", 1));
            //app.SaveChanges();

            //Console.WriteLine("middle");











            //var candidate = app.Candidates.Where(c => c.lName == "Petras").SingleOrDefault();
            //Console.WriteLine("________________");
            //Console.WriteLine(petras.CandidateId);
            //Console.WriteLine("________________");
            //var details = app.CandidateDetails.Where(c => c.CandidateDetailsId == petras.CandidateId).SingleOrDefault();
            //Console.WriteLine(details.ToString());
            //Console.WriteLine("________________");

            //Console.WriteLine("after petras");
            //var gender = app.Genders.Where(x => x.GenderId == details.GenderId).SingleOrDefault();
            //Console.WriteLine(gender);

            //Console.WriteLine("________________");

             

            Console.WriteLine("------------------------");
            Read.ReadAllCandidates();
            Console.WriteLine("The End");

        }
    }
}
