using System;
using StartUp.Services.DbInteractions;

namespace StartUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main starting...");




            //Create.CreateCandidate("Anastasios", "Alex", "Xiouras");
            //Create.CreateCandidate("Nikos", "", "Karas");
            //Create.CreateCandidate("Paulos", "", "Karas");
            //Db.CreateCandidate("Basilis", "", "Karas");

            Read.ReadAllCandidates();











            Console.WriteLine("The End");

        }
    }
}
