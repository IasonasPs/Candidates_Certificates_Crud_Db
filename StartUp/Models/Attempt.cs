using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StartUp.Models.CandidateFolder;
using StartUp.Services.Data;

namespace StartUp.Models
{
    public class Attempt
    {
        AppDbContext app  = new AppDbContext();

        [Key]
        public int  MainId { get; set; }
             
        //Ebgala ena property comment pou eixe edo

        public Candidate  Candidate { get; set; }

        public Certificate Certificate { get; set; }

        public DateTime ExamDate { get; set; }

        private int _candidateScore ;
        public int CandidateScore
        {
            get { return _candidateScore; }
            private set { _candidateScore = app.Scores.Where(x => x.ScoresId == MainId).SingleOrDefault().sum; }
        }

        internal Scores Scores { get; set; }
        
        public Attempt()
        {

        }

       
    }





    public class Scores
    {
        [ForeignKey("Attempt")]
        public int ScoresId { get; set; }
        public Attempt Attempt { get; set; }

        public int score1 { get; set; }
        public int score2 { get; set; }
        public int score3 { get; set; }
        public int score4 { get; set; }

        private int _sum;
        public int sum
        {
            get { return _sum; }
            private set { _sum = score1 + score2 + score3 + score4; }
        }

        public Scores(int score1, int score2, int score3, int score4)
        {

            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
            this.score4 = score4;

        }

        public Scores()
        {

        }

    }

}
