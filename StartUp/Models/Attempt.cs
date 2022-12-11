using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StartUp.Models.CandidateFolder;
 
 

namespace StartUp.Models
{
    public class Attempt
    {

        [Key]
        public int  MainId { get; set; }
             

        public string Comments { get; set; }

        public   Candidate  Candidate { get; set; }

        internal Certificate Certificate { get; set; }

        internal Scores Scores { get; set; }
        
        public Attempt()
        {

        }



    }
}
