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
            
            Console.WriteLine("------------------------");

            var x =context.Scores.Add(new Scores(20, 20, 20, 20));
            var y = context.Entry(x).Entity.sum;
            var z =context.Attempts.Add(new Attempt(1, 2, new DateTime(2019, 12, 19),y,7));
            context.SaveChanges();

            Console.WriteLine("------------------------");
            

            //--------------------------------------------------------------------------------------------------------
          

            Console.WriteLine("The End");



            //Create.TotalCandidateCreation();
        }

      
    }
}
