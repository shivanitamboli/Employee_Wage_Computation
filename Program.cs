using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class Program
    {
       
            public static final int FULL_TIME = 1;
            public static final int PART_TIME = 2;
            public static final int EMP_WAGE_PER_HOUR = 20;
            public static final int NUM_OF_WORKING_DAY = 20;

            public static void main(String[] args)
            {
                System.out.println("Welcome to Employee Wage");
                int empHrs = 0, calcwage = 0, totalEmpWage = 0;

                //Computation
                for (int day = 0; day < NUM_OF_WORKING_DAY; day++)
                {
                    int empCheck = (int)Math.floor(Math.random() * 10) % 3;
                    switch (empCheck)
                    {
                        case PART_TIME:
                            empHrs = 4;
                            break;
                        case FULL_TIME:
                            empHrs = 8;
                            break;
                        default:
                            empHrs = 0;
                    }
                    calcwage = empHrs * EMP_WAGE_PER_HOUR;
                    totalEmpWage += calcwage;
                    System.out.println("Employee daily Wage = " + calcwage + "Rs");

                }
                System.out.println("Total Emp Wage :" + totalEmpWage);
            }
        }
    }
}
