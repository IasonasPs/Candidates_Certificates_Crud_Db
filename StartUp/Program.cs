using System;
using System.Linq;
using System.Net.Mail;
using StartUp.Models.CandidateFolder;
using StartUp.Services.Data;
using StartUp.Services.DbInteractions;
using StartUp.Models;
using System.Runtime.Remoting.Contexts;

namespace StartUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main starting...");

            AppDbContext context = new AppDbContext();
            //Gender.GenderMaker();

            
            //----------------
            //Sample Certificates
           
            //----------------


           
            Console.WriteLine("------------------------");


            //context.Candidates.Add(new Candidate("alex", "Michalis", "Kazantzakis"));
            //context.SaveChanges();

            Read.SearchCandidateByLastName("Kazantzakis");



            Console.WriteLine("------------------------");

             

            //--------------------------------------------------------------------------------------------------------
          ;

            Console.WriteLine("The End");



            //Create.TotalCandidateCreation();
        }

      
    }
}
