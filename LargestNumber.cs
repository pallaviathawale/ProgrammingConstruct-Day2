using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct_Day2
{
    internal class LargestNumber
    {
        public void FindLargestNumber()
        {
            int num1;
            int num2;
            int num3;
            Console.WriteLine("Enter first number");
            num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            num2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            num3 = Convert.ToInt32(Console.ReadLine());
            int largest = num1;
            if(num2 > largest)
            {
                largest = num2;
            }
            else if(num3 > largest)
            {
                largest=num3;
            }
            //else if (largest == 0)
            //{

            //}
            Console.WriteLine("Largest number is "+ largest);
            Console.ReadLine();

        }
    }
}
