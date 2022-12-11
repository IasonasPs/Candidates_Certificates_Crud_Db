using StartUp.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StartUp.Models.CandidateFolder;

namespace StartUp.Services.DbInteractions
{
    internal   class Create
    {
        static   AppDbContext app = new AppDbContext();

         

        public static void CreateCandidate(string fName, string lName)
        {
            app.Candidates.Add(new  Candidate(fName, lName));
            app.SaveChanges();
        }

        public static void CreateCandidate(string fName, string mName, string lName)
        {
            app.Candidates.Add(new  Candidate(fName, mName, lName));
            app.SaveChanges();
        }

        public static void CreateCandidate(string fName, string mName, string lName, int gender, string
                                           nativeLanguage, DateTime birthdate,string Idtype, int idnumber, DateTime IdIssueDate, 
                                            string email,string address,string alternateAddress , 
                                            string countryOfresidence , string state , string city , int postalCode , string landlineNumber , string mobileNumber)
        {

            

             
            var candidate = app.Candidates.Add(new Candidate(fName, mName, lName));

            app.CandidateDetails.Add(
                new CandidateDetails(candidate.CandidateId,gender,nativeLanguage,
                                     birthdate,Idtype,idnumber, IdIssueDate , email,address, alternateAddress , 
                                     countryOfresidence , state ,city , postalCode , landlineNumber ,mobileNumber)
                );
               
            app.SaveChanges();



        }

    }
}
