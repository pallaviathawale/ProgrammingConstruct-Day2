using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct_Day2
{
    internal class EligibilityForAdmission
    {
        public void CheckEligibility()
        {
            int Marks_In_Maths;
            int Marks_in_Physics;
            int Marks_in_Chemistry;

            Console.WriteLine("Marks obtained in Maths");
            Marks_In_Maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Marks obtained in Physics");
            Marks_in_Physics = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Marks obtained  in Chemistry");
            Marks_in_Chemistry = Convert.ToInt32(Console.ReadLine());   

            if(Marks_In_Maths >= 65 && Marks_in_Physics >= 55 && Marks_in_Chemistry >= 50 && (Marks_In_Maths + Marks_in_Physics + Marks_in_Chemistry) >= 180)
            {
                Console.WriteLine("The Candidate is Eligibile for Admission");
            }
            else if(Marks_In_Maths >= 65 && (Marks_in_Physics >= 55 || Marks_in_Chemistry >= 50) && (Marks_In_Maths + (Marks_in_Physics >= 55 ? Marks_in_Physics : Marks_in_Chemistry)) >= 140)
            {
                Console.WriteLine("The Candidate is Eligibile for Admission");

            }
            else
            {
                Console.WriteLine("The Candidate is not  Eligibile for Admission");

            }
        }

    }
}
