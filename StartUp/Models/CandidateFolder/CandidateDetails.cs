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
        //--------------------------------------------------------
        public string NativeLanguage { get; set; }
        public DateTime BirthDate { get; set; }

        public int PhotoIdNumber { get; set; }

        public DateTime PhotoIdIssueDate { get; set; }

        public string Email { get; set; }   
        public string Address { get; set; }
        public string AlternateAddress { get; set; }

        public string CountryOfresidence { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public string LandlineNumber { get; set; }
        public string MobileNumber { get; set; }

        public CandidateDetails()
                {

                }

        public CandidateDetails(int candidateId,string details, int genderId)
        {
            this.CandidateDetailsId = candidateId;
            this.details = details;
            this.GenderId = genderId;

        }

        public CandidateDetails(int candidateDetailsId, int genderId, string nativeLanguage, DateTime birthDate,
            int photoIdNumber,DateTime photoIdIssueDate, string email, string address, string alternateAddress, 
            string countryOfresidence, string state, string city, int postalCode, string landlineNumber, string mobileNumber)
        {
            CandidateDetailsId = candidateDetailsId;
            GenderId = genderId;
            NativeLanguage = nativeLanguage;
            BirthDate = birthDate;
            PhotoIdNumber = photoIdNumber;
            PhotoIdIssueDate = photoIdIssueDate;
            Email = email;
            Address = address;
            AlternateAddress = alternateAddress;
            CountryOfresidence = countryOfresidence;
            State = state;
            City = city;
            PostalCode = postalCode;
            LandlineNumber = landlineNumber;
            MobileNumber = mobileNumber;
        }

        public override string ToString()
        {
            return $"Candidate details of Id:{CandidateDetailsId} Details:{details} GenderId:{GenderId}";
        }






    }
}
