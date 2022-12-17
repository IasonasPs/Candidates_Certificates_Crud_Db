using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPdf;
using StartUp.Services.Data;
using StartUp.Services.DbInteractions;
using UserInterface.Menus;

namespace UserInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main starting....");
            //AppDbContext app = new StartUp.Services.Data.AppDbContext();
            //AdminService.Admin(1);
            //CandidateService.CandidateUI(12);
            //------------------------------------------------------------------------------------

            //------------------------------------------------------------------------------------
            //CandidateService.ListOfCertificatesPdfCreation();
            MainMenu.GrandMenu();


            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Exiting main.......");
        }
    }
}
