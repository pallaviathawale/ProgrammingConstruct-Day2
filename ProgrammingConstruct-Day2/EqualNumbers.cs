using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct_Day2
{
    public class EqualNumbers
    {
       public void EqaulNo()
        {
            int number1;
            int number2;
            Console.WriteLine("Enter first number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            number2 = Convert.ToInt32(Console.ReadLine());
            if(number1 == number2)
            {
                Console.WriteLine("Numbers are Equal");
            }
            else
            {
                Console.WriteLine("Numbers are not equal");
            }

        }
    }
}
