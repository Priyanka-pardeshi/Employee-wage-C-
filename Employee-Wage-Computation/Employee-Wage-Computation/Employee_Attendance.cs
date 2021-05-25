using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation
{
    class Employee_Attendance
    {
        public void EmpPresent()
        {
            //Constants
            const int IS_PRESENT = 1;
            const int EMP_WAGE_PER_HR = 20;

            //Variables
            int employeeHr = 0;
            int totalEmployeeWage = 0;
            Random objRandom = new Random();
            
            //Genarating random number for check employee is present or not
            int Check = objRandom.Next(0, 2);
            if (Check == IS_PRESENT)
            {
                employeeHr = 8;
                Console.WriteLine(" Employee Is Present");
            }
            else
            {
                employeeHr = 0;
                Console.WriteLine(" Employee is absent");
            }
            //calculating Employee wage
            totalEmployeeWage = employeeHr * EMP_WAGE_PER_HR;
            Console.WriteLine("Employee Wage is :"+totalEmployeeWage);
        }
    }
}
