using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class Program
    { 
            //constant
            static final int FULL_TIME = 1;
            static final int EMP_WAGE_PER_HOUR = 20;
            static final int PART_TIME = 2;
            public static void main(String[] args)
            {
                System.out.println("Welcome to Employee Wage");
                int empCheck = (int)Math.floor(Math.random() * 10) % 3;
                int calcwage = 0;
                int empHrs = 0;
                switch (empCheck)
                {
                    case PART_TIME:
                        System.out.println("Empolyee is Present Part time");
                        empHrs = 4;
                        break;
                    case FULL_TIME:
                        System.out.println("Employee is Present Full time");
                        empHrs = 8;
                        break;
                    default:
                        System.out.println("Employee is Absent");
                        empHrs = 0;
                }
                calcwage = empHrs * EMP_WAGE_PER_HOUR;
                System.out.println("Employee daily Wage = " + calcwage + "Rs");



            }
        }
    }
}
