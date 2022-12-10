using StartUp.Models;
using StartUp.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.Services.DbInteractions
{
    internal class Update
    {
       static AppDbContext app = new AppDbContext();

        //---------------------------------------------------------------------------------
        //UpdateCandidate

        public static void UpdateCandidate(int Id, string fname, string mname, string lname)
        {
            Candidate candidate = app.Candidates.Find(Id);
            candidate.fName = fname;
            candidate.mName = mname;
            candidate.lName = lname;
            app.SaveChanges();
        }



    }
}
