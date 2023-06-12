using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct_Day2
{
    internal class NumberEvenOdd
    {
        public void EvenOdd()
        {
            int number1;
            Console.WriteLine("Enter a number");
            number1 = Convert.ToInt32(Console.ReadLine());
            if (number1 % 2 ==0)
            {
                Console.WriteLine("Number is even");

            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
    }
}
