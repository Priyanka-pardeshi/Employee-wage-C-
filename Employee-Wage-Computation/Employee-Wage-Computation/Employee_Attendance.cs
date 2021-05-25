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


            Random objRandom = new Random();
            
            //Genarating random number for check employee is present or not
            int Check = objRandom.Next(0, 2);
            if (Check == IS_PRESENT)
            {
                Console.WriteLine(" Employee Is Present");
            }
            else
            {
                Console.WriteLine(" Employee is absent");
            }
        }
    }
}
