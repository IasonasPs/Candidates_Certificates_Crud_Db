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
            
                //try
                //{
                //    string email = "iasonas.ps@gmail.com";
                //    Console.WriteLine($"The email is {email}");
                //    var mail = new MailAddress(email);
                //    bool isValidEmail = mail.Host.Contains(".");
                //    if (!isValidEmail)
                //    {
                //        Console.WriteLine($"The email is invalid");
                //    }
                //    else
                //    {
                //        Console.WriteLine($"The email is valid");
                //    }
                //    Console.ReadLine();
                //}
                //catch (Exception)
                //{
                //    Console.WriteLine($"The email is invalid");
                //    Console.ReadLine();
                //}
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



            //------------------------------------------------------------------------------------
            //------------------------------------------------------------------------------------
            //------------------------------------------------------------------------------------

            //Console.WriteLine("New Candidate Creation:");
            //Console.WriteLine("Type first Name:");
            //string fname = Console.ReadLine();
            //Console.WriteLine("Type middle Name:");
            //string mname = Console.ReadLine();
            //Console.WriteLine("Type last Name:");
            //string lname = Console.ReadLine();
            //int gender = 0;
            //do
            //{
            //    //int genderTest = 100;
            //    Console.WriteLine(" Type : 1 for Male , 2 for Female , 3 for Other");
            //    try
            //    {
            //        gender = int.Parse(Console.ReadLine());
            //    }
            //    catch (Exception e)
            //    {

            //        Console.WriteLine(e.Message);
            //        Console.WriteLine("Please follow the instructions  ");

            //    }

            //    } while (gender > 3 || gender <1);
            //Console.WriteLine("Type Native Language");
            //string nativeLanguage = Console.ReadLine();
            //------------------------------------------------------------------------------------
            //DateTime birthDate = DateTime.Now.Date;
            //do
            //{
            //    Console.WriteLine("Enter a birth date in the form of MM/DD/YY ");
            //    string input = Console.ReadLine();
            //    try
            //    {
            //        birthDate = DateTime.Parse(input).Date;
            //    }
            //    catch (Exception e)
            //    {

            //        Console.WriteLine(e.Message);
            //        Console.WriteLine("Please follow the instructions  ");
            //    }
            //    if (  birthDate > DateTime.Now.Date)
            //    {
            //        Console.WriteLine("This is a future date. \nPlease follow the instructions:");
            //    }

            //} while (birthDate == DateTime.Now.Date || birthDate> DateTime.Now.Date);

            //Console.WriteLine(birthDate);

            ////------------------------------------------------------------------------------------

            //Console.WriteLine("type Id Type");
            //string IdType = Console.ReadLine(); 

            //Console.WriteLine("Type  Id Number:");
            //int idnumber = int.Parse(Console.ReadLine());


            ////------------------------------------------------------------------------------------

            //DateTime idIssuedate = DateTime.Now.Date;
            //do
            //{
            //    Console.WriteLine("Enter an Id issue date in the form of MM/DD/YY ");
            //    string input = Console.ReadLine();
            //    try
            //    {
            //        idIssuedate = DateTime.Parse(input).Date;
            //    }
            //    catch (Exception e)
            //    {

            //        Console.WriteLine(e.Message);
            //        Console.WriteLine("Please follow the instructions  ");
            //    }
            //    if (idIssuedate > DateTime.Now.Date)
            //    {
            //        Console.WriteLine("This is a future date. \nPlease follow the instructions:");
            //    }
            //    else if(idIssuedate < new DateTime(1900,1,1))
            //    {
            //        Console.WriteLine("Please enter a date after 01/01/1900");
            //    }

            //} while (idIssuedate == DateTime.Now.Date || idIssuedate > DateTime.Now.Date || idIssuedate < new DateTime(1900, 1, 1));

            //Console.WriteLine(idIssuedate);

            ////-----------------------------------------------------------------------------------

                bool isValidEmail = false;
                string email = "";
            do
            {
                Console.WriteLine("Type an email address in the form of: text@example.text");
                  email = Console.ReadLine();
                try
                {

                    Console.WriteLine($"The email is {email}");
                    var mail = new MailAddress(email);
                     isValidEmail = mail.Host.Contains(".");
                    if (!isValidEmail)
                    {
                        Console.WriteLine($"The email is invalid");
                    }
                    else
                    {
                        Console.WriteLine($"The email is valid");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"The email is invalid");
                }
            } while (!isValidEmail);
            Console.WriteLine(email);













            Console.WriteLine("The End");



        }
    }
}
