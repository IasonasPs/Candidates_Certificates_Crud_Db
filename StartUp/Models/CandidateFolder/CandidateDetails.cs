using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.Models.CandidateFolder
{
    internal class CandidateDetails
    {
        [Key]
        public int DetailsId { get; set; }


        public string details { get; set; }

        Gender Gender { get; set; }




        public CandidateDetails()
        {

        }

    }
}
