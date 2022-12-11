using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.Models.CandidateFolder
{
    public class CandidateDetails
    {
        [ForeignKey("Candidate")]
        public int CandidateDetailsId { get; set; }

        public string details { get; set; }

        public virtual Candidate Candidate { get; set; }

        //[ForeignKey("GenderId")]
        public int GenderId { get; set; }
        public virtual Gender Gender { get; set; }




        public CandidateDetails(int candidateId,string details, int genderId)
        {
            this.CandidateDetailsId = candidateId;
            this.details = details;
            this.GenderId = genderId;

        }

        public CandidateDetails()
        {
        }

        public override string ToString()
        {
            return $"Candidate details of Id:{CandidateDetailsId} Details:{details} GenderId:{GenderId}";
        }

    }
}
