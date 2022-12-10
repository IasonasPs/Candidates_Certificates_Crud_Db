using StartUp.Services.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.Models.CandidateFolder
{
    internal class Gender
    {
        public int GenderId { get; set; }

        public string GenderName { get; set; }

         static AppDbContext app = new AppDbContext();

        public Gender(string genderName)
        {
            this.GenderName = genderName;
        }
        
        //Gender male = new Gender("Male");
        //Gender female = new Gender("female");
        //Gender other = new Gender("other");

        public static void GenderMaker()
        {
            app.Genders.Add(new Gender("Male"));
            app.Genders.Add( new Gender("Female"));
            app.Genders.Add( new Gender("Other"));
            app.SaveChanges();
        }
    }
}
