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
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_WAGE_PER_HR = 20;
            const int MAX_WORKING_DAYS = 20;

            //Variables
            int employeeHr = 0;
            int totalEmployeeWage = 0;
            int MonthlyWage = 0;
 
            //Genarating random number for check employee is present or not
            for (int i = 0; i < MAX_WORKING_DAYS; i++)
            {
            Random objRandom = new Random();
            int Check = objRandom.Next(0, 3);
            // switch statement            
                switch (Check)
                {
                    case 1:
                        employeeHr = 8;
                        Console.WriteLine("Employee is full Time");
                        break;
                    case 2:
                        Console.WriteLine("Emloyee is part time");
                        employeeHr = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        employeeHr = 0;
                        break;
                }//close switch
                totalEmployeeWage = employeeHr * EMP_WAGE_PER_HR;
                MonthlyWage = MonthlyWage + totalEmployeeWage; 
            }//close for
            //calculating Employee wage for month
            Console.WriteLine("Monthly total  wage is:"+MonthlyWage);
        }
        
    }
}
