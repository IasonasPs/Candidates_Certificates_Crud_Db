using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.Models.CandidateFolder
{
    internal class CandidateDetails
    {
        public int DetailsId { get; set; }

        Candidate Candidate { get; set; }   


        public string details { get; set; }

        //Gender Gender { get; set; }




        public CandidateDetails()
        {

        }

    }
}
