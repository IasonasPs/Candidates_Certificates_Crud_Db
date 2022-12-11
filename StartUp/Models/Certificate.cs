using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.Models
{
    internal class Certificate
    {
        public int CertificateId { get; set; }

        public string Title { get; set; }

        //public int AssessmentTestCode { get; set; }

        public string TopicDescription { get; set; }


        public Certificate()
        {

        }

        public Certificate(  string title,  string topicDescription)
        {
            
            Title = title;
            //AssessmentTestCode = assessmentTestCode;
            TopicDescription = topicDescription;
        }


        public override string ToString()
        {
            return $"{Title}\nDescription:{TopicDescription}\n-----------------------\n ";
        }
    }





    public class Scores
    {
        [ForeignKey("Attempt")]
        public int ScoresId { get; set; }
        public int score1 { get; set; }
        public int score2 { get; set; }
        public int score3 { get; set; }
        public int score4 { get; set; }

        public int sum 
        {
            get { return sum=score1+score2+score3+score4; }
            set {  } 
        }

        public Scores( int score1, int score2, int score3, int score4)
        {
            
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
            this.score4 = score4;
            
        }
    }


}
