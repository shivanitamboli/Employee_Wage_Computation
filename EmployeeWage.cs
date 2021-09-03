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

            int ISPresent = 1;

            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == ISPresent)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is Absent");
            Console.ReadLine();

        }
    }
}
