using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StartUp.Models.CandidateFolder;
 
 

namespace StartUp.Models
{
    internal class Attempt
    {

        [Key]
        public int  MainId { get; set; }
             

        public string Comments { get; set; }

        public   Candidate  Candidate { get; set; }

        public Certificate Certificate { get; set; }

        
        public Attempt()
        {

        }



    }
}
