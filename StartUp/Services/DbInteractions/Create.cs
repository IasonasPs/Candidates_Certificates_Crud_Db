﻿using StartUp.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.Services.DbInteractions
{
    internal   class Create
    {
        static   AppDbContext app = new AppDbContext();





        public static void CreateCandidate(string fName, string mName, string lName)
        {
            app.Candidates.Add(new Models.Candidate(fName, mName, lName));
            app.SaveChanges();
        }
        public static void CreateCandidate(string fName, string lName)
        {
            app.Candidates.Add(new Models.Candidate(fName, lName));
            app.SaveChanges();
        }
 


    }
}