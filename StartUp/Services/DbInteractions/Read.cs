using StartUp.Models;
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
            app.Candidates.ToList().ForEach(c => Console.WriteLine(c));

        }
        public static void SearchCandidateById(int Id)
        {
            try
            {
                Console.WriteLine(app.Candidates.Where(x => x.CandidateId == Id).Single());
            }
            catch (Exception e)
            {
                Console.WriteLine($"There is no Candidate with Id={Id}");
                Console.WriteLine(e.Message);
            }
        }
        public static void SearchCandidateBylName(string lName)
        {
            try
            {
                Console.WriteLine(app.Candidates.Where(x => x.lName == lName).SingleOrDefault());
            }
            catch (Exception e)
            {
                Console.WriteLine("----------------");
                //Console.WriteLine(e.Message);
                Console.WriteLine("There are more than one Candidates with this last name");
                Console.WriteLine("----------------");
                Console.WriteLine("Please enter the first name of the desired candidate:");
                Console.WriteLine("----------------");
                List<Candidate> list = app.Candidates.Where(x => x.lName == lName).ToList<Candidate>();

                string fname = Console.ReadLine();

                foreach (var item in list)
                {
                    if (item.fName == fname)
                    {
                        Console.WriteLine(item);
                    }

                }


                //app.Candidates.Where(x => x.lName == lName).SingleOrDefault())

            }
        }


    }
}
