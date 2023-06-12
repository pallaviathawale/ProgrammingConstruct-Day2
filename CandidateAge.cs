using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct_Day2
{
    internal class CandidateAge
    {
        public void VoteCast()
        {
            int age;
            Console.WriteLine("Enter Age of Candidate to check...");
            age = Convert.ToInt32(Console.ReadLine());
            if(age >=18)
            {
                Console.WriteLine("Candidate is eligibile for casting his/her vote");

            }
            else
            {
                Console.WriteLine("Candidate is not elibile for casting his/her vote");

            }
        }
    }
}
