using System;
using System.Linq;
using System.Net.Mail;
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

            //AppDbContext app = new AppDbContext();


            //Gender.GenderMaker();

            //app.CandidateDetails.Add(new CandidateDetails());

            //var can = app.Candidates.Add(new Candidate("Nikos", "Petras"));

            //app.CandidateDetails.Add(new CandidateDetails(can.CandidateId, "Petras", 1));
            //app.SaveChanges();

            //Console.WriteLine("middle");


            //------------------------------------------------------------------------------------
            //DateTime
            //Console.WriteLine("Enter birth date in the form :12/28/1999  ");
            //var input = Console.ReadLine();
            //DateTime inputd = DateTime.Parse(input);
            //Console.WriteLine(input);


            Console.WriteLine("----");
            //Console.ReadKey();
            Console.WriteLine("----");

            //DateTime date1 = new DateTime(2015, 12, 25);
            //Console.WriteLine(date1.ToString()); // 12/25/2015 12:00:00 AM    

            //------------------------------------------------------------------------------------
            //------------------------------------------------------------------------------------
            // Email Validation
            
                try
                {
                    string email = "iasonas.ps@gmail.com";
                    Console.WriteLine($"The email is {email}");
                    var mail = new MailAddress(email);
                    bool isValidEmail = mail.Host.Contains(".");
                    if (!isValidEmail)
                    {
                        Console.WriteLine($"The email is invalid");
                    }
                    else
                    {
                        Console.WriteLine($"The email is valid");
                    }
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine($"The email is invalid");
                    Console.ReadLine();
                }
            //------------------------------------------------------------------------------------
            //------------------------------------------------------------------------------------







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
            //Read.ReadAllCandidates();
            Console.WriteLine("The End");

        }
    }
}
