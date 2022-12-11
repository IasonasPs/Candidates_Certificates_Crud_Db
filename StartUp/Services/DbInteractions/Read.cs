using StartUp.Models.CandidateFolder;
using StartUp.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.Services.DbInteractions
{
    internal class Read
    {
         static AppDbContext app = new AppDbContext();

        //---------------------------------------------------------------------------------
        //ReadCandidate

        public static void ReadAllCandidates()
        {
            var myList = app.Candidates.ToList();
            foreach (var item in myList)
            {
                Console.WriteLine(item);
                var details = app.CandidateDetails.Where(x => x.CandidateDetailsId == item.CandidateId).SingleOrDefault();
                Console.WriteLine(details);
                Console.WriteLine("- - - - - -  - - - - -");
            }            
        }

        public static void SearchCandidateById(int Id)
        {
            try
            {
                var candidate = app.Candidates.Where(x => x.CandidateId == Id).Single();
                Console.WriteLine(candidate);
                var details = app.CandidateDetails.Where(x => x.CandidateDetailsId == candidate.CandidateId).Single();
                Console.WriteLine(details);
            }
            catch (Exception e)
            {
                Console.WriteLine($"There is no Candidate with Id={Id}");
                Console.WriteLine(e.Message);
            }
        }

        //public static void SearchCandidateBylName(string lName)
        //{
        //    try
        //    { 
        //             var candidate = app.Candidates.Where(x => x.lName == lName).SingleOrDefault();
        //            Console.WriteLine(candidate);
                       
                    
        //            var details = app.CandidateDetails.Where(x => x.CandidateDetailsId == candidate.CandidateId).SingleOrDefault();
        //            Console.WriteLine(details); 
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("----------------");
        //        //Console.WriteLine(e.Message);
        //        Console.WriteLine("There are more than one Candidates with this last name");
        //        Console.WriteLine("----------------");
        //        Console.WriteLine("Please enter the first name of the desired candidate:");
        //        Console.WriteLine("----------------");

        //        string fname = Console.ReadLine();
        //        List<Candidate> list = app.Candidates.Where(x => x.lName == lName).ToList<Candidate>();


        //        foreach (var item in list)
        //        {
        //            if (item.fName == fname)
        //            {
        //                Console.WriteLine(item);
        //            }

        //        }

                 
        //    }
        //}


    }
}
