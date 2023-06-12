using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct_Day2
{
    internal class WeekDaysName
    {
        public void WeekDays()
        {

            Console.WriteLine("Enter WeekDays NUmber");
            int WeekDaysNumber = Convert.ToInt32(Console.ReadLine());

           static string GetWeekDayNames(int WeekDaysNumber)
            {

                switch (WeekDaysNumber)
                {
                    case 1:
                        return "Monday";
                        break;
                    case 2:
                        return "Tuesday";
                        break;
                    case 3:
                        return "wednesday";
                        break;
                    case 4:
                        return "thursday";
                        break;
                    case 5:
                        return "friday";
                        break;
                    case 6:
                        return "saturday";
                        break;
                    case 7:
                        return "sunday";
                        break;
                    default:
                        return "invalid number";





                }

            }

        }
    }
}
