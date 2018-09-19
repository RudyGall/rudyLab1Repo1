using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rudyLab1Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dates();
            Console.ReadLine();
        }
        public static void Dates()
        {
            char checkD;
            bool runC = true;

            Console.WriteLine("Please enter a date: ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("You entered {0}, please enter another date: ", firstDate);
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("You entered {0} and {1}, " +
                "Shall we calculate the duration between the two dates? (Y or N)",
                firstDate, secondDate);

            checkD = Convert.ToChar(Console.ReadLine());

            TimeSpan diff = firstDate - secondDate;

            if (checkD != 'y' && checkD != 'Y')
            {
                runC = false;
                return;
            }
            else
                runC = true;

            while (runC == true)
            {
                Console.WriteLine("The span between your two dates is: " +
                    diff.TotalDays.ToString() + " Days, " +
                    diff.TotalHours.ToString() + " Hours, and " +
                    diff.TotalMinutes.ToString() + " Minutes.");
                return;
            }
        }
    }
}
