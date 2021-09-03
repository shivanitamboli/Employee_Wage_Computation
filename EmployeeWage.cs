using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class EmployeeWage
    {

        static void Main(string[] args)
        {
           Console.WriteLine("Welcome To Employee Aage Computation Problem");

            int IS_PART_Time= 1;
            int IS_FULL_Time = 2;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;


            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_Time)
            {
                empHrs = 4;
                Console.WriteLine("Employee is parttime");

            }
            else if (empCheck == IS_FULL_Time)
            {
                empHrs = 8;
                Console.WriteLine("Employee is fulltime");

            }

            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is absent");

            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("emp wage:" + empWage);
            Console.ReadLine();


        }
    }
}
