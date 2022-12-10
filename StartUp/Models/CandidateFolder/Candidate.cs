﻿using StartUp.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.Models.CandidateFolder
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string fName { get; set; }
        public string mName { get; set; }   
        public string lName { get; set; }

        //CandidateDetails candidateDetails { get; set; }


    




        public Candidate()
        {

        }

        public Candidate(string fName, string mName, string lName)
        {
            this.fName = fName;
            this.mName = mName;
            this.lName = lName;
        }

        public Candidate(string fName, string lName)
        {
            this.fName = fName;
            this.lName = lName;
            //Console.WriteLine("inside ctor");
            //Console.WriteLine(this);
            //app.Candidates.Add(this);
            //app.SaveChanges();
        }













        public override string ToString() 
        {
            return $"Candidate's name is {fName} {lName}." ;
            
        }
    }
}