using StartUp.Models;
using StartUp.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StartUp.Services.DbInteractions
{
    internal class Delete
    {

        static AppDbContext app = new AppDbContext();



        //---------------------------------------------------------------------------------
        //DeleteCandidate
        public static void DeleteCandidate(int Id)
        {

            app.Candidates.Remove(app.Candidates.Find(Id));
            app.CandidateDetails.Remove(app.CandidateDetails.Find(Id));
            Console.WriteLine($"This Candidate was delete :{app.Candidates.Remove(app.Candidates.Find(Id))}");
            app.SaveChanges();
        }




    }
}
