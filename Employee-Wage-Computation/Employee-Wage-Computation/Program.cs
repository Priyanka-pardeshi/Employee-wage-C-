using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greating Employee !");
            //Creating object for an Employee_attendance Class
            EmloyeeWage employee = new EmloyeeWage();
            employee.showSalary();
          
            Console.ReadKey();
        }
    }
}
